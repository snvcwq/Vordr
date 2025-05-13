using Vordr.Domain.Entities;

namespace Vordr.Application.Workstations.GetWorkstationById;

public record GetWorkstationByIdCommand(string ClientId) : IRequest<Workstation?>;
