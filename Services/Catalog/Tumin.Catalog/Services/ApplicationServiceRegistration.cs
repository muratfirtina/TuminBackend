using System.Reflection;
using Microsoft.Extensions.Options;
using Tumin.Catalog.Services.CategoryServices;
using Tumin.Catalog.Services.ProductDetailServices;
using Tumin.Catalog.Services.ProductImageServices;
using Tumin.Catalog.Services.ProductServices;
using Tumin.Catalog.Settings;

namespace Tumin.Catalog.Services;

public static class ApplicationServiceRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IProductImageService, ProductImageService>();
        services.AddScoped<IProductDetailService, ProductDetailService>();

        services.AddAutoMapper(Assembly.GetExecutingAssembly());

        services.Configure<DatabaseSettings>(configuration.GetSection("DatabaseSettings"));
        services.AddScoped<IDatabaseSettings>(sp => sp.GetRequiredService<IOptions<DatabaseSettings>>().Value);

        return services;
    }
}