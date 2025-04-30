using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddMediatR(c => c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddSingleton<Slices.MainForm>();
        services.AddSingleton<Slices.Battery>();
        services.AddSingleton<Slices.Workstations>();
        
        return services;
    }
}
