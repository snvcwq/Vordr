namespace Vordr.Application.Workstations.DeleteWorkstation;

public record DeleteWorkstationCommand(string ClientId) : IRequest;
