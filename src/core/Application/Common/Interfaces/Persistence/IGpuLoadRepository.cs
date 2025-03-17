using MongoDB.Bson;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IGpuLoadRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(GpuLoad data);

}
