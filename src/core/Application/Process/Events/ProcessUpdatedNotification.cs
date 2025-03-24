using Vordr.Application.Models.Process;

namespace Vordr.Application.Process.Events;

public class ProcessUpdatedNotification(IEnumerable<ProcessInformation> processList) : INotification
{
    public IEnumerable<ProcessInformation> ProcessList { get; } = processList;

}
