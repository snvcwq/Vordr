using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Mappings.Ram;

namespace Vordr.Application.RamUsage.Commands.Upload;

// ReSharper disable once UnusedType.Global
public class UploadCollectedRamUsageCommandHandler(
    IRamUsagesRepository repository,
    ILogger<UploadCollectedRamUsageCommand> logger)
    : IRequestHandler<UploadCollectedRamUsageCommand>
{
    public async Task Handle(UploadCollectedRamUsageCommand request, CancellationToken cancellationToken)
    {
        var result = await repository.UploadAsync(request.ToRamUsage());
        result.Switch(
            _ => logger.LogDebug("Ram usage was successfully uploaded"),
            errors => logger.LogError("Error occurred when uploading ram usage. Errors: {errors}.", errors.Print()));
    }
}
