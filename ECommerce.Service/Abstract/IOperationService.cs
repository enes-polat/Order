using ECommerce.Core.Common;
using ECommerce.Entities.DTOs;
using System.Threading.Tasks;

namespace ECommerce.Service.Abstract
{
    public interface IOperationService
    {
        //Here, special methods related to the Operation are written.
        Task<Result<bool>> InsertOrderAsync(OrderDTO orderDto);
    }
}