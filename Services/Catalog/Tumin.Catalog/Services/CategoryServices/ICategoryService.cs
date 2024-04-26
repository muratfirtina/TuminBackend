using Tumin.Catalog.Dtos.CategoryDtos;

namespace Tumin.Catalog.Services.CategoryServices;

public interface ICategoryService
{
    Task<List<ResultCategoryDto>>GetAllCategoriesAsync();
    Task CreateCategoryAsync(CreateCategoryDto createCategoryDto);
    Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto);
    Task DeleteCategoryAsync(string categoryId);
    Task<GetByIdCategoryDto> GetCategoryByIdAsync(string categoryId);
}