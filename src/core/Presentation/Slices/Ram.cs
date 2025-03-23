using MediatR;
using Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vordr.Application.CpuUsage.Queries;
using Vordr.Application.Ram.Queries.Get;

namespace Presentation.Slices;
public partial class Ram : Form
{
    private readonly ISender _sender;
    public Ram(ISender sender)
    {
        _sender = sender;
        InitializeComponent();
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

            var query = new GetRamUsageQuery()
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
    
    private async Task DefineCharts(GetRamUsageQuery query)
    {
        var result = await _sender.Send(query);
        var resultArray = result.ToArray();
        var useMemory = resultArray.Select(x => (float)x.UsedMemory).ToArray();
        var xAxisLoad = ChartHelper.CalculateLegendDate(result.Min(x => x.CapturedAtUtc), result.Max(x => x.CapturedAtUtc), useMemory.Length);
        RamChart.CustomXAxis = xAxisLoad.ToArray();
        RamChart.DataPoints = useMemory;
        RamChart.MaxValue = (float)result.Max(x => x.UsedMemory + x.AvailableMemory);
    }
}
