using MongoDB.Driver;
using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Vordr.Infrastructure.Persistence.Repositories;

public class WorkstationsRepository(MongoDbClient client) : IWorkstationRepository
{
    private readonly IMongoCollection<Workstation> _collection = client.WorkstationsCollection();
    private readonly IMongoCollection<CpuLoad> _cpuUsage = client.CpuLoadsCollection();
    private readonly IMongoCollection<DriveInformation> _driveCollection = client.DriveInfoCollection();
    private readonly IMongoCollection<GpuLoad> _gpuCollection = client.GpuLoadsCollection();
    private readonly IMongoCollection<HardwareComponents> _hdCollection = client.HardwareComponentsCollection();
    private readonly IMongoCollection<NetworkInformation> _networkCollection = client.NetworkInfoCollection();
    private readonly IMongoCollection<PowerSupply> _powerSupplyCollection = client.PowerSupplyCollection();
    private readonly IMongoCollection<ProcessMetrics> _processMetricsCollection = client.ProcessMetricsCollection();
    private readonly IMongoCollection<ProcessData> _processDataCollection = client.ProcessDataCollection();
    private readonly IMongoCollection<RamUsage> _ramUsageCollection = client.RamUsagesCollection();
    
    public async Task<string> CreateWorkstationAsync(Workstation workstation)
    {
        await _collection.InsertOneAsync(workstation);
        return workstation.ClientId;
    }
    
    public async Task<bool> RegisterWorkstationAsync(string clientId, string? hostname)
    {
        var filter = Builders<Workstation>.Filter.Eq(w => w.ClientId, clientId);

        var updateBuilder = Builders<Workstation>.Update;
        var update = updateBuilder.Set(w => w.State, WorkstationState.Monitoring);

        if (!string.IsNullOrWhiteSpace(hostname))
            update = update.Set(w => w.Name, hostname);

        var result = await _collection.UpdateOneAsync(filter, update);
        return result.ModifiedCount > 0;
    }
    
    public async Task<bool> RemoveWorkstationAsync(string clientId)
    {
        
        await _cpuUsage.DeleteManyAsync(x => x.ClientId == clientId);
        await _driveCollection.DeleteManyAsync(x => x.ClientId == clientId);
        await _gpuCollection.DeleteManyAsync(x => x.ClientId == clientId);
        await _hdCollection.DeleteManyAsync(x => x.ClientId == clientId);
        await _networkCollection.DeleteManyAsync(x => x.ClientId == clientId);
        await _powerSupplyCollection.DeleteManyAsync(x => x.ClientId == clientId);
        await _processMetricsCollection.DeleteManyAsync(x => x.ClientId == clientId);
        await _processDataCollection.DeleteManyAsync(x => x.ClientId == clientId);
        await _ramUsageCollection.DeleteManyAsync(x => x.ClientId == clientId);
        var  result =await _collection.DeleteOneAsync(x => x.ClientId == clientId);
        return result.DeletedCount > 0;
    }
    public async Task<IEnumerable<Workstation>> GetWorkstationAsync()
    {
        var workstations = await _collection.Find(_ => true).ToListAsync();
        return workstations;    }
    public async Task<Workstation?> GetWorkstationAsync(string clientId)
    {
        var workstations = await _collection.Find(x => x.ClientId == clientId).ToListAsync();
        return workstations.FirstOrDefault();
    }
    public async Task<bool> ChangeMonitoringStateAsync(string clientId, WorkstationState state)
    {
        var filter = Builders<Workstation>.Filter.Eq(w => w.ClientId, clientId);
        var update = Builders<Workstation>.Update
            .Set(w => w.State, state);

        var result = await _collection.UpdateOneAsync(filter, update);
        return result.ModifiedCount > 0;
    }
}
