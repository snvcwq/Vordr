using Vordr.Domain.Common;

namespace Vordr.Domain.Entities;

public record User : BaseEntity
{
    public required string Name { get; set; }
    
    public required int Age { get; set; }
}
