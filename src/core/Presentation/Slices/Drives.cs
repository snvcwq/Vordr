using LiveChartsCore.Defaults;
using LiveChartsCore.Measure;
using MediatR;
using Presentation.Helpers;
using Vordr.Application.CpuUsage.Queries.ProcessUsage;
using Vordr.Application.CpuUsage.Queries;
using Vordr.Application.Drives.Queries.Get;
using Vordr.Application.HardwareComponent.Queries.RetrieveAsync;
using Vordr.Domain.Entities;
using Vordr.Domain.Entities.Components;

namespace Presentation.Slices;
public partial class Drives : Form
{
    private readonly ISender _sender;
    public Drives(ISender sender)
    {
        _sender = sender;
        InitializeComponent();
    }
    private async void UpdateComponents()
    {
        var hc = (await _sender.Send(new RetrieveHardwareComponentQuery())).Drives;
        var cDrive = hc.FirstOrDefault(d => d.RootDirectory == "C:\\");
        var dDrive = hc.FirstOrDefault(d => d.RootDirectory == "D:\\");
        DiskCFormat.Content = cDrive.DriveFormat;
        DiskCLabel.Content = cDrive.DriveLabel;
        TypeDiskC.Content = cDrive.DriveType;
        RootDirectoryDiskC.Content = cDrive.RootDirectory;
        DiskDFormat.Content = dDrive.DriveFormat;
        DiskDLabel.Content = dDrive.DriveLabel;
        DiskDType.Content = dDrive.DriveType;
        DiskDRootDirectory.Content = dDrive.RootDirectory;
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

    private async Task DefineCharts(GetDriveUsageQuery query)
    {
        var result = await _sender.Send(query);
        var resultArray = result.ToArray();
        var diskCInfo = new List<DriveInformation>();
        var diskDInfo = new List<DriveInformation>();
        foreach (var drive in resultArray)
        {
            switch (drive.DriveName)
            {
                case "C:\\":
                    diskCInfo.Add(drive);
                    break;
                case "D:\\":
                    diskDInfo.Add(drive);
                    break;
            }
        }
        SetCChart(diskCInfo);
        SetDChart(diskDInfo);
    }

    private void SetCChart(IEnumerable<DriveInformation> driveInfo)
    {
        var data = driveInfo.Select(b => new DateTimePoint(b.CapturedAtUtc.ToLocalTime(), b.DriveTotalSizeGb - b.DriveFreeSpaceGb)).ToList();
        CChart.Series = ChartHelper.DefineChart(data);
        CChart.XAxes = ChartHelper.DefineChartX("time",
            driveInfo.Select(x => x.CapturedAtUtc).Max(), driveInfo.Select(x => x.CapturedAtUtc).Min() );
        CChart.YAxes = ChartHelper.DefineChartY("usage (GB)");
        CChart.ZoomMode = ZoomAndPanMode.Both;
    }
    
    private void SetDChart(IEnumerable<DriveInformation> driveInfo)
    {
        var data = driveInfo.Select(b => new DateTimePoint(b.CapturedAtUtc.ToLocalTime(), b.DriveTotalSizeGb - b.DriveFreeSpaceGb)).ToList();
        DChart.Series = ChartHelper.DefineChart(data);
        DChart.XAxes = ChartHelper.DefineChartX("time",
            driveInfo.Select(x => x.CapturedAtUtc).Max(), driveInfo.Select(x => x.CapturedAtUtc).Min() );
        DChart.YAxes = ChartHelper.DefineChartY("usage (GB)");
        DChart.ZoomMode = ZoomAndPanMode.Both;
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

            var query = new GetDriveUsageQuery()
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
}
