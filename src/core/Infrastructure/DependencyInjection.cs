using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Domain.Enums;
using Vordr.Infrastructure.Migrations;
using Vordr.Infrastructure.Migrations.Configuration;
using Vordr.Infrastructure.Options;
using Vordr.Infrastructure.Persistence;
using Vordr.ResourceMonitoring.Linux;
using Vordr.ResourceMonitoring.MacOs;

namespace Vordr.Infrastructure;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddInfrastructureServices(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<MongoDbOptions>(builder.Configuration.GetSection(nameof(MongoDbOptions)));

        builder.Services.AddSingleton<MongoDbClient>();
        builder.Services.AddSingleton<MongoMigrationPerformer>();

        builder.Services.AddMigrations();

        builder.DefineResourceCollectors();
        return builder;
    }

    private static IServiceCollection AddMigrations(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<SeedDefaultConfigurationMigration>();
        return serviceCollection;
    }
    
    
    private static WebApplicationBuilder DefineResourceCollectors(this WebApplicationBuilder builder)
    {
        if (OperatingSystem.IsMacOS())
            builder.AddMacOsResourceCollectors();
        else if (OperatingSystem.IsLinux())
            builder.AddLinuxResourceCollectors();
        else if (OperatingSystem.IsWindows())
            builder.AddWindowsResourceCollectors();
        else
            throw new UnsupportedOsPlatformException("Application runs on unsupported Operating System");
        return builder;
    }

    
}
