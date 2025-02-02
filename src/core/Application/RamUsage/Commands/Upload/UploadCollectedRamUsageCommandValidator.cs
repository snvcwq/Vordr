namespace Vordr.Application.RamUsage.Commands.Upload;

public class UploadCollectedRamUsageCommandValidator : AbstractValidator<UploadCollectedRamUsageCommand>
{
    public UploadCollectedRamUsageCommandValidator()
    {
        RuleFor(command => command.CapturedAtUtc)
            .NotNull()
            .WithMessage("{Please provide time when ram usage was collected");

        RuleFor(command => command.TotalMemory)
            .NotNull()
            .WithMessage("Please provide total memory");
        
        RuleFor(command => command.UsedMemory)
            .NotNull()
            .WithMessage("Please provide used memory");
    }
}
