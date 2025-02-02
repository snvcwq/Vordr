using Vordr.Application.RamUsage.Commands.Upload;

namespace Vordr.Application.CpuUsage.Commands.Upload;

public class UploadCpuLoadCommandValidator : AbstractValidator<UploadCpuLoadCommand>
{
    public UploadCpuLoadCommandValidator()
    {
        RuleFor(command => command.CapturedAtUtc)
            .NotNull()
            .WithMessage("{Please provide time when cpu load was collected");

        RuleFor(command => command.LoadPercents)
            .NotNull()
            .WithMessage("Please provide load in percents value memory");
        
    }
}
