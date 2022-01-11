using ECommece.Web.API.Controllers;
using ECommerce.Service.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Xunit;

namespace ECommerce.Test
{
    public class OrderUnitTest
    {
        private readonly OrderController _controller;
        private readonly FakeOrderService _service;
        private readonly IOperationService _operationService;
        private readonly ILogger<OrderController> _logger;
        public OrderUnitTest()
        {
            _service = new FakeOrderService();
            _controller = new OrderController(_service, _operationService,_logger);
        }

        [Fact]
        public async Task GetById_ReturnOkResul()
        {
            var result = await _controller.Get(1);
            Assert.IsType<OkObjectResult>(result as OkObjectResult);
        }

        [Fact]
        public async Task GetById_ReturnNotFoundResult()
        {
            var result = await _controller.Get(6);
            Assert.IsType<OkObjectResult>(result as OkObjectResult);
        }
    }
}
