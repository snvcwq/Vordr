using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.GpuUsage.Get;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class GpuLoadRepository(MongoDbClient client, ILogger<GpuLoadRepository> logger) : IGpuLoadRepository
{
    private readonly IMongoCollection<GpuLoad> _collection = client.GpuLoadsCollection();

    public async Task<ErrorOr<ObjectId>> UploadAsync(GpuLoad data)
    {
        try
        {
            await _collection.InsertOneAsync(data);
            return data.Id;

        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when uploading gpu load to db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }
    public async Task<IEnumerable<GpuLoad>> RetrieveAsync(GetGpuUsageQuery query)
    {
        var filterBuilder = Builders<GpuLoad>.Filter;
        var filter = filterBuilder.Gte(x => x.CapturedAtUtc, query.StartDate) &
                     filterBuilder.Lte(x => x.CapturedAtUtc, query.EndDate)&
                     filterBuilder.Lte(x => x.ClientId, query.ClientId);
        
        return await (await _collection.FindAsync(filter)).ToListAsync();
    }
}
