using Microsoft.AspNetCore.Builder;
using Vordr.Application.Common.Behaviours;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Application.Services;

namespace Vordr.Application;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddApplicationServices(this WebApplicationBuilder builder)
    {

        builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        builder.Services.AddMediatR(cfg => {
            cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(PerformanceBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(LoggingBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(UnhandledExceptionBehaviour<,>));
            cfg.AddBehavior(typeof(IPipelineBehavior<,>), typeof(ValidationBehaviour<,>));
        });
        
        builder.Services.RegisterServices();
        
        
        return builder;
    }
    
    private static IServiceCollection RegisterServices(this IServiceCollection serviceCollection)
    {

        serviceCollection.AddScoped<IProcessSyncService, ProcessSyncService>();

        
        return serviceCollection;
    }
    
}
