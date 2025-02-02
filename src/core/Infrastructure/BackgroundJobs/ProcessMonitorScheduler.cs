using System.Linq.Expressions;
using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Vordr.Infrastructure.BackgroundJobs;

public class ProcessMonitorScheduler(
    IRecurringJobManager recurringJobManager, 
    IProcessCollectService service,
    IMonitoringConfigurationRepository monitoringConfigurationRepository,
    ILogger<ProcessMonitorScheduler> logger
    ): IProcessMonitorScheduler
{
    public async Task ScheduleMonitoring(string? cronExpression = null)
    {
        var monitoringConfigurationResult = await monitoringConfigurationRepository.RetrieveMonitoringConfigurationAsync();
        var monitoringConfiguration = monitoringConfigurationResult.Match(
            suc =>
            {
                logger.LogDebug("Monitoring configuration was successfully retrieved for scheduling process monitoring ");
                return suc;
            },
            errors =>
            {
                logger.LogError("Error occured when retrieving monitoring configuration for scheduling process monitoring. Errors:{errors} .", errors.Print());
                return (MonitoringConfiguration?)null;
            });
        
        if (monitoringConfiguration is null)
        {
            logger.LogWarning("Monitoring configuration was not retrieved. process monitoring will not be performed.");
            return;
        }

        cronExpression = !cronExpression.IsNullOrWhiteSpace()
            ? cronExpression
            : monitoringConfiguration.ProcessMonitoringConfig.ScanFrequency; 
        
        
        if (monitoringConfiguration.ProcessMonitoringConfig.MonitoringStatus is MonitoringStatus.Disabled)
        {
            logger.LogWarning("Process monitoring status is disabled. Monitoring will not be performed.");
            return;
        }
        
        Expression<Action> action = () => service.ExecuteProcessDataCollectingAsync();
        recurringJobManager.AddOrUpdate(nameof(service.ExecuteProcessDataCollectingAsync), action, cronExpression);
    }

    public void DisableMonitoring()
    {
        recurringJobManager.RemoveIfExists(nameof(service.ExecuteProcessDataCollectingAsync));
    }

    public async Task ConfigureMonitoring()
    {

        var monitoringConfigurationResult = await monitoringConfigurationRepository.RetrieveMonitoringConfigurationAsync();
        var monitoringConfiguration = monitoringConfigurationResult.Match(
            suc =>
            {
                logger.LogDebug("Monitoring configuration was successfully retrieved for configuring process monitoring ");
                return suc;
            },
            errors =>
            {
                logger.LogError("Error occured when retrieving monitoring configuration for configuring process monitoring. Errors:{errors} .", errors.Print());
                return (MonitoringConfiguration?)null;
            });
        
        if (monitoringConfiguration is null)
        {
            logger.LogWarning("Monitoring configuration was not retrieved. process monitoring configuration will not be performed.");
            return;
        }

        switch (monitoringConfiguration.ProcessMonitoringConfig.MonitoringStatus)
        {
            case MonitoringStatus.Enabled:
                await ScheduleMonitoring();
                break;
            case MonitoringStatus.Disabled:
                DisableMonitoring();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
    }
}
