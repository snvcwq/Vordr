using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class MonitoringConfigurationRepository(MongoDbClient client, ILogger<MonitoringConfigurationRepository> logger)
    : IMonitoringConfigurationRepository
{
    private readonly IMongoCollection<MonitoringConfiguration> _collection = client.MonitoringConfigurationCollection();

    public async Task<ErrorOr<Updated>> UpdateProcessMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.ProcessMonitoringConfig.MonitoringStatus, status);
        return await UpdateComponentMonitoringAsync(update, "process", status);
    }

    public async Task<ErrorOr<Updated>> DefineMaxProcessesToMonitorAsync(int maxProcessesNumber)
    {
        try
        {
            var options = new FindOneAndUpdateOptions<MonitoringConfiguration>();
            var update = Builders<MonitoringConfiguration>.Update
                .Set(mc => mc.ProcessMonitoringConfig.MaxProcessesToScan, maxProcessesNumber);
            await _collection.FindOneAndUpdateAsync(FilterDefinition<MonitoringConfiguration>.Empty, update, options);
            return Result.Updated;
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when changing max processes number to {number}. Message: {message}, Stack Trace: {stacktrace}",
                maxProcessesNumber, ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }

    public async Task<ErrorOr<Updated>> ExcludeProcessesFromMonitoringAsync(string[] processNames)
    {
        try
        {
            var filter = FilterDefinition<MonitoringConfiguration>.Empty;

            var update =
                Builders<MonitoringConfiguration>.Update.AddToSetEach(
                    mc => mc.ProcessMonitoringConfig.ExcludedProcesses, processNames);

            var options = new FindOneAndUpdateOptions<MonitoringConfiguration>();

            await _collection.FindOneAndUpdateAsync(filter, update, options);

            return Result.Updated;
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occurred when excluding processes {processes}. Message: {message}, Stack Trace: {stacktrace}",
                string.Join(", ", processNames), ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }

    public async Task<ErrorOr<Updated>> IncludeProcessesToMonitoringAsync(string[] processNames)
    {
        try
        {
            var filter = FilterDefinition<MonitoringConfiguration>.Empty;

            var update =
                Builders<MonitoringConfiguration>.Update.PullAll(mc => mc.ProcessMonitoringConfig.ExcludedProcesses,
                    processNames);

            var options = new FindOneAndUpdateOptions<MonitoringConfiguration>();

            await _collection.FindOneAndUpdateAsync(filter, update, options);

            return Result.Updated;
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occurred when including processes {processes}. Message: {message}, Stack Trace: {stacktrace}",
                string.Join(", ", processNames), ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }

    public async Task<ErrorOr<Updated>> UpdateProcessScanFrequencyMonitoringAsync(string frequency)
    {
        try
        {
            var update = Builders<MonitoringConfiguration>.Update
                .Set(mc => mc.ProcessMonitoringConfig.ScanFrequency, frequency);
            var options = new FindOneAndUpdateOptions<MonitoringConfiguration>();

            await _collection.FindOneAndUpdateAsync(FilterDefinition<MonitoringConfiguration>.Empty, update, options);
            return Result.Updated;
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when changing process scanning frequency to {frequency} .Message: {message}, Stack Trace: {stacktrace}",
                frequency, ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }

    public async Task<ErrorOr<Updated>> UpdateDrivesMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.MonitorDrives, status);
        return await UpdateComponentMonitoringAsync(update, "drives", status);
    }

    public async Task<ErrorOr<Updated>> UpdateCpuMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.MonitorCpu, status);
        return await UpdateComponentMonitoringAsync(update, "cpu", status);
    }

    public async Task<ErrorOr<Updated>> UpdateGpuMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.MonitorGpu, status);
        return await UpdateComponentMonitoringAsync(update, "gpu", status);
    }

    public async Task<ErrorOr<Updated>> UpdateRamMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.MonitorRam, status);
        return await UpdateComponentMonitoringAsync(update, "ram", status);
    }

    public async Task<ErrorOr<Updated>> UpdateStorageDevicesMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.MonitorStorageDevices, status);
        return await UpdateComponentMonitoringAsync(update, "storage devices", status);
    }

    public async Task<ErrorOr<Updated>> UpdateMotherBoardMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.MonitorMotherBoard, status);
        return await UpdateComponentMonitoringAsync(update, "motherboard", status);
    }

    public async Task<ErrorOr<Updated>> UpdateNetworkMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.MonitorNetwork, status);
        return await UpdateComponentMonitoringAsync(update, "network", status);
    }

    public async Task<ErrorOr<Updated>> UpdatePeripheralsMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.MonitorPeripherals, status);
        return await UpdateComponentMonitoringAsync(update, "peripherals", status);
    }

    public async Task<ErrorOr<Updated>> UpdateTemperatureMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.MonitorTemperature, status);
        return await UpdateComponentMonitoringAsync(update, "temperature", status);
    }

    public async Task<ErrorOr<Updated>> UpdatePowerSupplyMonitoringAsync(MonitoringStatus status)
    {
        var update = Builders<MonitoringConfiguration>.Update
            .Set(mc => mc.MonitorPowerSupply, status);
        return await UpdateComponentMonitoringAsync(update, "powerSupply", status);
    }

    public async Task<ErrorOr<MonitoringConfiguration>> RetrieveMonitoringConfigurationAsync()
    {
        try
        {
            var monitoringConfigurations = await _collection.FindAsync(FilterDefinition<MonitoringConfiguration>.Empty);
            return await monitoringConfigurations.FirstAsync();
        }
        catch (Exception ex)
        {
            logger.LogError("An error occured when retrieving monitoring configuration");
            return Error.Failure(ex.Message);
        }
        
    }

    private async Task<ErrorOr<Updated>> UpdateComponentMonitoringAsync(UpdateDefinition<MonitoringConfiguration> update,
        string component, MonitoringStatus status)
    {
        try
        {
            var options = new FindOneAndUpdateOptions<MonitoringConfiguration>();

            await _collection.FindOneAndUpdateAsync(FilterDefinition<MonitoringConfiguration>.Empty, update, options);
            return Result.Updated;
        }
        catch (Exception ex)
        {
            logger.LogError(
                "An error occured when changing {component} monitoring status to {status}. Message: {message}, Stack Trace: {stacktrace}",
                component, status.ToString(), ex.Message, ex.StackTrace);
            return Error.Failure(ex.Message);
        }
    }
}
