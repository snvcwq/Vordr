using Hangfire;
using Vordr.Application.Common.Interfaces.BackgroundJobs;

namespace Vordr.Infrastructure.BackgroundJobs;

public class ProcessMonitorScheduler(IBackgroundJobClient backgroundJobClient) : IProcessMonitorScheduler
{

    public void ScheduleProcessMonitorJob()
    {
        backgroundJobClient.Reschedule("", TimeSpan.FromHours(1));
        throw new NotImplementedException();
    }

    public void RescheduleProcessMonitorJob()
    {
        throw new NotImplementedException();
    }

    public void DisableProcessMonitorJob()
    {
        throw new NotImplementedException();
    }
}
