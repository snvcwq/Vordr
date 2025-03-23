using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IHardwareComponentsRepository
{
    public Task UploadAsync(HardwareComponents data);
    public Task<HardwareComponents> RetrieveAsync();
    public HardwareComponents Retrieve();
}
