namespace Vordr.Application.Common.Interfaces.Services;

public interface IHardwareMetricsCollectService
{
    public Task CollectHardwareAsync(CancellationToken cancellationToken);
}
