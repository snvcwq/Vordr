using Vordr.Application.Common.Interfaces.Resources;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Application.Common.Mappings.Ram;

namespace Vordr.Application.Services;

public class RamUsageCollectService(IRamUsageCollector collector, IMediator mediator) : IRamUsageCollectService
{
    public async Task CollectRamUsageAsync(CancellationToken cancellationToken)
    {
        var ramUsage = collector.Collect();
        await mediator.Send(ramUsage.ToUploadCollectedRamUsageCommand(), cancellationToken);
    }
}
