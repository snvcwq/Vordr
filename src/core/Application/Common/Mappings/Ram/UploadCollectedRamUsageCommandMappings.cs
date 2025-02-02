using Vordr.Application.RamUsage.Commands.Upload;

namespace Vordr.Application.Common.Mappings.Ram;

public static class UploadCollectedRamUsageCommandMappings
{
    public static Domain.Entities.RamUsage ToRamUsage(this UploadCollectedRamUsageCommand command) =>
        new()
        {
            TotalMemory = command.TotalMemory, 
            UsedMemory = command.UsedMemory, 
            CapturedAtUtc = command.CapturedAtUtc
        };
}
