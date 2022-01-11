using ECommerce.Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Service.Validatiors
{
    public class OrderDTOValidatior : AbstractValidator<OrderDTO>
    {
        public OrderDTOValidatior()
        {
            RuleFor(x => x.Quantity).GreaterThan(0).WithMessage("Adet değeri 0 olamaz!");
            RuleFor(x => x.ProductId).NotEmpty().WithMessage("ProductId kodu olamaz!");
            RuleFor(x => x.ProductId).GreaterThan(0).WithMessage("ProductId değeri 0 olamaz!");

            RuleFor(x => x.CustomerDTO).ChildRules(y =>
            {
                y.RuleFor(x => x.AddressId).NotEmpty().WithMessage("AddressId adı boş olamaz!");
                y.RuleFor(x => x.CustomerId).NotEmpty().WithMessage("CustomerId boş olamaz!!");
                y.RuleFor(x => x.AddressId).GreaterThan(0).WithMessage("AddressId değeri 0 olamaz!");
                y.RuleFor(x => x.CustomerId).GreaterThan(0).WithMessage("CustomerId değeri 0 olamaz!");
            });
            RuleFor(x => x.BillingDTO).ChildRules(y =>
            {
                y.RuleFor(x => x.ItemPrice).GreaterThan(0).WithMessage("Ürün fiyatı 0 olamaz!");
            });
        }
    }
}
