using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Order.Application.Features.Mediator.Commands.OrderingCommands;
using Tumin.Order.Application.Features.Mediator.Queries.OrderingQueries;

namespace Tumin.Order.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderingsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllOrdering()
        {
            var result = await _mediator.Send(new GetOrderingQuery());
            return Ok(result);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderingById(string id)
        {
            var result = await _mediator.Send(new GetOrderingByIdQuery(id));
            return Ok(result);
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteOrdering(string id)
        {
            await _mediator.Send(new DeleteOrderingCommandRequest(id));
            return Ok("Silindi");
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateOrdering([FromBody] CreateOrderingCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Eklendi");
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateOrdering([FromBody] UpdateOrderingCommandRequest request)
        {
            await _mediator.Send(request);
            return Ok("Güncellendi");
        }
    }
    
}
