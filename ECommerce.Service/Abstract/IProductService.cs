using ECommerce.Core.Entities;
using ECommerce.Data.Repository;

namespace ECommerce.Service.Abstract
{
    public interface IProductService : IRepository<Product>
    {
        //Here, special methods related to the IProduct are written.
    }
}
