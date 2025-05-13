using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Drives.Queries.Get;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class DriveInfoRepository(MongoDbClient client, ILogger<DriveInfoRepository> logger) : IDriveInfoRepository
{
    private readonly IMongoCollection<DriveInformation> _collection = client.DriveInfoCollection();

    public async Task<ErrorOr<ObjectId>> UploadAsync(DriveInformation data)
    {
        try
        {
            await _collection.InsertOneAsync(data);
            return data.Id;

        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when uploading drive information load to db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }
    
    public async Task<IEnumerable<DriveInformation>> RetrieveAsync(GetDriveUsageQuery query)
    {
        var filterBuilder = Builders<DriveInformation>.Filter;
        var filter = filterBuilder.Gte(x => x.CapturedAtUtc, query.StartDate) &
                     filterBuilder.Lte(x => x.CapturedAtUtc, query.EndDate)&
                     filterBuilder.Lte(x => x.ClientId, query.ClientId);
        
        return await (await _collection.FindAsync(filter)).ToListAsync();    }
}
