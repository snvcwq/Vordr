using Vordr.Application.Models.Hardware;

namespace Vordr.Application.Common.Interfaces.Services;

public interface IHardwareMetricsCollectService
{
    public Task<HardwareReport?> CollectHardwareAsync(CancellationToken cancellationToken);
}
