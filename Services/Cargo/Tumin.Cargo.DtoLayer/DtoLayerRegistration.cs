using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Tumin.Cargo.DtoLayer.Mapping;

namespace Tumin.Cargo.DtoLayer;

public static class DtoLayerRegistration
{
    public static IServiceCollection AddDtoLayerServices(this IServiceCollection services)
    {
        services.AddAutoMapper(typeof(CargoCompanyMappingProfile));
        services.AddAutoMapper(typeof(CargoCustomerMappingProfile));
        services.AddAutoMapper(typeof(CargoDetailMappingProfile));
        services.AddAutoMapper(typeof(CargoOperationMappingProfile));
        
        return services;
    }
}