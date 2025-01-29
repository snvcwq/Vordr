using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Application.Process.Commands;

namespace Vordr.Application.Services;

public class ProcessSyncService(IProcessDataCollector processDataCollector, IMediator mediator) : IProcessSyncService
{
    public async Task ExecuteProcessSynchronizationAsync()
    {
        var collectedProcesses = await processDataCollector.GetCurrentProcesses();
        await mediator.Send(new UploadCollectedProcessesCommand(collectedProcesses));
    }
}
