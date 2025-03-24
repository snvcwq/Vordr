using Hangfire;
using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Application.Models.Process;
using Vordr.Application.Process.Commands.Upload;

namespace Vordr.Application.Services;

public class ProcessCollectService(IProcessDataCollector processDataCollector, IMediator mediator) : IProcessCollectService
{
    
    public async Task<List<ProcessInformation>> ExecuteProcessDataCollectingAsync()
    {
        var collectedProcesses = await processDataCollector.GetCurrentProcesses();
        await mediator.Send(new UploadCollectedProcessesCommand(collectedProcesses));
        return collectedProcesses.ToList();
    }
}
