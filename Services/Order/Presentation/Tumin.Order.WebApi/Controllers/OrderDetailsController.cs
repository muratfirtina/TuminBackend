using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Order.Application.Features.CQRS.Commands.OrderDetailCommands;
using Tumin.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;
using Tumin.Order.Application.Features.CQRS.Queries.OrderDetailQueries;

namespace Tumin.Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailsController : ControllerBase
    {
        private readonly GetAllOrderDetailQueryHandler _getAllOrderDetailQueryHandler;
        private readonly GetOrderDetailByIdQueryHandler _getOrderDetailByIdQueryHandler;
        private readonly CreateOrderDetailCommandHandler _createOrderDetailCommandHandler;
        private readonly DeleteOrderDetailCommandHandler _deleteOrderDetailCommandHandler;
        private readonly UpdateOrderDetailCommandHandler _updateOrderDetailCommandHandler;

        public OrderDetailsController(GetAllOrderDetailQueryHandler getAllOrderDetailQueryHandler, GetOrderDetailByIdQueryHandler getOrderDetailByIdQueryHandler, CreateOrderDetailCommandHandler createOrderDetailCommandHandler, DeleteOrderDetailCommandHandler deleteOrderDetailCommandHandler, UpdateOrderDetailCommandHandler updateOrderDetailCommandHandler)
        {
            _getAllOrderDetailQueryHandler = getAllOrderDetailQueryHandler;
            _getOrderDetailByIdQueryHandler = getOrderDetailByIdQueryHandler;
            _createOrderDetailCommandHandler = createOrderDetailCommandHandler;
            _deleteOrderDetailCommandHandler = deleteOrderDetailCommandHandler;
            _updateOrderDetailCommandHandler = updateOrderDetailCommandHandler;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllOrderDetail()
        {
            var result = await _getAllOrderDetailQueryHandler.Handle();
            return Ok(result);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderDetailById(string id)
        {
            var result = await _getOrderDetailByIdQueryHandler.Handle(new GetOrderDetailByIdQuery(id));
            return Ok(result);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateOrderDetail([FromBody] CreateOrderDetailCommand createOrderDetailCommand)
        {
            await _createOrderDetailCommandHandler.Handle(createOrderDetailCommand);
            return Ok("Başarıyla eklendi");
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteOrderDetail(string id)
        {
            await _deleteOrderDetailCommandHandler.Handle(new DeleteOrderDetailCommand(id));
            return Ok("Silindi");
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetail([FromBody] UpdateOrderDetailCommand updateOrderDetailCommand)
        {
            await _updateOrderDetailCommandHandler.Handle(updateOrderDetailCommand);
            return Ok("Güncellendi");
        }
        
    }
}
