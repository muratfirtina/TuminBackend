using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Cargo.BusinessLayer.Abstract;
using Tumin.Cargo.DtoLayer.CargoCustomerDtos;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCustomersController : ControllerBase
    {
        private readonly ICargoCustomerService _cargoCustomerService;
        private readonly IMapper _mapper;

        public CargoCustomersController(ICargoCustomerService cargoCustomerService, IMapper mapper)
        {
            _cargoCustomerService = cargoCustomerService;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllCargoCustomers()
        {
            var cargoCustomers = await _cargoCustomerService.TGetAllAsync();
            return Ok(cargoCustomers);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCargoCustomerById(int id)
        {
            var cargoCustomer = await _cargoCustomerService.TGetByIdAsync(id);
            return Ok(cargoCustomer);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateCargoCustomer([FromBody] CreateCargoCustomerDto createCargoCustomerDto)
        {
            var cargoCustomer = _mapper.Map<CargoCustomer>(createCargoCustomerDto);
            var result = await _cargoCustomerService.TCreateAsync(cargoCustomer);
            return Ok(result);
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateCargoCustomer([FromBody] UpdateCargoCustomerDto updateCargoCustomerDto)
        {
            var cargoCustomer = _mapper.Map<CargoCustomer>(updateCargoCustomerDto);
            var result = await _cargoCustomerService.TUpdateAsync(cargoCustomer);
            return Ok(result);
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteCargoCustomer(int id)
        {
            var result = await _cargoCustomerService.TDeleteAsync(id);
            return Ok(result);
        }
    }
}
