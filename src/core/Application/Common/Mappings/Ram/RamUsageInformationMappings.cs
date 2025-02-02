using Vordr.Application.Models.Ram;
using Vordr.Application.RamUsage.Commands.Upload;

namespace Vordr.Application.Common.Mappings.Ram;

public static class RamUsageInformationMappings
{
    public static UploadCollectedRamUsageCommand ToUploadCollectedRamUsageCommand(this RamUsageInformation information) =>
        new()
        {
            TotalMemory = information.TotalMemory, 
            UsedMemory = information.UsedMemory, 
            CapturedAtUtc = information.CapturedAtUtc
        };
}
