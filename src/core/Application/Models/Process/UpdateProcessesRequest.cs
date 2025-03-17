namespace Vordr.Application.Models.Process;

public record UpdateProcessesRequest(
    List<CreateProcessDataRequest> CreateProcesses,
    List<UpdateProcessDataRequest> UpdateProcesses
    );
