namespace Vordr.Application.Common.Interfaces.BackgroundJobs;

public interface IHardwareMonitorScheduler
{
    public Task ScheduleCollecting(string? cronExpression = null);

    public void DisableCollecting();
    
    public Task ConfigureCollecting();
}
