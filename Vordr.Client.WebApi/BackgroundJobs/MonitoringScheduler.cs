using Hangfire;
using Microsoft.Extensions.Options;
using System.Linq.Expressions;
using Vordr.Client.WebApi.Interfaces;
using Vordr.Client.WebApi.Interfaces.BackgroundJobs;
using Vordr.Client.WebApi.Options;

namespace Vordr.Client.WebApi.BackgroundJobs;

public class MonitoringScheduler(IMonitoringService monitoringService, IRecurringJobManager recurringJobManager, IOptions<MonitoringOptions> monitoringOptions) : IMonitoringScheduler
{
    
    public void ScheduleHardwareComponentMonitoring()
    {
        var opt = monitoringOptions.Value.HardwareComponentsFrequencyCronExpression;
        Expression<Action> action = () => monitoringService.PerformHardwareComponentMonitoring();
        recurringJobManager.AddOrUpdate(nameof(monitoringService.PerformHardwareComponentMonitoring), action, opt);
    }
    public void ScheduleHardwareDataMonitoring()
    {
        var opt = monitoringOptions.Value.HardwareDataFrequencyCronExpression;
        Expression<Action> action = () => monitoringService.PerformHardwareDataMonitoring();
        recurringJobManager.AddOrUpdate(nameof(monitoringService.PerformHardwareDataMonitoring), action, opt);
    }
    public void ScheduleProcessesMonitoring()
    {
        var opt = monitoringOptions.Value.HardwareProcessFrequencyCronExpression;
        Expression<Action> action = () => monitoringService.PerformProcessesMonitoring();
        recurringJobManager.AddOrUpdate(nameof(monitoringService.PerformProcessesMonitoring), action, opt);
        
    }
}
