using Vordr.Application.CpuUsage.Commands.Upload;
using Vordr.Application.Models.Cpu;

namespace Vordr.Application.Common.Mappings.Cpu;

public static class CpuUsageInformationMappings
{
    public static UploadCpuLoadCommand ToUploadCollectedCpuUsageCommand(this CpuLoadInformation information) =>
        new()
        {
            LoadPercents = information.LoadPercents, 
            Temperature = information.Temperature,
            Voltage = information.Voltage,
            CapturedAtUtc = information.CapturedAtUtc
        };
}
