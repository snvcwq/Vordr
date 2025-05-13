using MongoDB.Bson;
using Vordr.Application.Common.Interfaces.Persistence;

namespace Vordr.Application.Notfication.UpdateConfig;

public class UpdateConfigCommandHandler : IRequestHandler<UpdateConfigCommand, ErrorOr<ObjectId>>
{
    private readonly INotificationRepository _repository;

    public UpdateConfigCommandHandler(INotificationRepository repository)
    {
        _repository = repository;
    }

    public async Task<ErrorOr<ObjectId>> Handle(UpdateConfigCommand request, CancellationToken cancellationToken)
    {
        return await _repository.UpsertAsync(request.Config);
    }
}
