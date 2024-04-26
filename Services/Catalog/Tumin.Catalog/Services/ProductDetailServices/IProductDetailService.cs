using Tumin.Catalog.Dtos.ProductDetailDtos;

namespace Tumin.Catalog.Services.ProductDetailServices;

public interface IProductDetailService
{
    Task<List<ResultProductDetailDto>>GetAllProductDetailsAsync();
    Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto);
    Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto);
    Task DeleteProductDetailAsync(string productDetailId);
    Task<GetByIdProductDetailDto> GetProductDetailByIdAsync(string productDetailId);
}