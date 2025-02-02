using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class CpuLoadRepository(MongoDbClient client, ILogger<RamUsagesRepository> logger) : ICpuLoadRepository
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
}
