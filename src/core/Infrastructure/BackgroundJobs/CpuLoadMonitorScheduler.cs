using System.Linq.Expressions;
using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Vordr.Infrastructure.BackgroundJobs;

public class CpuLoadMonitorScheduler(
    IRecurringJobManager recurringJobManager,
    ICpuLoadCollectService service,
    IMonitoringConfigurationRepository monitoringConfigurationRepository,
    ILogger<CpuLoadMonitorScheduler> logger
) : ICpuLoadMonitoringScheduler
{
    public async Task ScheduleCollecting(string? cronExpression = null)
    {
        var monitoringConfigurationResult =
            await monitoringConfigurationRepository.RetrieveMonitoringConfigurationAsync();
        var monitoringConfiguration = monitoringConfigurationResult.Match(
            suc =>
            {
                logger.LogDebug(
                    "Monitoring configuration was successfully retrieved for scheduling cpu load monitoring ");
                return suc;
            },
            errors =>
            {
                logger.LogError(
                    "Error occured when retrieving monitoring configuration for scheduling cpu load monitoring. Errors:{errors} .",
                    errors.Print());
                return (MonitoringConfiguration?)null;
            });

        if (monitoringConfiguration is null)
        {
            logger.LogWarning("Monitoring configuration was not retrieved. cpu load monitoring will not be performed.");
            return;
        }

        cronExpression = !cronExpression.IsNullOrWhiteSpace()
            ? cronExpression
            : monitoringConfiguration.ScanFrequency;


        if (monitoringConfiguration.MonitorCpu is MonitoringStatus.Disabled)
        {
            logger.LogWarning("Cpu load monitoring status is disabled. Monitoring will not be performed.");
            return;
        }

        Expression<Action> action = () => service.CollectCpuLoadAsync(CancellationToken.None);
        recurringJobManager.AddOrUpdate(nameof(service.CollectCpuLoadAsync), action, cronExpression);    }

    public void DisableCollecting()
    {
        recurringJobManager.RemoveIfExists(nameof(service.CollectCpuLoadAsync));
    }

    public async Task ConfigureCollecting()
    {
        var monitoringConfigurationResult =
            await monitoringConfigurationRepository.RetrieveMonitoringConfigurationAsync();
        var monitoringConfiguration = monitoringConfigurationResult.Match(
            suc =>
            {
                logger.LogDebug(
                    "Monitoring configuration was successfully retrieved for configuring cpu load monitoring ");
                return suc;
            },
            errors =>
            {
                logger.LogError(
                    "Error occured when retrieving monitoring configuration for configuring cpu load monitoring. Errors:{errors} .",
                    errors.Print());
                return (MonitoringConfiguration?)null;
            });

        if (monitoringConfiguration is null)
        {
            logger.LogWarning(
                "Monitoring configuration was not retrieved. cpu load monitoring configuration will not be performed.");
            return;
        }

        switch (monitoringConfiguration.MonitorCpu)
        {
            case MonitoringStatus.Enabled:
                await ScheduleCollecting();
                break;
            case MonitoringStatus.Disabled:
                DisableCollecting();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }    }
}
