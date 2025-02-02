using MongoDB.Bson;
using MongoDB.Driver;
using Vordr.Application.Common.Extensions;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Application.Common.Models.Process;
using Vordr.Domain.Entities;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class ProcessDataRepository(MongoDbClient client, ILogger<ProcessDataRepository> logger) 
    : IProcessDataRepository
{
    private readonly IMongoCollection<ProcessData> _collection = client.ProcessDataCollection();

    public async Task<ErrorOr<ObjectId>> UploadAsync(ProcessData processData)
    {
        try
        {
            await _collection.InsertOneAsync(processData);
            return processData.Id;
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when uploading ProcessData to db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }

    public async Task<ErrorOr<Created>> UploadAsync(IEnumerable<ProcessData> processData)
    {
        var processes = processData.ToArray();
        List<Error> errors = [];
        foreach (var process in processes)
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
                var filter = Builders<ProcessData>.Filter.Eq(pd => pd.Pid, request.OldPid);
                var update = Builders<ProcessData>.Update.Set(pd => pd.Pid, request.NewPid);

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

    public async Task<ErrorOr<ObjectId>> UpdateAsync(ProcessData processData)
    {
        try
        {
            var filter = Builders<ProcessData>.Filter.Eq(pd => pd.Pid, processData.Pid);

            var options = new FindOneAndUpdateOptions<ProcessData>
            {
                ReturnDocument = ReturnDocument.After, IsUpsert = true
            };

            var update = Builders<ProcessData>.Update
                .Set(pd => pd.Name, processData.Name)
                .Set(pd => pd.StartTime, processData.StartTime)
                .Set(pd => pd.Icon, processData.Icon)
                .Set(pd => pd.Path, processData.Path)
                .Set(pd => pd.Priority, processData.Priority)
                .Set(pd => pd.Manufacturer, processData.Manufacturer)
                .Set(pd => pd.Version, processData.Version)
                .Set(pd => pd.Architecture, processData.Architecture)
                .Set(pd => pd.User, processData.User);
            var updatedProcess = await _collection.FindOneAndUpdateAsync(filter, update, options);

            return updatedProcess.Id;
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when updating ProcessData. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }

    public async Task<ErrorOr<Updated>> UpdateAsync(IEnumerable<ProcessData> processData)
    {
        var processes = processData.ToArray();
        List<Error> errors = [];
        foreach (var process in processes)
        {
            var updateResult = await UpdateAsync(process);
            if (updateResult.IsError)
            {
                errors.Add(Error.Failure(
                    $"Error occured when updating process data for {process.Pid}. Errors: {updateResult.Errors.Print()}"));
            }
        }

        return errors.Count > 0
            ? errors
            : Result.Updated;
    }

    public async Task<ErrorOr<IEnumerable<ProcessData>>> RetrieveAsync(IEnumerable<ProcessOsIdentifier> identifiers)
    {
        try
        {
            var filters = identifiers.Select(id =>
                Builders<ProcessData>.Filter.And(
                    Builders<ProcessData>.Filter.Eq(pd => pd.Name, id.Name),
                    Builders<ProcessData>.Filter.Eq(pd => pd.Path, id.RootPath),
                    Builders<ProcessData>.Filter.Eq(pd => pd.Version, id.version)
                )
            );
            var filter = Builders<ProcessData>.Filter.Or(filters);

            var processDataList = await _collection.FindAsync(filter);
            return await processDataList.ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when retrieving ProcessData by identifiers from db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }

    public async Task<ErrorOr<IEnumerable<ProcessData>>> RetrieveAsync()
    {
        try
        {
            var processDataList = await _collection.FindAsync(FilterDefinition<ProcessData>.Empty);
            return await processDataList.ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when retrieving ProcessData from db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }

    public async Task<ErrorOr<IEnumerable<ProcessData>>> RetrieveAsync(IEnumerable<int> pidLIst)
    {
        try
        {
            var filters = pidLIst.Select(pid =>
                Builders<ProcessData>.Filter.Eq(pd => pd.Pid, pid));

            var filter = Builders<ProcessData>.Filter.Or(filters);

            var processDataList = await _collection.FindAsync(filter);
            return await processDataList.ToListAsync();
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when retrieving ProcessData by pid list from db. Message: {message}, Stack Trace: {stacktrace}",
                ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }
}
