using Vordr.Application.CpuUsage.Commands.Upload;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Mappings.Cpu;

public static class UploadCpuLoadCommandMappings
{
    public static CpuLoad ToCpuLoad(this UploadCpuLoadCommand information) =>
        new()
        {
            LoadPercents = information.LoadPercents, 
            Temperature = information.Temperature,
            Voltage = information.Voltage,
            CapturedAtUtc = information.CapturedAtUtc
        };
}
