using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IWorkstationRepository
{
    public Task<string> CreateWorkstationAsync(Workstation workstation);
    
    public Task<bool> RegisterWorkstationAsync(string clientId, string? name);
    
    public Task<bool> RemoveWorkstationAsync(string clientId);
    public Task<IEnumerable<Workstation>> GetWorkstationAsync();
    public Task<bool> ChangeMonitoringStateAsync(string clientId, WorkstationState state);
}
