using Hangfire.Mongo;
using Hangfire.Mongo.Migration.Strategies;
using Hangfire.Mongo.Migration.Strategies.Backup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
using Vordr.Application.Common.Interfaces.Persistence;
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
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddOptions(configuration);
        
        services.AddSingleton<MongoDbClient>();
        services.AddSingleton<MongoMigrationPerformer>();

        services.AddMigrations();
        services.RegisterRepositories();
        services.InitHangfire();
        
        services.DefineSchedulers();
        services.DefineResourceCollectors();
        return services;
    }
    
    private static IServiceCollection AddOptions(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.Configure<MongoDbOptions>(configuration.GetSection(nameof(MongoDbOptions)));
        serviceCollection.Configure<HangfireOptions>(configuration.GetSection(nameof(HangfireOptions)));
        return serviceCollection;
    }

    private static IServiceCollection AddMigrations(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<SeedDefaultConfigurationMigration>();
        return serviceCollection;
    }
    
    
    private static IServiceCollection DefineResourceCollectors(this IServiceCollection services)
    {
        //if (OperatingSystem.IsWindows())
        services.AddWindowsResourceCollectors();
        //else
         //   throw new UnsupportedOsPlatformException($"Application runs on unsupported Operating System {Environment.OSVersion}");
         return services;
    }


    private static IServiceCollection RegisterRepositories(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProcessDataRepository, ProcessDataRepository>();
        serviceCollection.AddScoped<IProcessMetricsRepository, ProcessMetricsRepository>();
        serviceCollection.AddScoped<IMonitoringConfigurationRepository, MonitoringConfigurationRepository>();
        serviceCollection.AddScoped<IRamUsagesRepository, RamUsagesRepository>();
        serviceCollection.AddScoped<IDriveInfoRepository, DriveInfoRepository>();
        serviceCollection.AddScoped<IGpuLoadRepository, GpuLoadRepository>();
        serviceCollection.AddScoped<ICpuLoadRepository, CpuLoadRepository>();
        serviceCollection.AddScoped<INetworkRepository, NetworkInfoRepository>();
        serviceCollection.AddScoped<IPowerSupplyRepository, PowerSupplyRepository>();

        
        return serviceCollection;
    }
    
    private static IServiceCollection InitHangfire(this IServiceCollection serviceCollection)
    {
        using var serviceProvider = serviceCollection.BuildServiceProvider();

        
        serviceCollection.AddHangfire((sp, config) =>
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
        serviceCollection.AddHangfireServer();
        GlobalConfiguration.Configuration.UseActivator(new ContainerJobActivator());

        
        return serviceCollection;
    }
    
    private static IServiceCollection DefineSchedulers(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IProcessMonitorScheduler, ProcessMonitorScheduler>();
        serviceCollection.AddScoped<IHardwareMonitorScheduler, HardwareMonitorScheduler>();

        return serviceCollection;
    }

    
}
