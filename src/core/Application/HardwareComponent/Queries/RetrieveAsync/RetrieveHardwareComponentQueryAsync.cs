using Vordr.Domain.Entities;

namespace Vordr.Application.HardwareComponent.Queries.RetrieveAsync;

public class RetrieveHardwareComponentQuery: IRequest<HardwareComponents>
{
    public required string ClientId { get; init; }

}
