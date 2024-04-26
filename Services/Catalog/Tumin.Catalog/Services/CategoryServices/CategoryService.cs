using AutoMapper;
using MongoDB.Driver;
using Tumin.Catalog.Dtos.CategoryDtos;
using Tumin.Catalog.Entities;
using Tumin.Catalog.Settings;

namespace Tumin.Catalog.Services.CategoryServices;

public class CategoryService: ICategoryService
{
    private readonly IMongoCollection<Category> _categoryCollection;
    private readonly IMapper _mapper;

    public CategoryService(IMapper mapper,IDatabaseSettings _databaseSettings)
    {
        var client = new MongoClient(_databaseSettings.ConnectionString);
        var database = client.GetDatabase(_databaseSettings.DatabaseName);
        _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
        _mapper = mapper;
    }
    

    public async Task<List<ResultCategoryDto>> GetAllCategoriesAsync()
    {
        var values = await _categoryCollection.Find(x => true).ToListAsync();
        return _mapper.Map<List<ResultCategoryDto>>(values);
    }

    public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
    {
        var value = _mapper.Map<Category>(createCategoryDto);
        await _categoryCollection.InsertOneAsync(value);
    }

    public async Task UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
    {
        var value = _mapper.Map<Category>(updateCategoryDto);
        await _categoryCollection.FindOneAndReplaceAsync(x => x.CategoryId == updateCategoryDto.CategoryId, value);
        
    }

    public async Task DeleteCategoryAsync(string categoryId)
    {
        await _categoryCollection.DeleteOneAsync(x => x.CategoryId == categoryId);
        
    }

    public async Task<GetByIdCategoryDto> GetCategoryByIdAsync(string categoryId)
    {
        var value = await _categoryCollection.Find(x => x.CategoryId == categoryId).FirstOrDefaultAsync();
        return _mapper.Map<GetByIdCategoryDto>(value);
    }
}