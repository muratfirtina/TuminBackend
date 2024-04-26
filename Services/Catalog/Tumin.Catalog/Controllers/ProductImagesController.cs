using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Catalog.Dtos.ProductImageDtos;
using Tumin.Catalog.Services.ProductImageServices;

namespace Tumin.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductImageImagesController : ControllerBase
    {
        private readonly IProductImageService _productService;

        public ProductImageImagesController(IProductImageService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductImageImages()
        {
            var values = await _productService.GetAllProductImagesAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductImageById([FromRoute] string id)
        {
            var value = await _productService.GetProductImageByIdAsync(id);
            return Ok(value);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateProductImage([FromBody] CreateProductImageDto createProductImageDto)
        {
            await _productService.CreateProductImageAsync(createProductImageDto);
            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateProductImage([FromBody] UpdateProductImageDto updateProductImageDto)
        {
            await _productService.UpdateProductImageAsync(updateProductImageDto);
            return Ok("Ürün fotoğrafı güncellendi");
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductImage([FromRoute] string id)
        {
            await _productService.DeleteProductImageAsync(id);
            return Ok("Ürün fotoğrafı silindi");
        }
    }
}
