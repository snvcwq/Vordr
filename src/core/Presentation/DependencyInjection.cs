using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Options;
using Presentation.Socket;
using System.Reflection;

namespace Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(c => c.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddSingleton<SocketSettings>();
        services.Configure<SocketOptions>(configuration.GetSection(nameof(SocketOptions)));
        services.AddSingleton<Slices.MainForm>();
        services.AddSingleton<Slices.Battery>();
        services.AddSingleton<Slices.Workstations>();
        
        return services;
    }
}
