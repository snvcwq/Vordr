using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Mappings.HardwareMetrics;

namespace Vordr.Application.Hardware.Commands.UploadHardwareMetrics;

public class UploadHardwareMetricsCommandHandler(
    ICpuLoadRepository cpuRepository,
    IGpuLoadRepository gpuRepository,
    IRamUsagesRepository ramRepository,
    IPowerSupplyRepository powerSupplyRepository,
    INetworkRepository networkRepository,
    IDriveInfoRepository driveRepository
    ) : IRequestHandler<UploadHardwareMetricsCommand>
{
    public async Task Handle(UploadHardwareMetricsCommand request, CancellationToken cancellationToken)
    {
        if(request.HardwareReport is null)
            return;
        var report = request.HardwareReport;
        var tasks = new List<Task>();

        if (report.Cpu is not null)
            tasks.Add(cpuRepository.UploadAsync(report.Cpu.ToCpuLoad(request.clientId)));

        if (report.Ram is not null)
            tasks.Add(ramRepository.UploadAsync(report.Ram.ToRamUsage(request.clientId)));

        if (report.Drives.Count != 0)
            tasks.AddRange(report.Drives.Select(driveReport => driveRepository.UploadAsync(driveReport.ToDriveInformation(request.clientId))).Cast<Task>());

        if (report.Gpu is not null)
            tasks.Add(gpuRepository.UploadAsync(report.Gpu.ToGpuLoad(request.clientId)));

        if (report.Battery is not null)
            tasks.Add(powerSupplyRepository.UploadAsync(report.Battery.ToPowerSupply(request.clientId)));

        if (report.Networks.Count != 0)
            tasks.AddRange(report.Networks.Select(networkReport => networkRepository.UploadAsync(networkReport.ToNetworkInformation(request.clientId))));

        await Task.WhenAll(tasks);
    }

}
