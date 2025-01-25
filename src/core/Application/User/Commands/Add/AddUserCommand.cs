using LanguageExt.Common;

namespace CleanArchitecture.Application.User.Commands.Add;

public record AddUserCommand : IRequest<Result<string>>
{
    public required string Name { get; set; }

    public required int Age { get; set; }
}
