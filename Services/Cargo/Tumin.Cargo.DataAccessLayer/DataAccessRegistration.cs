using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Tumin.Cargo.DataAccessLayer.Abstract;
using Tumin.Cargo.DataAccessLayer.EntityFramework;

namespace Tumin.Cargo.DataAccessLayer;

public static class DataAccessRegistration
{
    public static IServiceCollection AddDataAccessServices(this IServiceCollection services)
    {
        services.AddScoped<ICargoCompanyDal, EfCargoCompanyDal>();
        services.AddScoped<ICargoCustomerDal, EfCargoCustomerDal>();
        services.AddScoped<ICargoDetailDal, EfCargoDetailDal>();
        services.AddScoped<ICargoOperationDal, EfCargoOperationDal>();
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