using Vordr.Domain.Entities;

namespace Vordr.Application.Workstations.GetWorkstation;

public record GetWorkstationCommand() : IRequest<IEnumerable<Workstation>>;
