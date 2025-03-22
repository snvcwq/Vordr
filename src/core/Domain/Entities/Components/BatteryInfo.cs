namespace Vordr.Domain.Entities.Components;

public record BatteryInfo(
    string Name,
    string DesignedCapacity,
    string Manufacturer,
    string FullChargedCapacity,
    string Chemistry
    );
