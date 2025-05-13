using Vordr.Application.Common.Interfaces;
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
    ISender sender,
    IPushNotifiction pushNotifiction
    ) : IRequestHandler<UploadHardwareMetricsCommand>
{
    public async Task Handle(UploadHardwareMetricsCommand request, CancellationToken cancellationToken)
    {
        DashboardInformation.UpdateData(request.HardwareReport, request.clientId);
        if (request.HardwareReport is null)
            return;

        var gpuIsMore = await alertRepository.GetByTypeAsync(AlertType.GpuIsMoreThan);
        var gpuTempIsMore = await alertRepository.GetByTypeAsync(AlertType.GpuTempIsMoreThan);
        var cpuIsMore = await alertRepository.GetByTypeAsync(AlertType.CpuIsMoreThan);
        var cpuTempIsMore = await alertRepository.GetByTypeAsync(AlertType.CpuTempIsMoreThan);
        var ramIsMore = await alertRepository.GetByTypeAsync(AlertType.RamIsMoreThan);
        var drivesIsMore = await alertRepository.GetByTypeAsync(AlertType.DriveIsMoreThan);
        var batteryLevelIsMore = await alertRepository.GetByTypeAsync(AlertType.BatteryLevelIsLessThan);
        var batteryDegradationLevelIsMore = await alertRepository.GetByTypeAsync(AlertType.BatteryDegradationLevelIsLessThan);

        if (gpuIsMore.Enabled && request.HardwareReport.Gpu != null)
        {
            if (int.TryParse(gpuIsMore.Value, out var threshold))
            {
                var current = request.HardwareReport.Gpu.AvgLoad;
                if (current >= threshold)
                {
                    string message = $"We noticed that GPU usage for {request.clientId} is {current}%, which is above the defined alert threshold of {threshold}%. Please investigate the cause.";
                    await sender.Send(new SendNotificationCommand(message, AlertType.GpuIsMoreThan), cancellationToken);
                    pushNotifiction.Send(message);
                }
            }
        }

        if (gpuTempIsMore.Enabled && request.HardwareReport.Gpu != null)
        {
            if (int.TryParse(gpuTempIsMore.Value, out var threshold))
            {
                var current = request.HardwareReport.Gpu.Temperature;
                if (current >= threshold)
                {
                    string message = $"We noticed that GPU temperature for {request.clientId} is {current}°C, which exceeds the defined threshold of {threshold}°C. Please check your cooling system.";
                    await sender.Send(new SendNotificationCommand(message, AlertType.GpuTempIsMoreThan), cancellationToken);
                    pushNotifiction.Send(message);

                }
            }
        }

        if (cpuIsMore.Enabled && request.HardwareReport.Cpu != null)
        {
            if (int.TryParse(cpuIsMore.Value, out var threshold))
            {
                var current = request.HardwareReport.Cpu.AvgUsage;
                if (current >= threshold)
                {
                    string message = $"CPU usage is currently {current}% for {request.clientId}, exceeding the defined threshold of {threshold}%. Investigate potential performance issues.";
                    await sender.Send(new SendNotificationCommand(message, AlertType.CpuIsMoreThan), cancellationToken);
                    pushNotifiction.Send(message);

                }
            }
        }

        if (cpuTempIsMore.Enabled && request.HardwareReport.Cpu != null)
        {
            if (int.TryParse(cpuTempIsMore.Value, out var threshold))
            {
                var current = request.HardwareReport.Cpu.Temperature;
                if (current >= threshold)
                {
                    string message = $"CPU temperature has reached {current}°C for {request.clientId}, which is above the alert limit of {threshold}°C. Please ensure adequate cooling.";
                    await sender.Send(new SendNotificationCommand(message, AlertType.CpuTempIsMoreThan), cancellationToken);
                    pushNotifiction.Send(message);

                }
            }
        }

        if (ramIsMore.Enabled && request.HardwareReport.Ram != null)
        {
            if (int.TryParse(ramIsMore.Value, out var threshold))
            {
                var current = request.HardwareReport.Ram.UsedMemory;
                if (current >= threshold)
                {
                    string message = $"Memory usage is {current} MB for {request.clientId}, exceeding the defined threshold of {threshold} MB. Consider checking for memory-intensive processes.";
                    await sender.Send(new SendNotificationCommand(message, AlertType.RamIsMoreThan), cancellationToken);
                    pushNotifiction.Send(message);

                }
            }
        }

        if (drivesIsMore.Enabled && request.HardwareReport.Drives != null)
        {
            if (int.TryParse(drivesIsMore.Value, out var threshold))
            {
                foreach (var drive in request.HardwareReport.Drives)
                {
                    var used = drive.DriveTotalSize - drive.DriveFreeSpace;
                    if (used >= threshold)
                    {
                        string message = $"Disk usage on drive {drive.DriveName} is {used} MB for {request.clientId}, exceeding the alert threshold of {threshold} MB. Free up some space if possible.";
                        await sender.Send(new SendNotificationCommand(message, AlertType.DriveIsMoreThan), cancellationToken);
                        pushNotifiction.Send(message);
                        break;
                    }
                }
            }
        }

        if (batteryLevelIsMore.Enabled && request.HardwareReport.Battery != null)
        {
            if (int.TryParse(batteryLevelIsMore.Value, out var threshold))
            {
                var current = request.HardwareReport.Battery.ChargeLevel;
                if (current <= threshold)
                {
                    string message = $"Battery level is low: {current}% for {request.clientId}. This is below the alert threshold of {threshold}%. Please connect to a power source.";
                    await sender.Send(new SendNotificationCommand(message, AlertType.BatteryLevelIsLessThan), cancellationToken);
                    pushNotifiction.Send(message);

                }
            }
        }

        if (batteryDegradationLevelIsMore.Enabled && request.HardwareReport.Battery != null)
        {
            if (int.TryParse(batteryDegradationLevelIsMore.Value, out var threshold))
            {
                var current = request.HardwareReport.Battery.DegradationLevel;
                if (current >= threshold)
                {
                    string message = $"Battery degradation level is {current}% for {request.clientId}, exceeding the threshold of {threshold}%. Battery health may be compromised.";
                    await sender.Send(new SendNotificationCommand(message, AlertType.BatteryDegradationLevelIsLessThan), cancellationToken);
                    pushNotifiction.Send(message);

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
