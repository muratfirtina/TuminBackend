using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Cargo.BusinessLayer.Abstract;
using Tumin.Cargo.DtoLayer.CargoDetailDtos;
using Tumin.Cargo.EntityLayer.Concrete;

namespace Tumin.Cargo.WebApi.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CargoDetailsController : ControllerBase
    {
        private readonly ICargoDetailService _cargoDetailService;
        private readonly IMapper _mapper;

        public CargoDetailsController(ICargoDetailService cargoDetailService, IMapper mapper)
        {
            _cargoDetailService = cargoDetailService;
            _mapper = mapper;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetAllCargoDetails()
        {
            var cargoDetails = await _cargoDetailService.TGetAllAsync();
            return Ok(cargoDetails);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCargoDetailById(int id)
        {
            var cargoDetail = await _cargoDetailService.TGetByIdAsync(id);
            return Ok(cargoDetail);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateCargoDetail([FromBody] CreateCargoDetailDto createCargoDetailDto)
        {
            var cargoDetail = _mapper.Map<CargoDetail>(createCargoDetailDto);
            await _cargoDetailService.TCreateAsync(cargoDetail);
            return Ok(cargoDetail);
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateCargoDetail([FromBody] UpdateCargoDetailDto updateCargoDetailDto)
        {
            var cargoDetail = _mapper.Map<CargoDetail>(updateCargoDetailDto);
            await _cargoDetailService.TUpdateAsync(cargoDetail);
            return Ok(cargoDetail);
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCargoDetail(int id)
        {
            await _cargoDetailService.TDeleteAsync(id);
            return Ok();
        }
        
    }
}
