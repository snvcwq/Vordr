using Vordr.Application.Common.Behaviours;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Application.Services;

namespace Vordr.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection serviceCollection)
    {

        serviceCollection.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        serviceCollection.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        });
        
        serviceCollection.RegisterServices();
        
        
        return serviceCollection;
    }
    
    private static IServiceCollection RegisterServices(this IServiceCollection serviceCollection)
    {

        serviceCollection.AddScoped<IProcessCollectService, ProcessCollectService>();
        serviceCollection.AddScoped<IRamUsageCollectService, RamUsageCollectService>();
        serviceCollection.AddScoped<ICpuLoadCollectService, CpuLoadCollectService>();

        return serviceCollection;
    }
    
}
