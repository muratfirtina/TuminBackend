using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Catalog.Dtos.ProductDetailDtos;
using Tumin.Catalog.Services.ProductDetailServices;

namespace Tumin.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductDetailsController : ControllerBase
    {
        private readonly IProductDetailService _productService;

        public ProductDetailsController(IProductDetailService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProductDetailImages()
        {
            var values = await _productService.GetAllProductDetailsAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductDetailById([FromRoute] string id)
        {
            var value = await _productService.GetProductDetailByIdAsync(id);
            return Ok(value);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateProductDetail([FromBody] CreateProductDetailDto createProductDetailDto)
        {
            await _productService.CreateProductDetailAsync(createProductDetailDto);
            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateProductDetail([FromBody] UpdateProductDetailDto updateProductDetailDto)
        {
            await _productService.UpdateProductDetailAsync(updateProductDetailDto);
            return Ok("Ürün detayı güncellendi");
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductDetail([FromRoute] string id)
        {
            await _productService.DeleteProductDetailAsync(id);
            return Ok("Ürün detayı silindi");
        }
    }
}
