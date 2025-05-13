using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;

namespace Vordr.Application.Notfication.GetNotificationConfig;

public class GetNotificationConfigQueryHandler : IRequestHandler<GetNotificationConfigQuery, NotificationConfig?>
{
    private readonly INotificationRepository _repository;

    public GetNotificationConfigQueryHandler(INotificationRepository repository)
    {
        _repository = repository;
    }

    public async Task<NotificationConfig?> Handle(GetNotificationConfigQuery request, CancellationToken cancellationToken)
    {
        return await _repository.GetAsync();
    }
}
