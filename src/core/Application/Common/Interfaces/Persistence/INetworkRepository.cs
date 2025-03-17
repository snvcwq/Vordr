using MongoDB.Bson;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface INetworkRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(NetworkInformation data);

}
