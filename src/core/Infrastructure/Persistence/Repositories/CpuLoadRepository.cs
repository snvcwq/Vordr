using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.CpuUsage.Queries;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class CpuLoadRepository(MongoDbClient client, ILogger<CpuLoadRepository> logger) : ICpuLoadRepository
{
    private readonly IMongoCollection<CpuLoad> _collection = client.CpuLoadsCollection();

    public async Task<ErrorOr<ObjectId>> UploadAsync(CpuLoad data)
    {
        try
        {
            await _collection.InsertOneAsync(data);
            return data.Id;

        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when uploading cpu load to db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }
    public async Task<IEnumerable<CpuLoad>> RetrieveAsync(GetCpuUsageQuery usageQuery)
    {
        var filterBuilder = Builders<CpuLoad>.Filter;
        var filter = filterBuilder.Gte(x => x.CapturedAtUtc, usageQuery.StartDate) &
                     filterBuilder.Lte(x => x.CapturedAtUtc, usageQuery.EndDate)&
                     filterBuilder.Lte(x => x.ClientId, usageQuery.ClientId);
        
        return await (await _collection.FindAsync(filter)).ToListAsync();
    }
}
