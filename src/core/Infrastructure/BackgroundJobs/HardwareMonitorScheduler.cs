using System.Linq.Expressions;
using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.BackgroundJobs;

public class HardwareMonitorScheduler(
    IRecurringJobManager recurringJobManager,
    IHardwareMetricsCollectService service,
    IMonitoringConfigurationRepository monitoringConfigurationRepository,
    ILogger<HardwareMonitorScheduler> logger
) : IHardwareMonitorScheduler
{
    public async Task ScheduleCollecting(string? cronExpression = null)
    {
        var monitoringConfigurationResult =
            await monitoringConfigurationRepository.RetrieveMonitoringConfigurationAsync();
        var monitoringConfiguration = monitoringConfigurationResult.Match(
            suc =>
            {
                logger.LogDebug(
                    "Monitoring configuration was successfully retrieved for scheduling hardware monitoring ");
                return suc;
            },
            errors =>
            {
                logger.LogError(
                    "Error occured when retrieving monitoring configuration for scheduling hardware monitoring. Errors:{errors} .",
                    errors.Print());
                return (MonitoringConfiguration?)null;
            });

        if (monitoringConfiguration is null)
        {
            logger.LogWarning("Monitoring configuration was not retrieved. hardware monitoring will not be performed.");
            return;
        }

        cronExpression = !cronExpression.IsNullOrWhiteSpace()
            ? cronExpression
            : monitoringConfiguration.ScanFrequency;


        Expression<Action> action = () => service.CollectHardwareAsync(CancellationToken.None);
        recurringJobManager.AddOrUpdate(nameof(service.CollectHardwareAsync), action, cronExpression);    }

    public void DisableCollecting()
    {
        recurringJobManager.RemoveIfExists(nameof(service.CollectHardwareAsync));
    }

    public async Task ConfigureCollecting()
    {
        var monitoringConfigurationResult =
            await monitoringConfigurationRepository.RetrieveMonitoringConfigurationAsync();
        var monitoringConfiguration = monitoringConfigurationResult.Match(
            suc =>
            {
                logger.LogDebug(
                    "Monitoring configuration was successfully retrieved for configuring hardware monitoring ");
                return suc;
            },
            errors =>
            {
                logger.LogError(
                    "Error occured when retrieving monitoring configuration for configuring hardware monitoring. Errors:{errors} .",
                    errors.Print());
                return (MonitoringConfiguration?)null;
            });

        if (monitoringConfiguration is null)
        {
            logger.LogWarning(
                "Monitoring configuration was not retrieved. cpu load monitoring configuration will not be performed.");
            return;
        }

        await ScheduleCollecting();
        }
}
