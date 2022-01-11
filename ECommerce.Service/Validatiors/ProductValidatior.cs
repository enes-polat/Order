using ECommerce.Core.Entities;
using FluentValidation;

namespace ECommerce.Service.Validatiors
{
    public class ProductValidatior : AbstractValidator<Product>
    {
        public ProductValidatior()
        {
        }
    }
}
