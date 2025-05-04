using Vordr.Domain.Entities;

namespace Vordr.Application.Workstations.AddWorkstation;

public record AddWorkstationCommand(Workstation Workstation) : IRequest;
