using ECommerce.Core.Entities;
using ECommerce.Data.Repository;

namespace ECommerce.Service.Abstract
{
    public interface ICustomerService : IRepository<Customer>
    {
        //Here, special methods related to the Customer are written.
    }
}
