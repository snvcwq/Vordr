using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IWorkstationRepository
{
    public Task<string> CreateWorkstationAsync(Workstation workstation);
    
    public Task<bool> RegisterWorkstationAsync(string clientId);
    
    public Task<bool> RemoveWorkstationAsync(string clientId);
}
