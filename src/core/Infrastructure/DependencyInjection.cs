using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Infrastructure.Migrations;
using Vordr.Infrastructure.Migrations.Configuration;
using Vordr.Infrastructure.Options;
using Vordr.Infrastructure.Persistence;

namespace Vordr.Infrastructure;

public static class DependencyInjection
{
    public static WebApplicationBuilder AddInfrastructureServices(this WebApplicationBuilder builder)
    {
        builder.Services.Configure<MongoDbOptions>(builder.Configuration.GetSection(nameof(MongoDbOptions)));

        builder.Services.AddSingleton<MongoDbClient>();
        builder.Services.AddSingleton<MongoMigrationPerformer>();

        builder.Services.AddMigrations();
        
        return builder;
    }

    private static IServiceCollection AddMigrations(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<SeedDefaultConfigurationMigration>();
        return serviceCollection;
    }

    
}
