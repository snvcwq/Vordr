using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Infrastructure.Migrations.Configuration;

namespace Vordr.Infrastructure.Extensions;

public static class WebApplicationExtensions
{
    public static async Task<WebApplication> ExecuteMigrations(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var mongoMigrationPerformer = scope.ServiceProvider.GetRequiredService<MongoMigrationPerformer>();
        await mongoMigrationPerformer.PerformMigrationsAsync();
        
        return app;
    }
}
