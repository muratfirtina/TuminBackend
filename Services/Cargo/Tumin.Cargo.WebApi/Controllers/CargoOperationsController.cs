using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Cargo.BusinessLayer.Abstract;
using Tumin.Cargo.DtoLayer.CargoOperationDtos;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoOperationsController : ControllerBase
    {
        private readonly ICargoOperationService _cargoOperationService;
        private readonly IMapper _mapper;

        public CargoOperationsController(ICargoOperationService cargoOperationService, IMapper mapper)
        {
            _cargoOperationService = cargoOperationService;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllCargoOperations()
        {
            var cargoOperations = await _cargoOperationService.TGetAllAsync();
            return Ok(cargoOperations);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCargoOperationById(int id)
        {
            var cargoOperation = await _cargoOperationService.TGetByIdAsync(id);
            return Ok(cargoOperation);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateCargoOperation([FromBody] CreateCargoOperationDto createCargoOperationDto)
        {
            var cargoOperation = _mapper.Map<CargoOperation>(createCargoOperationDto);
            await _cargoOperationService.TCreateAsync(cargoOperation);
            return Ok(cargoOperation);
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateCargoOperation([FromBody] UpdateCargoOperationDto updateCargoOperationDto)
        {
            var cargoOperation = _mapper.Map<CargoOperation>(updateCargoOperationDto);
            await _cargoOperationService.TUpdateAsync(cargoOperation);
            return Ok(cargoOperation);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCargoOperation(int id)
        {
            await _cargoOperationService.TDeleteAsync(id);
            return Ok();
        }
    }
}
