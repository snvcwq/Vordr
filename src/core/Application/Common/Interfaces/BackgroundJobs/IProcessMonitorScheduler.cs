namespace Vordr.Application.Common.Interfaces.BackgroundJobs;

public interface IProcessMonitorScheduler
{
    public Task ScheduleMonitoring(string? cronExpression = null);

    public void DisableMonitoring();
    
    public Task ConfigureMonitoring();

}
