using Hangfire.Mongo;
using Hangfire.Mongo.Migration.Strategies;
using Hangfire.Mongo.Migration.Strategies.Backup;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Exceptions;
using Vordr.Infrastructure.BackgroundJobs;
using Vordr.Infrastructure.Migrations;
using Vordr.Infrastructure.Migrations.Configuration;
using Vordr.Infrastructure.Options;
using Vordr.Infrastructure.Persistence;
using Vordr.Infrastructure.Persistence.Repositories;
using Vordr.ResourcesMonitoring.Windows;

namespace Vordr.Infrastructure;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddInfrastructureServices(this WebApplicationBuilder builder)
    {
        builder.AddOptions();
        
        builder.Services.AddSingleton<MongoDbClient>();
        builder.Services.AddSingleton<MongoMigrationPerformer>();

        builder.Services.AddMigrations();
        builder.Services.RegisterRepositories();
        builder.InitHangfire();
        
        builder.Services.DefineSchedulers();
        builder.DefineResourceCollectors();
        return builder;
    }

    private static WebApplicationBuilder AddOptions(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<HangfireOptions>(builder.Configuration.GetSection(nameof(HangfireOptions)));
        builder.Services.Configure<MongoDbOptions>(builder.Configuration.GetSection(nameof(MongoDbOptions)));
        return builder;
    }

    
    private static IServiceCollection AddMigrations(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<SeedDefaultConfigurationMigration>();
        return serviceCollection;
    }
    
    
    private static WebApplicationBuilder DefineResourceCollectors(this WebApplicationBuilder builder)
    {
        if (OperatingSystem.IsWindows())
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
        serviceCollection.AddScoped<IRamUsagesRepository, RamUsagesRepository>();
        serviceCollection.AddScoped<ICpuLoadRepository, CpuLoadRepository>();

        
        return serviceCollection;
    }
    
    private static WebApplicationBuilder InitHangfire(this WebApplicationBuilder builder)
    {
        using var serviceProvider = builder.Services.BuildServiceProvider();

        
        builder.Services.AddHangfire((sp, config) =>
        {
            var migrationOptions = new MongoMigrationOptions
            {
                MigrationStrategy = new MigrateMongoMigrationStrategy(),
                BackupStrategy = new CollectionMongoBackupStrategy()
            };
            var mongoStorageOptions = new MongoStorageOptions { MigrationOptions = migrationOptions, CheckConnection = false };

            var mongoDbOptions = sp.GetRequiredService<IOptions<MongoDbOptions>>().Value;
            var hangfireOptions = sp.GetRequiredService<IOptions<HangfireOptions>>().Value;
            config.UseMongoStorage(mongoDbOptions.ConnectionString, hangfireOptions.DatabaseName, mongoStorageOptions);

        });
        builder.Services.AddHangfireServer();

        
        return builder;
    }
    
    private static IServiceCollection DefineSchedulers(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProcessMonitorScheduler, ProcessMonitorScheduler>();
        serviceCollection.AddScoped<IRamUsageMonitoringScheduler, RamUsageMonitoringScheduler>();
        serviceCollection.AddScoped<ICpuLoadMonitoringScheduler, CpuLoadMonitorScheduler>();

        return serviceCollection;
    }

    
}
