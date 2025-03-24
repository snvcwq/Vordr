using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddMediatR(c => c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddSingleton<Slices.MainForm>();
        services.AddSingleton<Slices.Cpu>();
        services.AddSingleton<Slices.Dashboard>();
        services.AddSingleton<Slices.Drives>();
        services.AddSingleton<Slices.Gpu>();
        services.AddSingleton<Slices.Monitoring>();
        services.AddSingleton<Slices.Processes>();
        services.AddSingleton<Slices.Battery>();
        services.AddSingleton<Slices.Ram>();
        
        return services;
    }
}
