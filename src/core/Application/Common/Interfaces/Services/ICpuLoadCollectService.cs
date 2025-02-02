namespace Vordr.Application.Common.Interfaces.Services;

public interface ICpuLoadCollectService
{
    public Task CollectCpuLoadAsync(CancellationToken cancellationToken);
}
