using MongoDB.Bson;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IPowerSupplyRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(PowerSupply data);

}
