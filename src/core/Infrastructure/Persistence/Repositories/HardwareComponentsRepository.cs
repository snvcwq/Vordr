using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class HardwareComponentsRepository(MongoDbClient client) : IHardwareComponentsRepository
{
    private readonly IMongoCollection<HardwareComponents> _collection = client.HardwareComponentsCollection();

    public async Task UploadAsync(HardwareComponents data, string clientId)
    {
        data.ClientId = clientId;

        var filter = Builders<HardwareComponents>.Filter.Eq(x => x.ClientId, clientId);

        var options = new ReplaceOptions { IsUpsert = true };

        await _collection.ReplaceOneAsync(filter, data, options);
    }
    public async Task<HardwareComponents> RetrieveAsync()
    {
        return (await _collection.FindAsync(FilterDefinition<HardwareComponents>.Empty)).SingleOrDefault();
    }
    public HardwareComponents Retrieve()
    {
        return (_collection.FindSync(FilterDefinition<HardwareComponents>.Empty)).SingleOrDefault();
    }
}
