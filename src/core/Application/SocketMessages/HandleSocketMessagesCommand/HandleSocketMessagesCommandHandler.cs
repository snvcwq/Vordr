using Newtonsoft.Json.Linq;
using Vordr.Application.Hardware.Commands.UploadHardwareMetrics;
using Vordr.Application.HardwareComponent.Commands;
using Vordr.Application.Models.Hardware;
using Vordr.Application.Models.Process;
using Vordr.Application.Process.Commands.Upload;
using Vordr.Application.Workstations.GetWorkstation;
using Vordr.Application.Workstations.GetWorkstationById;
using Vordr.Common.Enums;
using Vordr.Common.Helpers;
using Vordr.Common.Messaging;
using Vordr.Common.Messaging.Messages.HardwareComponents;
using Vordr.Common.Messaging.Messages.Process;
using Vordr.Common.Messaging.Messages.Registration;
using Vordr.Domain.Enums;
using HardwareReport = Vordr.Common.Messaging.Messages.HardwareReports.HardwareReport;

namespace Vordr.Application.SocketMessages.HandleSocketMessagesCommand;

public class HandleSocketMessagesCommandHandler(ISender sender) : IRequestHandler<HandleSocketMessagesCommand, SocketResponse>
{
    public async Task<SocketResponse> Handle(HandleSocketMessagesCommand request, CancellationToken cancellationToken)
    {
        var msg = request.Message;
        object msgResponse;
        if (msg.Type is not MessageType.Registration)
        {
            var workstation = await sender.Send(new GetWorkstationByIdCommand(request.Message.ClientId), cancellationToken);
            if (workstation is null)
                return new SocketResponse(MessageType.Registration, new RegistrationResponse(false));
            if(workstation.State is not WorkstationState.Monitoring)
                return new SocketResponse(MessageType.Registration, new RegistrationResponse(false));
            
        }
        switch (msg.Type)
        {
            case MessageType.HardwareData:
                {
                    await sender.Send(new UploadHardwareMetricsCommand(((msg.Payload as JObject)?.ToString().JsonDeserialize<HardwareReport>()!).ToHardwareReport(), msg.ClientId), cancellationToken);
                    msgResponse = true;
                    break;
                }
            case MessageType.ProcessList:
                {
                    
                    await sender.Send(new UploadCollectedProcessesCommand((msg.Payload as JArray)?.ToString().JsonDeserialize<List<ProcessInfo>>()!.ToProcessInformation()!, msg.ClientId), cancellationToken);
                    msgResponse = true;
                    break;
                }
            case MessageType.Registration:
                {
                   msgResponse = await sender.Send(new HandleClientRegistrationCommand.HandleClientRegistrationCommand((msg.Payload as JObject)?.ToString().JsonDeserialize<RegistrationMessage>()!), cancellationToken);
                   break;

                }
            case MessageType.HardwareComponents:
                {
                    await sender.Send(new UpdateHardwareComponentCommand((msg.Payload as JObject)?.ToString().JsonDeserialize<HardwareData>()!.ToHardwareComponents()!, msg.ClientId), cancellationToken);
                    msgResponse = true;
                }
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        return new SocketResponse(msg.Type, msgResponse);
    }
}
