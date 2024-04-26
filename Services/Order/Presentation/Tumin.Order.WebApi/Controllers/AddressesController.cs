using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Order.Application.Features.CQRS.Commands.AddressCommands;
using Tumin.Order.Application.Features.CQRS.Handlers.AddressHandlers;
using Tumin.Order.Application.Features.CQRS.Queries.AddressQueries;

namespace Tumin.Order.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private readonly GetAllAddressQueryHandler _getAllAddressQueryHandler;
        private readonly GetAddressByIdQueryHandler _getAddressByIdQueryHandler;
        private readonly CreateAddressCommandHandler _createAddressCommandHandler;
        private readonly DeleteAddressCommandHandler _deleteAddressCommandHandler;
        private readonly UpdateAddressCommandHandler _updateAddressCommandHandler;

        public AddressesController(GetAllAddressQueryHandler getAllAddressQueryHandler, GetAddressByIdQueryHandler getAddressByIdQueryHandler, CreateAddressCommandHandler createAddressCommandHandler, DeleteAddressCommandHandler deleteAddressCommandHandler, UpdateAddressCommandHandler updateAddressCommandHandler)
        {
            _getAllAddressQueryHandler = getAllAddressQueryHandler;
            _getAddressByIdQueryHandler = getAddressByIdQueryHandler;
            _createAddressCommandHandler = createAddressCommandHandler;
            _deleteAddressCommandHandler = deleteAddressCommandHandler;
            _updateAddressCommandHandler = updateAddressCommandHandler;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllAddress()
        {
            var result = await _getAllAddressQueryHandler.Handle();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAddressById(string id)
        {
            var result = await _getAddressByIdQueryHandler.Handle(new GetAddressByIdQuery(id));
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAddress([FromBody] CreateAddressCommand createAddressCommand)
        {
            await _createAddressCommandHandler.Handle(createAddressCommand);
            return Ok("Başarıyla eklendi");
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteAddress(string id)
        {
            await _deleteAddressCommandHandler.Handle(new DeleteAddressCommand(id));
            return Ok("Silindi");
        }
        
        
        [HttpPut]
        public async Task<IActionResult> UpdateAddress([FromBody] UpdateAddressCommand updateAddressCommand)
        {
            await _updateAddressCommandHandler.Handle(updateAddressCommand);
            return Ok("Güncellendi");
        }
        
        
        
    }
    
}
