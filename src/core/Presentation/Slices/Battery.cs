using LiveChartsCore.Defaults;
using LiveChartsCore.Measure;
using MediatR;
using Presentation.Helpers;
using Presentation.Interface;
using Vordr.Application.Battery.Queries;
using Vordr.Application.HardwareComponent.Queries.RetrieveAsync;
using Vordr.Domain.Entities;

namespace Presentation.Slices;
public partial class Battery : Form, IResettable
{
    private readonly ISender _sender;
    public Battery(ISender sender)
    {
        _sender = sender;
        InitializeComponent();

    }

    private async void UpdateComponents()
    {
        var hc1 = (await _sender.Send(new RetrieveHardwareComponentQuery()));
        if (hc1 is null)
            return;
        var hc = hc1.Battery;
        ModelLabel.Content = hc.Name;
        ManufacturerLabel.Content = hc.Manufacturer;
        ChemistryLabel.Content = hc.Chemistry;
        DesignedCapacityLabel.Content = hc.DesignedCapacity.AppendmWh();
        FullChargedCapacityLabel.Content = hc.FullChargedCapacity.AppendmWh();
    }
    protected override async void OnLoad(EventArgs e)
    {
        try
        {
            base.OnLoad(e);
            UpdateComponents();

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
        
    }

    private void SetChargeChart(IEnumerable<PowerSupply> batteryData)
    {
        var data = batteryData.Select(b => new DateTimePoint(b.CapturedAtUtc.ToLocalTime(), Math.Round(b.ChargeLevel,3))).ToList();
        ChargeLevelChart.Series = ChartHelper.DefineChart(data);
        ChargeLevelChart.XAxes = ChartHelper.DefineChartX("time",
            batteryData.Select(x => x.CapturedAtUtc).Max(), batteryData.Select(x => x.CapturedAtUtc).Min() );
        ChargeLevelChart.YAxes = ChartHelper.DefineChartY("charge level");
        ChargeLevelChart.ZoomMode = ZoomAndPanMode.Both;
    }
    
    private void SetDegradationChart(IEnumerable<PowerSupply> batteryData)
    {
        var data = batteryData.Select(b => new DateTimePoint(b.CapturedAtUtc.ToLocalTime(),Math.Round(b.DegradationLevel,3))).ToList();
        DegradationLevelChart.Series = ChartHelper.DefineChart(data);
        DegradationLevelChart.XAxes = ChartHelper.DefineChartX("time",
            batteryData.Select(x => x.CapturedAtUtc).Max(), batteryData.Select(x => x.CapturedAtUtc).Min() );
        DegradationLevelChart.YAxes = ChartHelper.DefineChartY("degradation level");
        DegradationLevelChart.ZoomMode = ZoomAndPanMode.Both;
    }

    private async Task DefineCharts(GetBatteryUsageQuery query)
    {
        var result = await _sender.Send(query);
        SetChargeChart(result);
        SetDegradationChart(result);
    }

    private void FromLabel_Load(object sender, EventArgs e)
    {

    }
    private void ModelLabel_Load(object sender, EventArgs e)
    {

    }

    public void Reset()
    {
       // ChargeLevelChart.Dispose();
        //DegradationLevelChart.Dispose();
       // Controls.Clear();
    }
}
