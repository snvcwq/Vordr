using MediatR;
using Vordr.Application.Workstations.ChangeWorkstationState;
using Vordr.Application.Workstations.DeleteWorkstation;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Presentation.Controls;
public partial class WorkstationControl : UserControl
{
    private ISender Sender { get; set; }
    private string ClientId { get; set; }
    
    private WorkstationState State { get; set; }

    private static readonly Color GreenColor = Color.FromArgb(43, 152, 121);
    private static readonly Color RedColor = Color.FromArgb(169, 86, 81);
    private static readonly Color YellowColor = Color.FromArgb(212, 172, 52);


    public WorkstationControl(ISender sender, Workstation workstation)
    {
        Sender = sender;
        ClientId = workstation.ClientId;
        InitializeComponent();
        Task.Delay(100).GetAwaiter().GetResult();

        WorkstationName.Content = workstation.Name;
        StateValue.Content = workstation.State.ToString();
        State = workstation.State;
        SetStateValue(workstation.State);
        MonitoreEnabledSwitch.Checked = workstation.State is WorkstationState.Monitoring or WorkstationState.PendingActivation;
    }

    private void SetStateValue(WorkstationState state)
    {
        StateValue.Content = state.ToString();

        StateValue.ForeColor = state switch
        {
            WorkstationState.Monitoring => GreenColor,
            WorkstationState.PendingActivation => YellowColor,
            _ => RedColor
        };

    }

    private async void DeleteWorkstationButton_Click(object sender, EventArgs e)
    {
        var result = MessageBox.Show(
            "All data related to this workstation will be deleted. Do you want to continue?",
            "Warning",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);

        if (result != DialogResult.Yes)
            return;

        await Sender.Send(new DeleteWorkstationCommand(ClientId));
        Dispose();
    }

    private async void MonitoreEnabledSwitch_CheckedChanged(object sender, EventArgs e)
    {
        if(State == WorkstationState.PendingActivation)
            return;
        
        var state = MonitoreEnabledSwitch.Checked ? WorkstationState.Monitoring : WorkstationState.Deactivated;
        await Task.Delay(100);
        await Sender.Send(new ChangeWorkstationStateCommand(ClientId, state));
        SetStateValue(state);

    }
}
