namespace Vordr.Application.Common.Interfaces.BackgroundJobs;

public interface IProcessMonitorScheduler
{
    public void ScheduleProcessMonitorJob();
    
    public void RescheduleProcessMonitorJob();

    public void DisableProcessMonitorJob();
}
