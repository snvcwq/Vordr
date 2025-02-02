using Vordr.Application.Models.Cpu;

namespace Vordr.Application.Common.Interfaces.Resources;

public interface ICpuUsageCollector
{
    public CpuLoadInformation Collect();
    
}
