using AutoMapper;
using ECommerce.Core.Common;
using ECommerce.Core.Entities;
using ECommerce.Entities.DTOs;
using ECommerce.Service.Abstract;
using ECommerce.Service.Validatiors;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce.Service.Concrete
{
    public class OperationService : IOperationService
    {
        private readonly IOrderService _orderService;
        private readonly IOrderDetailService _orderDetailService;
        private readonly ICustomerService _customerService;
        private readonly ICustomerAddressService _customerAddressService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public OperationService(IOrderService orderService, IOrderDetailService orderDetailService, ICustomerService customerService, ICustomerAddressService customerAddressService, IProductService productService, IMapper mapper)
        {
            _orderService = orderService;
            _orderDetailService = orderDetailService;
            _customerService = customerService;
            _customerAddressService = customerAddressService;
            _productService = productService;
            _mapper = mapper;
        }

        #region Methods
        public async Task<Result<bool>> InsertOrderAsync(OrderDTO orderDto)
        {
            try
            {
                OrderDTOValidatior validatior = new OrderDTOValidatior();
                ValidationResult result = validatior.Validate(orderDto);
                if (!result.IsValid)
                {
                    return new Result<bool> { Success = false, Message = $"Hatalar:{string.Join(",", result.Errors)}" };
                }

                var customerEntity = _mapper.Map<Customer>(orderDto.CustomerDTO);
                var customer = _customerService.GetAsync(customerEntity.Id).Result;
                if (customer == null)
                    customer = _customerService.Add(customerEntity);

                var customerAddress = _customerAddressService.GetById(orderDto.CustomerDTO.AddressId);
                if (customerAddress == null)
                    customerAddress = _customerAddressService.Add(new CustomerAddress { CustomerId = customer.Id, AddressName = "Test1", CreatedDate = DateTime.Now });

                var product = await _productService.GetAsync(orderDto.ProductId);
                if (product == null)
                    product = _productService.Add(new Product { Code = "Test1", Stock = orderDto.Stock, IsActive = true, Price = orderDto.BillingDTO.ItemPrice, CreatedDate = DateTime.Now });
                else
                {
                    if (product.Stock <= orderDto.Quantity)
                    {
                        return new Result<bool> { Success = false, Message = $"İstenilen miktarda ürüne ait stok bulunmamaktadır." };
                    }
                }

                string orderNumber = $"ORD-{Guid.NewGuid().ToString().Substring(0, 5)}";
                var order = _orderService.Add(
                    new Order
                    {
                        CustomerId = customer.Id,
                        OrderNumber = orderNumber,
                        CustomerAddressId = customerAddress.Id,
                        IsActive = true,
                        TotalAmount = orderDto.BillingDTO.ItemPrice * product.Price,
                        OrderDetails = new List<OrderDetail> { new OrderDetail { ProductId = product.Id, CreatedDate = DateTime.Now, UnitPrice = product.Price, Quantity = orderDto.Quantity } },
                        CreatedDate = DateTime.Now
                    });

                if (order != null)
                {
                    product.Stock -= orderDto.Quantity;
                    _productService.Update(product);
                    return new Result<bool> { Success = true, Message = $"{orderNumber} Numaralı siparişiniz oluştu." };
                }
                else
                    return new Result<bool> { Success = false, Message = $"Sipariş oluştururken hata oluştu." };

            }
            catch (Exception exception)
            {
                return new Result<bool> { Success = false, Message = $"İşlem yapılırken hata oluştu.", InnerMessage = $"İşlem yapılırken hata oluştu. Detay :{exception.Message}", Data = false };
            }
        } 
        #endregion
    }
}
