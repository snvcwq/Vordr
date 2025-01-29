using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Models.Process;

public record UpdateProcessesMetricsRequest(IList<ProcessMetrics> NewProcesses);
