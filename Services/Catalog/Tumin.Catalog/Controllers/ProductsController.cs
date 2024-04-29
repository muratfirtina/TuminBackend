using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Catalog.Dtos.ProductDtos;
using Tumin.Catalog.Services.ProductServices;

namespace Tumin.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var values = await _productService.GetAllProductsAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] string id)
        {
            var value = await _productService.GetProductByIdAsync(id);
            return Ok(value);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductDto createProductDto)
        {
            await _productService.CreateProductAsync(createProductDto);
            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductDto updateProductDto)
        {
            await _productService.UpdateProductAsync(updateProductDto);
            return Ok("Ürün güncellendi");
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute] string id)
        {
            await _productService.DeleteProductAsync(id);
            return Ok("Ürün silindi");
        }
    }
}
