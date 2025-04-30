using Vordr.Application.Models.Process;
using Vordr.Common.Messaging.Messages.Process;

namespace Vordr.Application.Process.Commands.Upload;

public record UploadCollectedProcessesCommand(IEnumerable<ProcessInformation> ProcessList) : IRequest;
