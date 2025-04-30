using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Vordr.Infrastructure.Migrations.Configuration;

namespace Vordr.Infrastructure.Extensions;

public static class HostExtensions
{
    public static async Task<IHost> ExecuteMigrations(this IHost app)
    {
        using var scope = app.Services.CreateScope();
        var mongoMigrationPerformer = scope.ServiceProvider.GetRequiredService<MongoMigrationPerformer>();
        await mongoMigrationPerformer.PerformMigrationsAsync();

        return app;
    }
}
