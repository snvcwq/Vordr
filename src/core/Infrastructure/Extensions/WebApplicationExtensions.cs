using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
using Vordr.Application.Common.Interfaces.Resources;
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
    
    public static async Task<WebApplication> ScheduleMonitoring(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var processMonitorScheduler = scope.ServiceProvider.GetRequiredService<IProcessMonitorScheduler>();
        var ramUsageMonitorScheduler = scope.ServiceProvider.GetRequiredService<IRamUsageMonitoringScheduler>();
        var cpuLoadMonitoringScheduler = scope.ServiceProvider.GetRequiredService<ICpuLoadMonitoringScheduler>();

        
        await processMonitorScheduler.ConfigureMonitoring();
        await ramUsageMonitorScheduler.ConfigureCollecting();
        await cpuLoadMonitoringScheduler.ConfigureCollecting();
        return app;
    }
}
