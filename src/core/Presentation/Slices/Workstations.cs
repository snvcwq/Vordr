using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Presentation.Controls;
using Presentation.Helpers;
using Presentation.Options;
using Vordr.Application.Workstations.AddWorkstation;
using Vordr.Application.Workstations.GetWorkstation;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Presentation.Slices;
public partial class Workstations : Form
{
    private ISender Sender { get; set; }
    private IServiceScopeFactory ServiceScopeFactory { get; set; }
    public Workstations(ISender sender, IServiceScopeFactory serviceScopeFactory)
    {
        Sender = sender;
        ServiceScopeFactory = serviceScopeFactory;
        InitializeComponent();
    }

    override async protected void OnLoad(EventArgs e)
    {
        WorkstationsFlow.Controls.Clear();
        var workstations = await Sender.Send(new GetWorkstationCommand());
        foreach (var workstation in workstations)
            WorkstationsFlow.Controls.Add(new WorkstationControl(Sender, workstation));
    }

    private async void GenerateWorkstationidentifierButton_Click_2(object sender, EventArgs e)
    {
        var clientId = WorkstationHelper.CreateNewClientId();
        var workstation = new Workstation
        {
            LastModifiedUtc = DateTime.UtcNow,
            State = WorkstationState.PendingActivation,
            ClientId = clientId,
            Name = WorkstationNameTextbox.Content,
        };
        await Sender.Send(new AddWorkstationCommand(workstation));
        var socketOptions = ServiceScopeFactory.CreateScope().ServiceProvider.GetRequiredService<IOptions<SocketOptions>>().Value;
        NewWorkstationIdentifier.Content = WorkstationHelper.CreateNewWorkstationIdentifier(socketOptions, clientId, Name = WorkstationNameTextbox.Content);

    }
}
