using Vordr.Domain.Common;

namespace Vordr.Domain.Entities;

public record ProcessData : BaseEntity
{
    public required int Pid { get; set; }
    
    public required string Name { get; set; }

    public required DateTime StartTime { get; set; }
    
    public byte[]? Icon { get; set; }
    
    public required string Path { get; set; }
    
    public required int Priority { get; set; }

    public required string Manufacturer { get; set; }

    public required string Version { get; set; }

    public required string Architecture { get; set; }

    public required string User { get; set; }

};
