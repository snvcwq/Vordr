using Vordr.Domain.Entities;

namespace Vordr.Application.HardwareComponent.Queries.RetrieveAsync;

public class RetrieveHardwareComponentQueryAsync: IRequest<HardwareComponents>
{
    public string? ClientId { get; set; }
}
