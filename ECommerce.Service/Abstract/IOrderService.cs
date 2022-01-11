using ECommerce.Core.Entities;
using ECommerce.Data.Repository;

namespace ECommerce.Service.Abstract
{
    public interface IOrderService : IRepository<Order>
    {
        //Here, special methods related to the Order are written.
    }
}
