using Microsoft.Extensions.DependencyInjection;

namespace Item.Application;

public static class DependencyInjection
{
 
    public static IServiceCollection AddItemApplicationMediatR(this IServiceCollection services)
    {
        var assembly = typeof(DependencyInjection).Assembly;
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(assembly));

        return services;
    }
}
