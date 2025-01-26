using LanguageExt.Common;

namespace Vordr.Application.User.Commands.Add;

// ReSharper disable once UnusedType.Global
public class AddUserHandler : IRequestHandler<AddUserCommand, Result<string>>
{
    public Task<Result<string>> Handle(AddUserCommand request, CancellationToken cancellationToken)
    {
        var user = new Vordr.Domain.Entities.User { Name = request.Name, Age = request.Age };
        return Task.FromResult<Result<string>>(user.Id.Value.ToString());
    }
}
