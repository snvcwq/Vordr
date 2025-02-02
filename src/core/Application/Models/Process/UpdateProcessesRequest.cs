namespace Vordr.Application.Models.Process;

public record UpdateProcessesRequest(
    UpdateProcessesDataRequest UpdateProcessesDataRequest,
    UpdateProcessesMetricsRequest UpdateProcessesMetricsRequest);
