using System.Linq.Expressions;
using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Vordr.Infrastructure.BackgroundJobs;

public class RamUsageMonitoringScheduler(
    IRecurringJobManager recurringJobManager,
    IRamUsageCollectService service,
    IMonitoringConfigurationRepository monitoringConfigurationRepository,
    ILogger<RamUsageMonitoringScheduler> logger
) : IRamUsageMonitoringScheduler
{
    public async Task ScheduleCollecting(string? cronExpression = null)
    {
        var monitoringConfigurationResult =
            await monitoringConfigurationRepository.RetrieveMonitoringConfigurationAsync();
        var monitoringConfiguration = monitoringConfigurationResult.Match(
            suc =>
            {
                logger.LogDebug(
                    "Monitoring configuration was successfully retrieved for scheduling ram usage monitoring ");
                return suc;
            },
            errors =>
            {
                logger.LogError(
                    "Error occured when retrieving monitoring configuration for scheduling ram usage monitoring. Errors:{errors} .",
                    errors.Print());
                return (MonitoringConfiguration?)null;
            });

        if (monitoringConfiguration is null)
        {
            logger.LogWarning("Monitoring configuration was not retrieved. ram usage monitoring will not be performed.");
            return;
        }

        cronExpression = !cronExpression.IsNullOrWhiteSpace()
            ? cronExpression
            : monitoringConfiguration.ScanFrequency;


        if (monitoringConfiguration.MonitorRam is MonitoringStatus.Disabled)
        {
            logger.LogWarning("Ram usage monitoring status is disabled. Monitoring will not be performed.");
            return;
        }

        Expression<Action> action = () => service.CollectRamUsageAsync(CancellationToken.None);
        recurringJobManager.AddOrUpdate(nameof(service.CollectRamUsageAsync), action, cronExpression);
    }

    public void DisableCollecting()
    {
        recurringJobManager.RemoveIfExists(nameof(service.CollectRamUsageAsync));
    }

    public async Task ConfigureCollecting()
    {

        var monitoringConfigurationResult =
            await monitoringConfigurationRepository.RetrieveMonitoringConfigurationAsync();
        var monitoringConfiguration = monitoringConfigurationResult.Match(
            suc =>
            {
                logger.LogDebug(
                    "Monitoring configuration was successfully retrieved for configuring ram usage monitoring ");
                return suc;
            },
            errors =>
            {
                logger.LogError(
                    "Error occured when retrieving monitoring configuration for configuring ram usage monitoring. Errors:{errors} .",
                    errors.Print());
                return (MonitoringConfiguration?)null;
            });

        if (monitoringConfiguration is null)
        {
            logger.LogWarning(
                "Monitoring configuration was not retrieved. ram usage monitoring configuration will not be performed.");
            return;
        }

        switch (monitoringConfiguration.MonitorRam)
        {
            case MonitoringStatus.Enabled:
                await ScheduleCollecting();
                break;
            case MonitoringStatus.Disabled:
                DisableCollecting();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
