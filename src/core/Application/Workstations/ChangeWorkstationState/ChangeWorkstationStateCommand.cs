using Vordr.Domain.Enums;

namespace Vordr.Application.Workstations.ChangeWorkstationState;

public record ChangeWorkstationStateCommand(string ClientId, WorkstationState State) : IRequest<bool>;
