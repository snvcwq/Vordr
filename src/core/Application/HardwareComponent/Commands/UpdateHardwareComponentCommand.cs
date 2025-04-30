using Vordr.Domain.Entities;

namespace Vordr.Application.HardwareComponent.Commands;

public record UpdateHardwareComponentCommand(HardwareComponents components) : IRequest;
