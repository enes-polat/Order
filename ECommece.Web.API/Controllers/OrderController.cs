using ECommerce.Entities.DTOs;
using ECommerce.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommece.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        #region Fields
        private readonly IOrderService _orderService;
        private readonly IOperationService _operationService;
        #endregion

        #region Ctor
        public OrderController(IOrderService orderService,
                         IOperationService operationService)
        {
            _orderService = orderService;
            _operationService = operationService;
        }
        #endregion

        #region Methods

        /// <summary>
        /// Verilen sipariş numnarasına ait sipariş bilgilerini geriye döner.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [Route("GetOrderById")]
        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _orderService.GetAsync(id));
        }

        /// <summary>
        /// Sisteme sipariş oluşturulması için çalışması gerekir.
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [Route("Add")]
        [HttpPost]
        public async Task<IActionResult> Add(OrderDTO order)
        {
            var orderResult = _operationService.InsertOrderAsync(order);
            return Ok(orderResult.Result);
        }
        #endregion
    }
}
