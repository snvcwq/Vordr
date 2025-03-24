using Vordr.Application.Models.Process;

namespace Vordr.Application.Common.Interfaces.Services;

public interface IProcessCollectService
{
    public Task<List<ProcessInformation>> ExecuteProcessDataCollectingAsync();
}
