using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Mappings.Cpu;

namespace Vordr.Application.CpuUsage.Commands.Upload;

public class UploadCpuLoadCommandHandler(
    ICpuLoadRepository repository,
    ILogger<UploadCpuLoadCommand> logger) : IRequestHandler<UploadCpuLoadCommand>
{
    public async Task Handle(UploadCpuLoadCommand request, CancellationToken cancellationToken)
    {
        var result = await repository.UploadAsync(request.ToCpuLoad());
        result.Switch(
            _ => logger.LogDebug("Ram usage was successfully uploaded"),
            errors => logger.LogError("Error occurred when uploading cpu load. Errors: {errors}.", errors.Print()));
    }
}
