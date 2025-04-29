namespace Vordr.Client.WebApi.Interfaces.BackgroundJobs;

public interface IMonitoringScheduler
{
    public void ScheduleHardwareComponentMonitoring();
    public void ScheduleHardwareDataMonitoring();
    public void ScheduleProcessesMonitoring();
}
