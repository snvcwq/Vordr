using MediatR;
using Presentation.Helpers;
using Vordr.Application.GpuUsage.Get;
using Vordr.Application.HardwareComponent.Queries.RetrieveAsync;
using Vordr.Domain.Entities.Components;

namespace Presentation.Slices;
public partial class Gpu : Form
{
    private readonly ISender _sender;
    public Gpu(ISender sender)
    {
        InitializeComponent();
        _sender = sender;
    }
    private async void UpdateComponents()
    {
        var hc = (await _sender.Send(new RetrieveHardwareComponentQuery())).Gpu.ToArray();
        ModelLabel.Content = hc[0].Name;
        DeviceLabel.Content = ConvertToValidString(hc[0].DeviceId);
    }
    override async protected void OnLoad(EventArgs e)
    {
        try
        {
            UpdateComponents();
        }
        catch (Exception exception)
        {
            // ignored
        }
    }
    public string ConvertToValidString(string input)
    {
        // Replace single backslash (\) with escaped backslash (\\)
        return input.Replace("\\", "\\\\");
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

            var query = new GetGpuUsageQuery
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

    private async Task DefineCharts(GetGpuUsageQuery query)
    {
        var result = await _sender.Send(query);
        var resultArray = result.ToArray();
        var temperatureStatus = resultArray.Select(x => (float)x.Temperature).ToArray();
        var loadPercentage = resultArray.Select(x => (float)x.LoadPercentage).ToArray();
        var clocks = resultArray.Select(x => (float)x.Clock).ToArray();
        var xAxisTemperature = ChartHelper.CalculateLegendDate(result.Min(x => x.CapturedAtUtc), result.Max(x => x.CapturedAtUtc), temperatureStatus.Length);
        var xAxisLoad = ChartHelper.CalculateLegendDate(result.Min(x => x.CapturedAtUtc), result.Max(x => x.CapturedAtUtc), loadPercentage.Length);
        var xAxisClocks = ChartHelper.CalculateLegendDate(result.Min(x => x.CapturedAtUtc), result.Max(x => x.CapturedAtUtc), clocks.Length);
        TemperatureChart.CustomXAxis = xAxisTemperature.ToArray();
        LoadChart.CustomXAxis = xAxisLoad.ToArray();
        ClockChart.CustomXAxis = xAxisClocks.ToArray();
        TemperatureChart.DataPoints = temperatureStatus;
        LoadChart.DataPoints = loadPercentage;
        
        ClockChart.DataPoints = clocks;
        ClockChart.MaxValue = clocks.Max();
    }


    private void OneDayCheckbox_Click(object sender, EventArgs e)
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
}
