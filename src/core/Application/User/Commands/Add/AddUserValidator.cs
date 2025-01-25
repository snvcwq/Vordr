
// ReSharper disable UnusedType.Global

namespace CleanArchitecture.Application.User.Commands.Add;

public class AddUserValidator : AbstractValidator<AddUserCommand>
{
    public AddUserValidator()
    {
        RuleLevelCascadeMode = CascadeMode.Stop;

        RuleFor(u => u.Name)
            .NotEmpty().WithMessage("Name is required");
        RuleFor(u => u.Age)
            .NotEmpty().WithMessage("Age is required");
    }    
}
