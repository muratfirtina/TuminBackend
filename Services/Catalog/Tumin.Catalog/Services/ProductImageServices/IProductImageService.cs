using Tumin.Catalog.Dtos.ProductImageDtos;

namespace Tumin.Catalog.Services.ProductImageServices;

public interface IProductImageService
{
    Task<List<ResultProductImageDto>>GetAllProductImagesAsync();
    Task CreateProductImageAsync(CreateProductImageDto createProductImageDto);
    Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto);
    Task DeleteProductImageAsync(string productImageId);
    Task<GetByIdProductImageDto> GetProductImageByIdAsync(string productImageId);
}