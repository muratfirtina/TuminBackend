using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Tumin.Cargo.BusinessLayer.Abstract;
using Tumin.Cargo.BusinessLayer.Concrete;

namespace Tumin.Cargo.BusinessLayer;

public static class BussinesServiceRegistration
{
    public static IServiceCollection AddBussinesServices (this IServiceCollection services)
    {
        services.AddScoped<ICargoCompanyService, CargoCompanyManager>();
        services.AddScoped<ICargoDetailService, CargoDetailManager>();
        services.AddScoped<ICargoOperationService, CargoOperationManager>();
        services.AddScoped<ICargoCustomerService, CargoCustomerManager>();
        return services;
    }
    
    public static IServiceCollection AddSubClassesOfType(
        this IServiceCollection services,
        Assembly assembly,
        Type type,
        Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null
    )
    {
        var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
        foreach (Type? item in types)
            if (addWithLifeCycle == null)
                services.AddScoped(item);
            else
                addWithLifeCycle(services, type);
        return services;
    }
}