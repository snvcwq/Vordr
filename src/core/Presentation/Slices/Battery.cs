
using MediatR;
using Presentation.Helpers;
using Vordr.Application.Battery.Queries;
using Vordr.Application.Models;
using Vordr.Domain.Entities.Components;

namespace Presentation.Slices;
public partial class Battery : Form
{
    private readonly ISender _sender;
    public Battery(ISender sender, BatteryInfo info)
    {
        _sender = sender;
        InitializeComponent();
        ModelLabel.Content = info.Name;
        ManufacturerLabel.Content = info.Manufacturer;
        ChemistryLabel.Content = info.Chemistry;
        DesignedCapacityLabel.Content = info.DesignedCapacity.AppendmWh();
        FullChargedCapacityLabel.Content = info.FullChargedCapacity.AppendmWh();

        BatteryStatusChart.DataPoints = [66, 68, 70, 90, 60, 44, 35, 22, 11];
        BatteryDegradationStatus.DataPoints = [80, 90, 50, 67, 24, 2, 4, 51];



    }

    override async protected void OnLoad(EventArgs e)
    {
        try
        {
            base.OnLoad(e);
            await DefineCharts(new GetBatteryUsageQuery
            {
                StartDate = DateTime.UtcNow,
                EndDate = DateTime.UtcNow.AddDays(-1)
            });
        }
        catch (Exception exception)
        {
            // ignored
        }
    }
    private void cuiCheckbox1_Click(object sender, EventArgs e)
    {
        if (!OneDayCheckbox.Checked)
        {
            DayLabel.Visible = true;
            StartDate.Location = new Point(239, 39);
            FromLabel.Visible = false;
            ToLabel.Visible = false;
            EndDate.Visible = false;
            EndDate.Enabled = false;

        }
        else
        {
            StartDate.Location = new Point(267, 3);
            DayLabel.Visible = false;
            FromLabel.Visible = true;
            ToLabel.Visible = true;
            EndDate.Visible = true;
            EndDate.Enabled = true;
        }
    }

    private async void DisplayResults_Click(object sender, EventArgs e)
    {
        try
        {
            if (string.IsNullOrEmpty(StartHour.Content) || string.IsNullOrEmpty(EndHour.Content))
            {
                MessageBox.Show("Please fill start hour and end hour fields");
                return;
            }

            var startHourTuple = StartHour.Content.Split(':').Select(int.Parse).ToArray();
            var endHourTuple = EndHour.Content.Split(':').Select(int.Parse).ToArray();
            var validationResult = ChartHelper.ValidateTime(startHourTuple[0], startHourTuple[1]);
            var validationResult2 = ChartHelper.ValidateTime(endHourTuple[0], endHourTuple[1]);
            if (validationResult != null || validationResult2 != null)
            {
                MessageBox.Show($"{validationResult} {validationResult2}");
                return;
            }
            var endDate = OneDayCheckbox.Checked ? StartDate.Value : EndDate.Value;

            var query = new GetBatteryUsageQuery
            {
                StartDate = ChartHelper.DefineTime(StartDate.Value, startHourTuple[0], startHourTuple[1]),
                EndDate = ChartHelper.DefineTime(endDate, endHourTuple[0], endHourTuple[1])
            };
            validationResult = ChartHelper.ValidateTime(endHourTuple[0], endHourTuple[1]);
            if (validationResult != null)
            {
                MessageBox.Show(validationResult);
                return;
            }
            await DefineCharts(query);
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    }

    private async Task DefineCharts(GetBatteryUsageQuery query)
    {
        var result = await _sender.Send(query);
        var resultArray = result.ToArray();
        var batteryStatus = resultArray.Select(x => (float)x.ChargeLevel).ToArray();
        var degradationLevel = resultArray.Select(x => (float)x.DegradationLevel).ToArray();
        var xAxisBatteryStatus = ChartHelper.CalculateLegendDate(result.Min(x => x.CapturedAtUtc), result.Max(x => x.CapturedAtUtc), batteryStatus.Length);
        var xAxisBatteryDegradation = ChartHelper.CalculateLegendDate(result.Min(x => x.CapturedAtUtc), result.Max(x => x.CapturedAtUtc), degradationLevel.Length);
        BatteryStatusChart.CustomXAxis = xAxisBatteryStatus.ToArray();
        BatteryDegradationStatus.CustomXAxis = xAxisBatteryDegradation.ToArray();
        BatteryStatusChart.DataPoints = batteryStatus;
        BatteryDegradationStatus.DataPoints = degradationLevel;
    }

    private void FromLabel_Load(object sender, EventArgs e)
    {

    }
    private void ModelLabel_Load(object sender, EventArgs e)
    {

    }

}
