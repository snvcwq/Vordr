using Vordr.Application.Hardware.Commands.UploadHardwareMetrics;
using Vordr.Application.HardwareComponent.Commands;
using Vordr.Application.Models.Hardware;
using Vordr.Application.Models.Process;
using Vordr.Application.Process.Commands.Upload;
using Vordr.Common.Enums;
using Vordr.Common.Messaging;
using Vordr.Common.Messaging.Messages.HardwareComponents;
using Vordr.Common.Messaging.Messages.Process;
using Vordr.Common.Messaging.Messages.Registration;
using HardwareReport = Vordr.Common.Messaging.Messages.HardwareReports.HardwareReport;

namespace Vordr.Application.SocketMessages.HandleSocketMessagesCommand;

public class HandleSocketMessagesCommandHandler(ISender sender) : IRequestHandler<HandleSocketMessagesCommand, SocketResponse>
{

    public async Task<SocketResponse> Handle(HandleSocketMessagesCommand request, CancellationToken cancellationToken)
    {
        var msg = request.Message;
        object msgResponse;
        switch (msg.Type)
        {
            case MessageType.HardwareData:
                {
                    
                    await sender.Send(new UploadHardwareMetricsCommand((msg.Payload as HardwareReport)!.ToHardwareReport()), cancellationToken);
                    msgResponse = true;
                    break;
                }
            case MessageType.ProcessList:
                {
                    await sender.Send(new UploadCollectedProcessesCommand((msg.Payload as List<ProcessInfo>).ToProcessInformation()), cancellationToken);
                    msgResponse = true;
                    break;
                }   
            case MessageType.Registration:
                msgResponse = await sender.Send(new HandleClientRegistrationCommand.HandleClientRegistrationCommand((msg.Payload as RegistrationMessage)!), cancellationToken);
                break;
            case MessageType.HardwareComponents:
                {
                    await sender.Send(new UpdateHardwareComponentCommand(((msg.Payload as HardwareData)!).ToHardwareComponents()), cancellationToken);
                    msgResponse = true;
                }
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        return new SocketResponse(msg.Type, msgResponse);
    }
}
