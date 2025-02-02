using ErrorOr;
using MongoDB.Bson;
using Vordr.Application.Models.Process;
using Vordr.Domain.Entities;

namespace Vordr.Application.Common.Interfaces.Persistence;

public interface IProcessDataRepository
{
    public Task<ErrorOr<ObjectId>> UploadAsync(ProcessData processData);
    
    public Task<ErrorOr<Created>> UploadAsync(IEnumerable<ProcessData> processData);
    
    public Task<ErrorOr<Updated>> ChangePidAsync(IEnumerable<UpdatePidRequest> requests);

    public Task<ErrorOr<ObjectId>> UpdateAsync(ProcessData processData);
    
    public Task<ErrorOr<Updated>> UpdateAsync(IEnumerable<ProcessData> processData);

    public Task<ErrorOr<IEnumerable<ProcessData>>> RetrieveAsync(IEnumerable<ProcessOsIdentifier> identifiers);
    
    public Task<ErrorOr<IEnumerable<ProcessData>>> RetrieveAsync();
    
    public Task<ErrorOr<IEnumerable<ProcessData>>> RetrieveAsync(IEnumerable<int> pidLIst);

}
