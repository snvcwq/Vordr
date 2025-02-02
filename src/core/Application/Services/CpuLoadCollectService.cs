using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Application.Common.Mappings.Cpu;

namespace Vordr.Application.Services;

public class CpuLoadCollectService(ICpuUsageCollector collector, IMediator mediator) : ICpuLoadCollectService
{
    public async Task CollectCpuLoadAsync(CancellationToken cancellationToken)
    {
        var information = collector.Collect();
        await mediator.Send(information.ToUploadCollectedCpuUsageCommand(), cancellationToken);
    }
}
