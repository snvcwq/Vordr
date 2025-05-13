using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Ram.Queries.Get;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class RamUsagesRepository(MongoDbClient client, ILogger<RamUsagesRepository> logger) : IRamUsagesRepository
{
    private readonly IMongoCollection<RamUsage> _collection = client.RamUsagesCollection();

    public async Task<ErrorOr<ObjectId>> UploadAsync(RamUsage data)
    {
        try
        {
            await _collection.InsertOneAsync(data);
            return data.Id;

        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when uploading ram usage to db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }
    public async Task<IEnumerable<RamUsage>> RetrieveAsync(GetRamUsageQuery query)
    {
        var filterBuilder = Builders<RamUsage>.Filter;
        var filter = filterBuilder.Gte(x => x.CapturedAtUtc, query.StartDate) &
                     filterBuilder.Lte(x => x.CapturedAtUtc, query.EndDate)&
                     filterBuilder.Lte(x => x.ClientId, query.ClientId);
        
        return await (await _collection.FindAsync(filter)).ToListAsync();    }
}
