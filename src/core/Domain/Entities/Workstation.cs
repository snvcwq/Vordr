using Vordr.Domain.Common;
using Vordr.Domain.Enums;

namespace Vordr.Domain.Entities;

public record Workstation : BaseEntity
{
    public WorkstationState State { get; init; }
    public required string ClientId { get; init; }
    
    public string? Name { get; init; }
    
    public DateTime LastConnected { get; set; }
    
}
