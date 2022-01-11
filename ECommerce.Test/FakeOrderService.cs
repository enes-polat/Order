using ECommerce.Core.Entities;
using ECommerce.Service.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Test
{
    public class FakeOrderService : IOrderService
    {
        #region Fields
        private  List<Order> _fakeOrderService;
        private readonly OrderDetail _orderDetail;
        private readonly Product _product;
        private readonly Customer _customer;
        private readonly CustomerAddress _customerAddress;
        #endregion

        #region Ctor
        public FakeOrderService()
        {
            _customer = new Customer { Id = 1, MailAddress = "test@gmail.com", CreatedDate = DateTime.Now };
            _customerAddress = new CustomerAddress { Id = 1, Customer = _customer, AddressName = "Test", CreatedDate = DateTime.Now };
            _product = new Product { Id = 1, Price = 123, Stock = 5, IsActive = true, CreatedDate = DateTime.Now };
            _fakeOrderService = new List<Order>();
        }
        #endregion

        public Order Add(Order entity)
        {
            var order = new Order()
            {
                Id = 2,
                CustomerId = _customer.Id,
                CustomerAddressId = _customerAddress.Id,
                IsActive = true,
                OrderDetails =new List<OrderDetail> { _orderDetail },
                OrderNumber = $"ORD-{Guid.NewGuid().ToString().Substring(0, 5)}",
                TotalAmount = 100,
                CreatedDate = DateTime.Now
            };
            _fakeOrderService.Add(order);
            return  order;
        }

        public void Delete(Order entity)
        {
            _fakeOrderService.Remove(entity);
        }

        public async Task<Order> GetAsync(int id)
        {
           return _fakeOrderService.Find(x => x.Id == id);
        }

        public void Update(Order entity)
        {
            var order = _fakeOrderService.FirstOrDefault(a => a.Id == entity.Id);
            if (order != null)
                order = entity;
        }
        public async Task<Order> FindAsync(Expression<Func<Order, bool>> match)
        {
            throw new NotImplementedException();
        }
    }
}
