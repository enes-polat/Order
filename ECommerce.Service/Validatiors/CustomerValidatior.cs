using ECommerce.Core.Entities;
using FluentValidation;

namespace ECommerce.Service.Validatiors
{
    public class CustomerValidatior : AbstractValidator<Customer>
    {
        public CustomerValidatior()
        {
        }
    }
}
