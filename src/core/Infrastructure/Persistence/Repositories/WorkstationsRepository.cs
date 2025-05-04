using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class WorkstationsRepository(MongoDbClient client) : IWorkstationRepository
{
    private readonly IMongoCollection<Workstation> _collection = client.WorkstationsCollection();
    
    public async Task<string> CreateWorkstationAsync(Workstation workstation)
    {
        await _collection.InsertOneAsync(workstation);
        return workstation.ClientId;
    }
    
    public async Task<bool> RegisterWorkstationAsync(string clientId, string? hostname)
    {
        var filter = Builders<Workstation>.Filter.Eq(w => w.ClientId, clientId);

        var updateBuilder = Builders<Workstation>.Update;
        var update = updateBuilder.Set(w => w.State, WorkstationState.Monitoring);

        if (!string.IsNullOrWhiteSpace(hostname))
        {
            update = update.Set(w => w.Name, hostname);
        }

        var result = await _collection.UpdateOneAsync(filter, update);
        return result.ModifiedCount > 0;
    }
    
    public async Task<bool> RemoveWorkstationAsync(string clientId)
    {
            var  result =await _collection.DeleteOneAsync(x => x.ClientId == clientId);
            return result.DeletedCount > 0;
    }
    public async Task<IEnumerable<Workstation>> GetWorkstationAsync()
    {
        var workstations = await _collection.Find(_ => true).ToListAsync();
        return workstations;    }
    public async Task<bool> ChangeMonitoringStateAsync(string clientId, WorkstationState state)
    {
        var filter = Builders<Workstation>.Filter.Eq(w => w.ClientId, clientId);
        var update = Builders<Workstation>.Update
            .Set(w => w.State, state);

        var result = await _collection.UpdateOneAsync(filter, update);
        return result.ModifiedCount > 0;
    }
}
