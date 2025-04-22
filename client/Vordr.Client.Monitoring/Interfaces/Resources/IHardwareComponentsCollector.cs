using Vordr.Common.Messaging.Messages.HardwareComponents;

namespace Vordr.Client.Monitoring.Interfaces.Resources;

public interface IHardwareComponentsCollector
{
    public HardwareData Collect();
}
