using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Battery.Queries;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class PowerSupplyRepository(MongoDbClient client, ILogger<PowerSupplyRepository> logger) : IPowerSupplyRepository
{
    private readonly IMongoCollection<PowerSupply> _collection = client.PowerSupplyCollection();

    public async Task<ErrorOr<ObjectId>> UploadAsync(PowerSupply data)
    {
        try
        {
            await _collection.InsertOneAsync(data);
            return data.Id;

        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when uploading power supply to db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }
    public async Task<IEnumerable<PowerSupply>> Retrieve(GetBatteryUsageQuery query)
    {
        var filterBuilder = Builders<PowerSupply>.Filter;
        var filter = filterBuilder.Gte(x => x.CapturedAtUtc, query.StartDate) &
                     filterBuilder.Lte(x => x.CapturedAtUtc, query.EndDate);
        
        return await (await _collection.FindAsync(filter)).ToListAsync();
    }
}
