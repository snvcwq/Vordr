namespace Vordr.Application.Common.Interfaces.BackgroundJobs;

public interface IRamUsageMonitoringScheduler
{
    public Task ScheduleCollecting(string? cronExpression = null);

    public void DisableCollecting();
    
    public Task ConfigureCollecting();
}
