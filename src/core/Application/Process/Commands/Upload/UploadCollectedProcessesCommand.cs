using Vordr.Application.Models.Process;

namespace Vordr.Application.Process.Commands.Upload;

public record UploadCollectedProcessesCommand(IEnumerable<ProcessInformation> ProcessList) : IRequest;
