using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
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
    
    public static async Task<IHost> ScheduleMonitoring(this IHost app)
    {
        using var scope = app.Services.CreateScope();
        var processMonitorScheduler = scope.ServiceProvider.GetRequiredService<IProcessMonitorScheduler>();
        var cpuLoadMonitoringScheduler = scope.ServiceProvider.GetRequiredService<IHardwareMonitorScheduler>();

        
        await processMonitorScheduler.ConfigureMonitoring();
        await cpuLoadMonitoringScheduler.ConfigureCollecting();
        return app;
    }
}
