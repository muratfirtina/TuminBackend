using AutoMapper;
using MongoDB.Driver;
using Tumin.Catalog.Dtos.ProductImageDtos;
using Tumin.Catalog.Entities;
using Tumin.Catalog.Settings;

namespace Tumin.Catalog.Services.ProductImageServices;

public class ProductImageService:IProductImageService
{
    private readonly IMongoCollection<ProductImage> _productImageCollection;
    private readonly IMapper _mapper;

    public ProductImageService(IMapper mapper,IDatabaseSettings _databaseSettings)
    {
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _productImageCollection = database.GetCollection<ProductImage>(_databaseSettings.ProductImageCollectionName);
        _mapper = mapper;
    }
    

    public async Task<List<ResultProductImageDto>> GetAllProductImagesAsync()
    {
        var values = await _productImageCollection.Find(x => true).ToListAsync();
        return _mapper.Map<List<ResultProductImageDto>>(values);
    }

    public async Task CreateProductImageAsync(CreateProductImageDto createProductImageDto)
    {
        var value = _mapper.Map<ProductImage>(createProductImageDto);
        await _productImageCollection.InsertOneAsync(value);
    }

    public async Task UpdateProductImageAsync(UpdateProductImageDto updateProductImageDto)
    {
        var value = _mapper.Map<ProductImage>(updateProductImageDto);
        await _productImageCollection.FindOneAndReplaceAsync(x => x.ProductImageId == updateProductImageDto.ProductImageId, value);
        
    }

    public async Task DeleteProductImageAsync(string productImageId)
    {
        await _productImageCollection.DeleteOneAsync(x => x.ProductImageId == productImageId);
        
    }

    public async Task<GetByIdProductImageDto> GetProductImageByIdAsync(string productImageId)
    {
        var value = await _productImageCollection.Find(x => x.ProductImageId == productImageId).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdProductImageDto>(value);
    }
}