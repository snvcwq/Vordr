using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using Presentation.Helpers;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vordr.Application.Models.Hardware;
using Vordr.Application.Models.Hardware.Components;

namespace Presentation.Slices;
public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
    }

    public async void HandleNewMetrics(HardwareReport report)
    {
        // Update the UI thread with the list of processes
        // Make sure the UI update happens on the main thread using Invoke
        if (InvokeRequired)
        {
            // If the method is being called from a non-UI thread, invoke it on the UI thread
            await InvokeAsync(() => HandleNewMetrics(report));
            return;
        }

        UpdateMetrics(report);
    }
    public async void UpdateMetrics(HardwareReport report)
    {
        DefineBattery(report.Battery);
        DefineLoad(report.Cpu, report.Gpu);
        DefineTemperature(report.Cpu, report.Gpu);
        DefineDrives(report.Drives);
    }

    public void DefineBattery(PowerSupplyReport report )
    {
        var degradationColour = ColorTransition.GetColorGreenToRed((int)report.DegradationLevel);
        DegradationLevelBar.Value = (int)report.DegradationLevel;
        DegradationLevelBar.Foreground = degradationColour;
        DegradationLevelValue.Content = report.DegradationLevel.ToString(CultureInfo.InvariantCulture);
        DegradationLevelValue.ForeColor = degradationColour;
        
        var chargeColour = ColorTransition.GetColorRedToGreen((int)report.ChargeLevel);
        ChargeLevelBar.Value = (int)report.ChargeLevel;
        ChargeLevelBar.Foreground = chargeColour;
        ChargeLevelValue.Content = report.ChargeLevel.ToString(CultureInfo.InvariantCulture);
        ChargeLevelValue.ForeColor = chargeColour;
        
    }
    
    public void DefineLoad(CpuReport cpuReport, GpuReport gpuReport)
    {
        var cpuColour = ColorTransition.GetColorGreenToRed((int)cpuReport.AvgUsage);
        CpuLoadTrack.Value = (float)cpuReport.AvgUsage;
        CpuLoadTrack.ForeColor = cpuColour;
        CpuLoadTrack.ThumbColor = cpuColour;
        
        var gpuColour = ColorTransition.GetColorGreenToRed((int)gpuReport.AvgLoad);
        GpuLoadTrack.Value = (float)gpuReport.AvgLoad;
        GpuLoadTrack.ForeColor = gpuColour;
        GpuLoadTrack.ThumbColor = gpuColour;
    }
    
    public void DefineTemperature(CpuReport cpuReport, GpuReport gpuReport)
    {
        var cpuColour = ColorTransition.GetColorGreenToRed((int)cpuReport.Temperature);
        CpuTemperatureTrack.Value = (int)cpuReport.Temperature;
        CpuTemperatureTrack.Foreground = cpuColour;
        CpuTemperature.Content = cpuReport.Temperature.ToString(CultureInfo.InvariantCulture);
        CpuTemperature.ForeColor = cpuColour;
        
        var gpuColour = ColorTransition.GetColorRedToGreen((int)gpuReport.Temperature);
        GpuTemperatureTrack.Value = (int)gpuReport.Temperature;
        GpuTemperatureTrack.Foreground = gpuColour;
        GpuTemperature.Content = gpuReport.Temperature.ToString(CultureInfo.InvariantCulture);
        GpuTemperature.ForeColor = cpuColour;
    }
    
    public void DefineDrives(List<DriveReport> reports)
    {
        var dDrive = reports.FirstOrDefault(r => r.DriveName == "D:\\");
        DDrive.Series = new List<ISeries>
        {
            new PieSeries<double>
            {
                IsVisibleAtLegend = false,
                Values = new List<double> { Math.Round(dDrive.DriveFreeSpace,3) },
                DataLabelsPaint = GetSolidColorPaint(43,152,121),
                DataLabelsSize = 0,
                DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.End,
                MaxRadialColumnWidth = 60,
                Fill = new SolidColorPaint(Color.FromArgb(43, 152, 121).ToSKColor()),
            },
            new PieSeries<double>
            {
                Values = new List<double> { Math.Round((dDrive.DriveTotalSize - dDrive.DriveFreeSpace),3) },
                DataLabelsPaint = GetSolidColorPaint(169,86,81),
                DataLabelsSize = 0,
                DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.End,
                MaxRadialColumnWidth = 60,
                Fill = new SolidColorPaint(Color.FromArgb(169, 86, 81).ToSKColor()),
            }
        };
        
        var cDrive = reports.FirstOrDefault(r => r.DriveName == "C:\\");
        var x = new PieSeries<double>()
        {

        };
        CDrive.Series = new List<ISeries>
        {
            new PieSeries<double>
            {
                Values = new List<double> { Math.Round(cDrive.DriveFreeSpace,3) },
                DataLabelsPaint = GetSolidColorPaint(43,152,121),
                DataLabelsSize = 0,
                DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                EasingFunction = null,
                MaxRadialColumnWidth = 60,
                Fill = new SolidColorPaint(Color.FromArgb(43, 152, 121).ToSKColor()),
                
            },
            new PieSeries<double>
            {
                Values = new List<double> { Math.Round(cDrive.DriveTotalSize - cDrive.DriveFreeSpace,3) },
                DataLabelsPaint = GetSolidColorPaint(169, 86, 81),
                DataLabelsSize = 0,
                DataLabelsPosition = LiveChartsCore.Measure.PolarLabelsPosition.Middle,
                MaxRadialColumnWidth = 60,
                Fill = new SolidColorPaint(Color.FromArgb(169, 86, 81).ToSKColor()),
            }
        };

    }
    private SolidColorPaint GetSolidColorPaint(int r, int g, int b) =>
        new SolidColorPaint(Color.FromArgb(r,g,b).ToSKColor());
    
    private void cuiLabel7_Load(object sender, EventArgs e)
    {

    }

    private void cuiLabel13_Load(object sender, EventArgs e)
    {

    }

    private void cuiLabel1_Load(object sender, EventArgs e)
    {

    }
}
