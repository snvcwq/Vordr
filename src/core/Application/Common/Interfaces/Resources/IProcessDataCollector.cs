using Vordr.Application.Models.Process;

namespace Vordr.Application.Common.Interfaces.Resources;

public interface IProcessDataCollector
{
    public Task<IEnumerable<ProcessInformation>> GetCurrentProcesses();
    
    
}
