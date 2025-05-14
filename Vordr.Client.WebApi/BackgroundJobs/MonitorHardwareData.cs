using Vordr.Client.WebApi.Interfaces;

namespace Vordr.Client.WebApi.BackgroundJobs;

public class MonitorHardwareData(IServiceScopeFactory scopeFactory) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await using var scope = scopeFactory.CreateAsyncScope();
            var monitoringService = scope.ServiceProvider.GetRequiredService<IMonitoringService>();
            await monitoringService.PerformHardwareDataMonitoring();
            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
        }
    }
}
