namespace Vordr.Application.Common.Interfaces.BackgroundJobs;

public interface IProcessMonitorScheduler
{
    public Task ScheduleProcessMonitoring();
    public void ScheduleProcessMonitoring(string cronExpression);

    public void DisableProcessMonitoring();
}
