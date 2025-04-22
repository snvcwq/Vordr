namespace Vordr.Common.Messaging.Messages.HardwareComponents.Components;

public record BatteryInfo(
    string Name,
    string DesignedCapacity,
    string Manufacturer,
    string FullChargedCapacity,
    string Chemistry
    );
