using MediatR;
using Presentation.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vordr.Application.Alert.Query.Get;

namespace Presentation.Slices;
public partial class Alerts : Form
{
    private readonly ISender Sender;
    public Alerts(ISender sender)
    {
        Sender = sender;
        InitializeComponent();
    }
    override async protected void OnLoad(EventArgs e)
    {
        AlertsFlowChart.Controls.Clear();
        var alerts = await Sender.Send(new GetAllAlertsCommand());
        foreach (var alert in alerts)
            AlertsFlowChart.Controls.Add(new AlertControl(Sender, alert));
    }
}
