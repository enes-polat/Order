using ECommerce.Core.Entities;
using FluentValidation;

namespace ECommerce.Service.Validatiors
{
    public class OrderDetailValidatior : AbstractValidator<OrderDetail>
    {
        public OrderDetailValidatior()
        {
        }
    }
}
