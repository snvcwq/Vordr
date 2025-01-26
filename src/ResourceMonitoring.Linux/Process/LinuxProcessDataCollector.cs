using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Common.Models;

namespace Vordr.ResourceMonitoring.Linux.Process;

public class LinuxProcessDataCollector : IProcessDataCollector
{
    public Task<IEnumerable<ProcessInformation>> GetCurrentProcesses()
    {
        throw new NotImplementedException();
    }
}
