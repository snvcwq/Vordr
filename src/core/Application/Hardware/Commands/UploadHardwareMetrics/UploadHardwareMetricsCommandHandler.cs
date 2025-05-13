using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Mappings.HardwareMetrics;
using Vordr.Application.Notfication.SendNotfication;
using Vordr.Application.StaticData;
using Vordr.Domain.Enums;

namespace Vordr.Application.Hardware.Commands.UploadHardwareMetrics;

public class UploadHardwareMetricsCommandHandler(
    ICpuLoadRepository cpuRepository,
    IGpuLoadRepository gpuRepository,
    IRamUsagesRepository ramRepository,
    IPowerSupplyRepository powerSupplyRepository,
    INetworkRepository networkRepository,
    IDriveInfoRepository driveRepository,
    IAlertRepository alertRepository,
    ISender sender
    ) : IRequestHandler<UploadHardwareMetricsCommand>
{
    public async Task Handle(UploadHardwareMetricsCommand request, CancellationToken cancellationToken)
    {
        DashboardInformation.UpdateData(request.HardwareReport, request.clientId);
        if(request.HardwareReport is null)
            return;

        var gpuIsMore = await alertRepository.GetByTypeAsync(AlertType.GpuIsMoreThan);
        var gpuTempIsMore = await alertRepository.GetByTypeAsync(AlertType.GpuTempIsMoreThan);
        var cpuIsMore = await alertRepository.GetByTypeAsync(AlertType.CpuIsMoreThan);
        var cpuTempIsMore = await alertRepository.GetByTypeAsync(AlertType.CpuTempIsMoreThan);
        var ramIsMore = await alertRepository.GetByTypeAsync(AlertType.RamIsMoreThan);
        var drivesIsMore = await alertRepository.GetByTypeAsync(AlertType.DriveIsMoreThan);
        var batteryLevelIsMore = await alertRepository.GetByTypeAsync(AlertType.BatteryLevelIsLessThan);
        var batteryDegradationLevelIsMore = await alertRepository.GetByTypeAsync(AlertType.BatteryDegradationLevelIsLessThan);

        if (gpuIsMore.Enabled)
        {
            if (request.HardwareReport.Gpu != null)
            {
                if (request.HardwareReport.Gpu.AvgLoad >= Convert.ToInt32(gpuIsMore.Value))
                {
                    await sender.Send(new SendNotificationCommand("Gpu"), cancellationToken);
                }
            }
        }
        if (gpuTempIsMore.Enabled)
        {
            if (request.HardwareReport.Gpu != null)
            {
                if (request.HardwareReport.Gpu.Temperature >= Convert.ToInt32(gpuTempIsMore.Value))
                {
                    await sender.Send(new SendNotificationCommand("Gpu Temp"), cancellationToken);
                }
            }
        }
        if (cpuIsMore.Enabled)
        {
            if (request.HardwareReport.Cpu != null)
            {
                if (request.HardwareReport.Cpu.AvgUsage >= Convert.ToInt32(cpuIsMore.Value))
                {
                    await sender.Send(new SendNotificationCommand("Cpu"), cancellationToken);
                }
            }
        }
        if (cpuTempIsMore.Enabled)
        {
            if (request.HardwareReport.Cpu != null)
            {
                if (request.HardwareReport.Cpu.Temperature >= Convert.ToInt32(cpuTempIsMore.Value))
                {
                    await sender.Send(new SendNotificationCommand("Cpu Temp"), cancellationToken);
                }
            }
        }
        if (ramIsMore.Enabled)
        {
            if (request.HardwareReport.Ram != null)
            {
                if (request.HardwareReport.Ram.UsedMemory >= Convert.ToInt32(ramIsMore.Value))
                {
                    await sender.Send(new SendNotificationCommand("Ram "), cancellationToken);
                }
            }
        }
        if (drivesIsMore.Enabled)
        {
            if (request.HardwareReport.Drives != null)
            {
                if (request.HardwareReport.Drives.Any(d => d.DriveTotalSize - d.DriveFreeSpace >= Convert.ToInt32(drivesIsMore.Value)))
                {
                    await sender.Send(new SendNotificationCommand("Gpu"), cancellationToken);
                }
            }
        }
        if (batteryLevelIsMore.Enabled)
        {
            if (request.HardwareReport.Battery != null)
            {
                if (request.HardwareReport.Battery.ChargeLevel <= Convert.ToInt32(batteryLevelIsMore.Value))
                {
                    await sender.Send(new SendNotificationCommand("Gpu"), cancellationToken);
                }
            }
        }
        if (batteryDegradationLevelIsMore.Enabled)
        {
            if (request.HardwareReport.Battery != null)
            {
                if (request.HardwareReport.Battery.DegradationLevel >= Convert.ToInt32(batteryDegradationLevelIsMore.Value))
                {
                    await sender.Send(new SendNotificationCommand("Gpu"), cancellationToken);
                }
            }
        }
        
        var report = request.HardwareReport;
        var tasks = new List<Task>();

        if (report.Cpu is not null)
            tasks.Add(cpuRepository.UploadAsync(report.Cpu.ToCpuLoad(request.clientId)));

        if (report.Ram is not null)
            tasks.Add(ramRepository.UploadAsync(report.Ram.ToRamUsage(request.clientId)));

        if (report.Drives != null && report.Drives.Count != 0)
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
