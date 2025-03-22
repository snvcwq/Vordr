using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Resources;

public interface IHardwareComponentsCollector
{
    public HardwareComponents Collect();
}
