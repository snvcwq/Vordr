using MongoDB.Bson;
using Vordr.Application.GpuUsage.Get;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IGpuLoadRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(GpuLoad data);
    public Task<IEnumerable<GpuLoad>> RetrieveAsync(GetGpuUsageQuery query);

}
