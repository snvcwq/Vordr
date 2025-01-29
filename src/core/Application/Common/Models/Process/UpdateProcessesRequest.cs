namespace Vordr.Application.Common.Models.Process;

public record UpdateProcessesRequest(
    UpdateProcessesDataRequest UpdateProcessesDataRequest,
    UpdateProcessesMetricsRequest UpdateProcessesMetricsRequest);
