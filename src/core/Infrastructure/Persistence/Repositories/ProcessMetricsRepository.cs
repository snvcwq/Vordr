using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.CpuUsage.Queries.ProcessUsage;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class ProcessMetricsRepository(MongoDbClient client, ILogger<ProcessMetricsRepository> logger)
    : IProcessMetricsRepository
{
    private readonly IMongoCollection<ProcessMetrics> _collection = client.ProcessMetricsCollection();

    public async Task<ErrorOr<ObjectId>> UploadAsync(ProcessMetrics process)
    {
        try
        {
            await _collection.InsertOneAsync(process);
            return process.Id;
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when uploading ProcessMetrics to db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }

    public async Task<ErrorOr<Created>> UploadAsync(IEnumerable<ProcessMetrics> processes)
    {
        var processMetrics = processes.ToArray();
        List<Error> errors = [];
        foreach (var process in processMetrics)
        {
            var updateResult = await UploadAsync(process);
            if (updateResult.IsError)
            {
                errors.Add(Error.Failure(
                    $"Error occured when uploading process data for {process.ProcessObjectId}. Errors: {updateResult.Errors.Print()}"));
            }
        }

        return errors.Count > 0
            ? errors
            : Result.Created;
    }
    public async Task<IEnumerable<ProcessMetrics>> GetTopUsage(GetTopCpuUsageQuery query)
    {
            var filterBuilder = Builders<ProcessMetrics>.Filter;
            var filter = filterBuilder.Gte(x => x.LastModifiedUtc, query.StartDate) &
                         filterBuilder.Lte(x => x.LastModifiedUtc, query.EndDate);
        
            return await (await _collection.FindAsync(filter)).ToListAsync();
    }
}
