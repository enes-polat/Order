using ECommerce.Core.Entities;
using FluentValidation;

namespace ECommerce.Service.Validatiors
{
    public class OrderValidatior : AbstractValidator<Order>
    {
        public OrderValidatior()
        {
        }
    }
}
