using LiveChartsCore.Defaults;
using LiveChartsCore.Measure;
using MediatR;
using Presentation.Helpers;
using Vordr.Application.GpuUsage.Get;
using Vordr.Application.HardwareComponent.Queries.RetrieveAsync;
using Vordr.Domain.Entities;
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
        SetTempChart(result);
        SetLoadChart(result);
        SetClockChart(result);
    }

    private void SetTempChart(IEnumerable<GpuLoad> usage)
    {
        var data = usage.Select(b => new DateTimePoint(b.CapturedAtUtc.ToLocalTime(),b.Temperature)).ToList();
        TempChart.Series = ChartHelper.DefineChart(data);
        TempChart.XAxes = ChartHelper.DefineChartX("time",
            usage.Select(x => x.CapturedAtUtc).Max(), usage.Select(x => x.CapturedAtUtc).Min() );
        TempChart.YAxes = ChartHelper.DefineChartY("temperature (GB)");
        TempChart.ZoomMode = ZoomAndPanMode.Both;
    }
    
    private void SetLoadChart(IEnumerable<GpuLoad> usage)
    {
        var data = usage.Select(b => new DateTimePoint(b.CapturedAtUtc.ToLocalTime(),b.LoadPercentage)).ToList();
        LoadChart.Series = ChartHelper.DefineChart(data);
        TempChart.XAxes = ChartHelper.DefineChartX("time",
            usage.Select(x => x.CapturedAtUtc).Max(), usage.Select(x => x.CapturedAtUtc).Min() );
        TempChart.YAxes = ChartHelper.DefineChartY("load (%)");
        TempChart.ZoomMode = ZoomAndPanMode.Both;
    }
    
    private void SetClockChart(IEnumerable<GpuLoad> usage)
    {
        var data = usage.Select(b => new DateTimePoint(b.CapturedAtUtc.ToLocalTime(),b.Clock)).ToList();
        ClockChart.Series = ChartHelper.DefineChart(data);
        TempChart.XAxes = ChartHelper.DefineChartX("time",
            usage.Select(x => x.CapturedAtUtc).Max(), usage.Select(x => x.CapturedAtUtc).Min() );
        TempChart.YAxes = ChartHelper.DefineChartY("speed");
        TempChart.ZoomMode = ZoomAndPanMode.Both;
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
