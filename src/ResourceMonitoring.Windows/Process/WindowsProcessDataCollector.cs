using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Common.Models;

namespace Vordr.ResourceMonitoring.MacOs.Process;

public class WindowsProcessDataCollector: IProcessDataCollector
{
    public Task<IEnumerable<ProcessInformation>> GetCurrentProcesses()
    {
        throw new NotImplementedException();
    }
}
