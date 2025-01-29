using MongoDB.Bson;
using Vordr.Application.Common.Models.Process;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IProcessMetricsRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(ProcessMetrics process);

    public Task<ErrorOr<Created>> UploadAsync(IEnumerable<ProcessMetrics> processes);

    public Task<ErrorOr<Updated>> ChangePidAsync(IEnumerable<UpdatePidRequest> requests);
    
}
