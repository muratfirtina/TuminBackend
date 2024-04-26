using Tumin.Catalog.Dtos.ProductDtos;

namespace Tumin.Catalog.Services.ProductServices;

public interface IProductService
{
    Task<List<ResultProductDto>>GetAllProductsAsync();
    Task CreateProductAsync(CreateProductDto createProductDto);
    Task UpdateProductAsync(UpdateProductDto updateProductDto);
    Task DeleteProductAsync(string productId);
    Task<GetByIdProductDto> GetProductByIdAsync(string productId);
}