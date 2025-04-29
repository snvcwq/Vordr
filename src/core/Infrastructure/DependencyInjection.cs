using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Infrastructure.Migrations;
using Vordr.Infrastructure.Migrations.Configuration;
using Vordr.Infrastructure.Options;
using Vordr.Infrastructure.Persistence;
using Vordr.Infrastructure.Persistence.Repositories;

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
        serviceCollection.AddSingleton<AddIndexesToBatteryMigration>();
        serviceCollection.AddSingleton<AddInitialHardwareComponents>();
        return serviceCollection;
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
        serviceCollection.AddScoped<IHardwareComponentsRepository, HardwareComponentsRepository>();

        
        return serviceCollection;
    }
    
}
