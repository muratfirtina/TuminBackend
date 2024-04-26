using AutoMapper;
using MongoDB.Driver;
using Tumin.Catalog.Dtos.ProductDetailDtos;
using Tumin.Catalog.Entities;
using Tumin.Catalog.Settings;

namespace Tumin.Catalog.Services.ProductDetailServices;

public class ProductDetailService: IProductDetailService
{
    private readonly IMongoCollection<ProductDetail> _productDetailCollection;
    private readonly IMapper _mapper;

    public ProductDetailService(IMapper mapper,IDatabaseSettings _databaseSettings)
    {
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _productDetailCollection = database.GetCollection<ProductDetail>(_databaseSettings.ProductDetailCollectionName);
        _mapper = mapper;
    }
    

    public async Task<List<ResultProductDetailDto>> GetAllProductDetailsAsync()
    {
        var values = await _productDetailCollection.Find(x => true).ToListAsync();
        return _mapper.Map<List<ResultProductDetailDto>>(values);
    }

    public async Task CreateProductDetailAsync(CreateProductDetailDto createProductDetailDto)
    {
        var value = _mapper.Map<ProductDetail>(createProductDetailDto);
        await _productDetailCollection.InsertOneAsync(value);
    }

    public async Task UpdateProductDetailAsync(UpdateProductDetailDto updateProductDetailDto)
    {
        var value = _mapper.Map<ProductDetail>(updateProductDetailDto);
        await _productDetailCollection.FindOneAndReplaceAsync(x => x.ProductDetailId == updateProductDetailDto.ProductDetailId, value);
        
    }

    public async Task DeleteProductDetailAsync(string productDetailId)
    {
        await _productDetailCollection.DeleteOneAsync(x => x.ProductDetailId == productDetailId);
        
    }

    public async Task<GetByIdProductDetailDto> GetProductDetailByIdAsync(string productDetailId)
    {
        var value = await _productDetailCollection.Find(x => x.ProductDetailId == productDetailId).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdProductDetailDto>(value);
    }
}