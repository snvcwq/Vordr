using Vordr.Application.Models.Hardware;

namespace Vordr.Application.Hardware.Commands.UploadHardwareMetrics;

public record UploadHardwareMetricsCommand(HardwareReport HardwareReport, string clientId) : IRequest;
