using Vordr.Domain.Common;

namespace Vordr.Domain.Entities;

public record Alert: BaseEntity
{
    public Enums.AlertType Type { get; init; }
    
    public string? Value { get; set; }
    
    public bool Enabled { get; set; }
}
