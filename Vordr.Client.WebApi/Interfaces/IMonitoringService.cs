namespace Vordr.Client.WebApi.Interfaces;

public interface IMonitoringService
{
    public Task PerformHardwareComponentMonitoring();
    public Task PerformHardwareDataMonitoring();
    public Task PerformProcessesMonitoring();


}
