namespace Vordr.Common.Messaging.Messages.HardwareComponents.Components;

public record NetworkInfo(
    string Name,
    string Description,
    bool IsReceiveOnly,
    string InterfaceType,
    bool SupportMulticast
    );
