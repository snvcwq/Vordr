using Vordr.Domain.Entities;

namespace Vordr.Application.Models.Process;

public record CreateProcessDataRequest(ProcessData Process, ProcessStats Stats);
