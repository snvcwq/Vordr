namespace Vordr.Application.Common.Interfaces.BackgroundJobs;

public interface ICpuLoadMonitoringScheduler
{
    public Task ScheduleCollecting(string? cronExpression = null);

    public void DisableCollecting();
    
    public Task ConfigureCollecting();
}
