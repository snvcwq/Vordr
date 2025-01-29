using System.Linq.Expressions;
using Vordr.Application.Common.Interfaces.BackgroundJobs;
using Vordr.Application.Common.Interfaces.Services;

namespace Vordr.Infrastructure.BackgroundJobs;

public class ProcessMonitorScheduler(IRecurringJobManager recurringJobManager, IProcessSyncService service) : IProcessMonitorScheduler
{
    public void ScheduleProcessMonitoring(string cronExpression)
    {
        Expression<Action> action = () => service.ExecuteProcessSynchronizationAsync();
        recurringJobManager.AddOrUpdate(nameof(service.ExecuteProcessSynchronizationAsync), action, cronExpression);
    }

    public void DisableProcessMonitoring() =>
        recurringJobManager.RemoveIfExists(nameof(service.ExecuteProcessSynchronizationAsync));
}
