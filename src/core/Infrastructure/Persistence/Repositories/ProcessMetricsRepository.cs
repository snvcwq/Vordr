using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Models.Process;
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
                    $"Error occured when uploading process data for {process.Pid}. Errors: {updateResult.Errors.Print()}"));
            }
        }

        return errors.Count > 0
            ? errors
            : Result.Created;
    }


    public async Task<ErrorOr<Updated>> ChangePidAsync(IEnumerable<UpdatePidRequest> requests)
    {
        try
        {
            var requestData = requests.ToArray();
            var updateTasks = new List<Task<UpdateResult>>();

            foreach (var request in requestData.ToArray())
            {
                var filter = Builders<ProcessMetrics>.Filter.Eq(pd => pd.Pid, request.OldPid);
                var update = Builders<ProcessMetrics>.Update.Set(pd => pd.Pid, request.NewPid);

                var updateTask = _collection.UpdateManyAsync(filter, update);
                updateTasks.Add(updateTask);
            }

            await Task.WhenAll(updateTasks);

            return Result.Updated;
        }
        catch (Exception ex)
        {
            logger.LogError("An error occurred while updating PIDs. Message: {Message}, Stack Trace: {StackTrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }
}
