using Hangfire.Mongo;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Application.Services;
using Vordr.Domain.Enums;
using Vordr.Infrastructure.BackgroundJobs;
using Vordr.Infrastructure.Migrations;
using Vordr.Infrastructure.Migrations.Configuration;
using Vordr.Infrastructure.Options;
using Vordr.Infrastructure.Persistence;
using Vordr.Infrastructure.Persistence.Repositories;
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
        builder.Services.RegisterRepositories();
        builder.Services.InitHangfire();
        
        builder.Services.DefineSchedulers();
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


    private static IServiceCollection RegisterRepositories(this IServiceCollection serviceCollection)
    {

        serviceCollection.AddScoped<IProcessDataRepository, ProcessDataRepository>();
        serviceCollection.AddScoped<IProcessMetricsRepository, ProcessMetricsRepository>();
        serviceCollection.AddScoped<IMonitoringConfigurationRepository, MonitoringConfigurationRepository>();

        
        return serviceCollection;
    }
    
    private static IServiceCollection InitHangfire(this IServiceCollection serviceCollection)
    {
        using var serviceProvider = serviceCollection.BuildServiceProvider();

        var mongoDbOptions = serviceProvider.GetRequiredService<IOptions<MongoDbOptions>>();
        var hangfireOptions = serviceProvider.GetRequiredService<IOptions<HangfireOptions>>();
        
        GlobalConfiguration.Configuration
            .UseMongoStorage(mongoDbOptions.Value.ConnectionString, hangfireOptions.Value.DatabaseName);

        serviceCollection.AddHangfireServer();

        
        return serviceCollection;
    }
    
    private static IServiceCollection DefineSchedulers(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProcessMonitorScheduler, ProcessMonitorScheduler>();
        
        return serviceCollection;
    }

    
}
