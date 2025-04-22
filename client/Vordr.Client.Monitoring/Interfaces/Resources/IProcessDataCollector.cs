using Vordr.Common.Messaging.Messages.Process;

namespace Vordr.Client.Monitoring.Interfaces.Resources;

public interface IProcessDataCollector
{
    public Task<IEnumerable<ProcessInfo>> GetCurrentProcesses();
    
    
}
