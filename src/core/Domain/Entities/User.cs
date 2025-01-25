using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities;

public record User : BaseEntity
{
    public required string Name { get; set; }
    
    public required int Age { get; set; }
}
