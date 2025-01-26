using Vordr.Application.Common.Models;

namespace Vordr.Application.Common.Interfaces.Resources;

public interface IProcessDataCollector
{
    public Task<IEnumerable<ProcessInformation>> GetCurrentProcesses();
    
    
}
