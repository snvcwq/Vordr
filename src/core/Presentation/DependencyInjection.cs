using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Options;
using Presentation.SendNotfication;
using Presentation.Socket;
using System.Reflection;
using Vordr.Application.Battery.Queries;
using Vordr.Application.Common.Behaviours;
using Vordr.Application.Notfication.SendNotfication;

namespace Presentation;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services, IConfiguration configuration)
    {
        var asm = typeof(GetBatteryUsageQuery).Assembly;
        var asm2 = typeof(SendNotificationCommand).Assembly;
        services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(typeof(GetBatteryUsageQuery).Assembly);
            cfg.RegisterServicesFromAssembly(typeof(SendNotificationCommand).Assembly);
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        });
        services.AddSingleton<SocketSettings>();
        services.Configure<SocketOptions>(configuration.GetSection(nameof(SocketOptions)));
        services.AddSingleton<Slices.MainForm>();
        services.AddSingleton<Slices.Workstations>();
        
        return services;
    }
}
