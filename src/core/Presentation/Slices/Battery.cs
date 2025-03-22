
using MediatR;
using Vordr.Application.Battery.Queries;
using Vordr.Application.Models;

namespace Presentation.Slices;
public partial class Battery : Form
{
    private readonly ISender _sender;
    public Battery(ISender sender)
    {
        _sender = sender;
        InitializeComponent();
        BatteryStatusChart.DataPoints = [66, 68, 70, 90, 60, 44, 35, 22, 11];
        BatteryDegradationStatus.DataPoints = [80, 90, 50, 67, 24, 2, 4, 51];

    }

    private void cuiCheckbox1_Click(object sender, EventArgs e)
    {
        if (ShortTermCheckbox.Checked)
        {
            FromLabel.Visible = false;
            ToLabel.Visible = false;
            EndDate.Visible = false;
            EndDate.Enabled = false;

        }
        else
        {
            FromLabel.Visible = true;
            ToLabel.Visible = true;
            EndDate.Visible = true;
            EndDate.Enabled = true;
        }
    }

    private void DisplayResults_Click(object sender, EventArgs e)
    {
        if(string.IsNullOrEmpty(StartHour.Content) || string.IsNullOrEmpty(EndHour.Content))
        {
            MessageBox.Show("Please fill start hour and end hour fields");
            return;
        }

        var startHourTuple = Array.Empty<float>();
        var endHourTuple = Array.Empty<float>();
        try
        {
            startHourTuple = StartHour.Content.Split(':').Select(float.Parse).ToArray();
            endHourTuple = StartHour.Content.Split(':').Select(float.Parse).ToArray();
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
        var endDate = ShortTermCheckbox.Checked ? StartDate.Value.AddDays(1) : EndDate.Value;
      
        var query = new GetBatteryUsageQuery
        {
            StartDate = StartDate.Value,
            EndDate = endDate,
            StartHour = new DayTime
            {
                Hour = (short)startHourTuple[0],
                Minutes = (short)startHourTuple[1]
            },
            EndHour =  new DayTime
            {
                Hour = (short)endHourTuple[0],
                Minutes = (short)endHourTuple[1]
            }
        };
        var result = _sender.Send(query).GetAwaiter().GetResult();
        var resultArray = result.ToArray();
        BatteryStatusChart.DataPoints = resultArray.Select(x => (float)x.ChargeLevel).ToArray();
        BatteryDegradationStatus.DataPoints =  resultArray.Select(x => (float)x.DegradationLevel).ToArray();
    }

    private void FromLabel_Load(object sender, EventArgs e)
    {

    }
}
