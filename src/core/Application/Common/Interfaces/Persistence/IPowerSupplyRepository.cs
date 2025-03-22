using MongoDB.Bson;
using Vordr.Application.Battery.Queries;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IPowerSupplyRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(PowerSupply data);
    public Task<IEnumerable<PowerSupply>> Retrieve(GetBatteryUsageQuery query);

}
