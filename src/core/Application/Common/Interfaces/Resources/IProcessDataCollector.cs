using Vordr.Application.Common.Models;
using Vordr.Application.Common.Models.Process;

namespace Vordr.Application.Common.Interfaces.Resources;

public interface IProcessDataCollector
{
    public Task<IEnumerable<ProcessInformation>> GetCurrentProcesses();
    
    
}
