using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Tumin.Order.Application.Features.CQRS.Handlers.AddressHandlers;
using Tumin.Order.Application.Features.CQRS.Handlers.OrderDetailHandlers;

namespace Tumin.Order.Application;

public static class ApplicationRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            ;
        });
        
        services.AddScoped<GetAllAddressQueryHandler>();
        services.AddScoped<GetAddressByIdQueryHandler>();
        services.AddScoped<CreateAddressCommandHandler>();
        services.AddScoped<DeleteAddressCommandHandler>();
        services.AddScoped<UpdateAddressCommandHandler>();
        services.AddScoped<GetAllOrderDetailQueryHandler>();
        services.AddScoped<GetOrderDetailByIdQueryHandler>();
        services.AddScoped<CreateOrderDetailCommandHandler>();
        services.AddScoped<DeleteOrderDetailCommandHandler>();
        services.AddScoped<UpdateOrderDetailCommandHandler>();
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