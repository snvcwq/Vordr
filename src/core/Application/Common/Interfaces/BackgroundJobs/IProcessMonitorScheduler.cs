namespace Vordr.Application.Common.Interfaces.BackgroundJobs;

public interface IProcessMonitorScheduler
{
    public void ScheduleProcessMonitoring(string cronExpression);
    
    public void DisableProcessMonitoring();
}
