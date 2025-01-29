namespace Vordr.Application.Process.Commands;

public class UploadCollectedProcessesCommandValidator : AbstractValidator<UploadCollectedProcessesCommand>
{
    public UploadCollectedProcessesCommandValidator()
    {
        RuleFor(command => command.ProcessList)
            .NotNull()
            .NotEmpty()
            .WithMessage("List of processes that need to be uploaded cannot be null or empty");
    }
}
