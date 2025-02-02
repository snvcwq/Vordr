using Vordr.Application.Models.Ram;

namespace Vordr.Application.Common.Interfaces.Resources;

public interface IRamUsageCollector
{
    public RamUsageInformation Collect();

}
