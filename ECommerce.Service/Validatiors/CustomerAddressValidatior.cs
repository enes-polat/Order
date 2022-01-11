using ECommerce.Core.Entities;
using FluentValidation;

namespace ECommerce.Service.Validatiors
{
    public class CustomerAddressValidatior : AbstractValidator<CustomerAddress>
    {
        public CustomerAddressValidatior()
        {
        }
    }
}
