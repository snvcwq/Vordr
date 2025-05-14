using Vordr.Client.WebApi.Interfaces;

namespace Vordr.Client.WebApi.BackgroundJobs;

public class MonitorHardwareComponent(IServiceScopeFactory scopeFactory) : BackgroundService
{

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            await using var scope = scopeFactory.CreateAsyncScope();
            var monitoringService = scope.ServiceProvider.GetRequiredService<IMonitoringService>();

            try
            {
                await monitoringService.PerformHardwareComponentMonitoring();

            }
            catch (Exception)
            {
            }
            await Task.Delay(TimeSpan.FromSeconds(10), stoppingToken);
        }
    }
}
