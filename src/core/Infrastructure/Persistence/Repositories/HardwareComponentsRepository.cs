using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class HardwareComponentsRepository(MongoDbClient client) : IHardwareComponentsRepository
{
    private readonly IMongoCollection<HardwareComponents> _collection = client.HardwareComponentsCollection();

    public async Task UploadAsync(HardwareComponents data)
    {
        await _collection.DeleteManyAsync(FilterDefinition<HardwareComponents>.Empty);
        await _collection.InsertOneAsync(data);
    }
    public async Task<HardwareComponents> RetrieveAsync()
    {
        return (await _collection.FindAsync(FilterDefinition<HardwareComponents>.Empty)).SingleOrDefault();
    }
}
