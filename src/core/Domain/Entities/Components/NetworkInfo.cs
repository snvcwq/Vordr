namespace Vordr.Domain.Entities.Components;

public record NetworkInfo(
    string Name,
    string Description,
    bool IsReceiveOnly,
    string InterfaceType,
    bool SupportMulticast
    );
