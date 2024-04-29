using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Cargo.BusinessLayer.Abstract;
using Tumin.Cargo.DtoLayer.CargoCompanyDtos;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoCompaniesController : ControllerBase
    {
        private readonly ICargoCompanyService _cargoCompanyService;
        private readonly IMapper _mapper;

        public CargoCompaniesController(ICargoCompanyService cargoCompanyService, IMapper mapper)
        {
            _cargoCompanyService = cargoCompanyService;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllCargoCompanies()
        {
            var result = await _cargoCompanyService.TGetAllAsync();
            return Ok(result);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCargoCompanyById(int id)
        {
            var result = await _cargoCompanyService.TGetByIdAsync(id);
            return Ok(result);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateCargoCompany([FromBody] CreateCargoCompanyDto createCargoCompanyDto)
        {
            var cargoCompany = _mapper.Map<CargoCompany>(createCargoCompanyDto);
            var result = await _cargoCompanyService.TCreateAsync(cargoCompany);
            return Ok("Eklendi");
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateCargoCompany([FromBody] UpdateCargoCompanyDto updateCargoCompanyDto)
        {
            var cargoCompany = _mapper.Map<CargoCompany>(updateCargoCompanyDto);
            var result = await _cargoCompanyService.TUpdateAsync(cargoCompany);
            return Ok("Güncellendi");
        }
        
        [HttpDelete]
        public async Task<IActionResult> DeleteCargoCompany(int id)
        {
            var result = await _cargoCompanyService.TDeleteAsync(id);
            return Ok("Silindi");
        }
        
    }
}
