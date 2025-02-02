namespace Vordr.Application.Common.Interfaces.Services;

public interface IRamUsageCollectService
{
    public Task CollectRamUsageAsync(CancellationToken cancellationToken);
}
