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
    
    public async Task<bool> RegisterWorkstationAsync(string clientId)
    {
        var filter = Builders<Workstation>.Filter.Eq(w => w.ClientId, clientId);
        var update = Builders<Workstation>.Update
            .Set(w => w.State, WorkstationState.Monitoring);

        var result = await _collection.UpdateOneAsync(filter, update);
        return result.ModifiedCount > 0;
    }
    
    public async Task<bool> RemoveWorkstationAsync(string clientId)
    {
            var  result =await _collection.DeleteOneAsync(x => x.ClientId == clientId);
            return result.DeletedCount > 0;
    }
}
