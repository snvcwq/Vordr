using Vordr.Domain.Entities;

namespace Vordr.Application.Models.Process;

public record UpdateProcessesMetricsRequest(IList<ProcessMetrics> NewProcesses);
