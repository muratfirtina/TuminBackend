using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tumin.Catalog.Dtos.CategoryDtos;
using Tumin.Catalog.Services.CategoryServices;

namespace Tumin.Catalog.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategories()
        {
            var values = await _categoryService.GetAllCategoriesAsync();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryById([FromRoute] string id)
        {
            var value = await _categoryService.GetCategoryByIdAsync(id);
            return Ok(value);
        }
        
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryDto createCategoryDto)
        {
            await _categoryService.CreateCategoryAsync(createCategoryDto);
            return Ok();
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateCategory([FromBody] UpdateCategoryDto updateCategoryDto)
        {
            await _categoryService.UpdateCategoryAsync(updateCategoryDto);
            return Ok("Kategori güncellendi");
        }
        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory([FromRoute] string id)
        {
            await _categoryService.DeleteCategoryAsync(id);
            return Ok("Kategori silindi");
        }
    }
}
