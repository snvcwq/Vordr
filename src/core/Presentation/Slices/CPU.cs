using MediatR;
using Presentation.Helpers;
using Vordr.Application.CpuUsage.Queries;
using Vordr.Application.CpuUsage.Queries.ProcessUsage;
using Vordr.Application.Models;
using Vordr.Domain.Entities.Components;

namespace Presentation.Slices;
public partial class Cpu : Form
{
    private readonly ISender _sender;
    public Cpu(CpuInfo info, ISender sender)
    {
        InitializeComponent();
        TopLoadUsageLabel.Visible = false;
        TopUsageSeparator.Visible = false;
        _sender = sender;
        ModelLabel.Content = info.Name;
        CoresLabel.Content = info.Cores.ToString();
    }

    private void ModelLabel_Load(object sender, EventArgs e)
    {

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

            var query = new GetCpuUsageQuery()
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
            await ShowTopUsage(new GetTopCpuUsageQuery
            {
                StartDate = query.StartDate,
                EndDate = query.EndDate
            });
            
        }
        catch (Exception exception)
        {
            MessageBox.Show(exception.Message);
        }
    }

    private async Task ShowTopUsage(GetTopCpuUsageQuery query)
    {
        TopLoadUsageLabel.Visible = true;
        TopUsageSeparator.Visible = true;
        var result = (await _sender.Send(query)).ToArray();
        Top1LoadUsage.Content = CreateTopUsage(1, result[0]);
        Top2LoadUsage.Content = CreateTopUsage(2, result[1]);
        Top3LoadUsage.Content = CreateTopUsage(3, result[2]);
    }

    private string CreateTopUsage(int number, TopCpu cpu)
    {
        return $"{number}. {cpu.Name} at {cpu.Time.ToString("h:mm:ss")}. load: {Math.Round(cpu.Load,3)}%.";
    }
    
    private async Task DefineCharts(GetCpuUsageQuery query)
    {
        var result = await _sender.Send(query);
        var resultArray = result.ToArray();
        var temperature = resultArray.Select(x => (float)x.Temperature).ToArray();
        var load = resultArray.Select(x => (float)x.LoadPercents).ToArray();
        var xAxisTemperature = ChartHelper.CalculateLegendDate(result.Min(x => x.CapturedAtUtc), result.Max(x => x.CapturedAtUtc), temperature.Length);
        var xAxisLoad = ChartHelper.CalculateLegendDate(result.Min(x => x.CapturedAtUtc), result.Max(x => x.CapturedAtUtc), load.Length);
        TemperatureChart.CustomXAxis = xAxisTemperature.ToArray();
        LoadChart.CustomXAxis = xAxisLoad.ToArray();
        TemperatureChart.DataPoints = temperature;
        LoadChart.DataPoints = load;
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
