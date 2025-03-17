using Vordr.Application.Models.Hardware;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Resources;

public interface IHardwareCollector
{
    public HardwareReport Collect(MonitoringConfiguration monitoringConfiguration);
    
}
