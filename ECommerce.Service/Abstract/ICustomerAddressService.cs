using ECommerce.Core.Entities;
using ECommerce.Data.Repository;

namespace ECommerce.Service.Abstract
{
    public interface ICustomerAddressService : IRepository<CustomerAddress>
    {
        //Here, special methods related to the CustomerAddress are written.
        CustomerAddress GetById(int id);
    }
}
