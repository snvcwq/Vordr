using Vordr.Domain.Entities;

namespace Vordr.Application.Models.Process;

public record UpdateProcessDataRequest(ProcessData Process, ProcessStats Stats);
