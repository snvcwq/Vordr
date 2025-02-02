using System.Linq.Expressions;
using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Interfaces.Services;

namespace Vordr.Infrastructure.BackgroundJobs;

public class ProcessMonitorScheduler(
    IRecurringJobManager recurringJobManager, 
    IProcessSyncService service,
    IMonitoringConfigurationRepository monitoringConfigurationRepository,
    ILogger<ProcessMonitorScheduler> logger
    ): IProcessMonitorScheduler
{
    public async Task ScheduleProcessMonitoring()
    {
        var monitoringConfiguration = await monitoringConfigurationRepository.RetrieveMonitoringConfigurationAsync();
        monitoringConfiguration.Switch(
            suc => ScheduleProcessMonitoring(suc.ProcessMonitoringConfig.ScanFrequency),
            errors => logger.LogError("Error occured when retrieving monitoring configuration for scheduling process monitoring. Errors:{errors} .", errors.Print()));
    }
    
    public void ScheduleProcessMonitoring(string cronExpression)
    {
        if (cronExpression.IsNullOrWhiteSpace())
        {
            logger.LogWarning("Cron expression is not provided. process monitoring will not be performed.");
            return;
        }
        
        Expression<Action> action = () => service.ExecuteProcessSynchronizationAsync();
        recurringJobManager.AddOrUpdate(nameof(service.ExecuteProcessSynchronizationAsync), action, cronExpression);
    }

    public void DisableProcessMonitoring() =>
        recurringJobManager.RemoveIfExists(nameof(service.ExecuteProcessSynchronizationAsync));
}
