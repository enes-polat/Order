using ECommerce.Core.Entities;
using ECommerce.Data.Repository;

namespace ECommerce.Service.Abstract
{
    public interface IOrderDetailService : IRepository<OrderDetail>
    {
        //Here, special methods related to the OrderDetail are written.
    }
}
