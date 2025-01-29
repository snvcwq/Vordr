using Vordr.Application.Common.Models.Process;

namespace Vordr.Application.Process.Commands;

public record UploadCollectedProcessesCommand(IEnumerable<ProcessInformation> ProcessList) : IRequest;
