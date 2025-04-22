using Vordr.Common.Config;
using Vordr.Common.Messaging.Messages.HardwareReports;

namespace Vordr.Client.Monitoring.Interfaces.Resources;

public interface IHardwareCollector
{
    public HardwareReport Collect(MonitoringConfiguration monitoringConfiguration);
    
}
