using MediatR;
using Vordr.Application.Alert.Command;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Presentation.Controls;
public partial class AlertControl : UserControl
{
    private AlertType AlertType { get; set; }
    private Alert Alert { get; set; }
    private string ObjectId { get; set; }
    private readonly ISender sender;
    public AlertControl(ISender sender, Alert alert)
    {
        this.sender = sender;
        Alert = alert;
        InitializeComponent();
        EnabledAlert.Checked = alert.Enabled;
        AlertType = alert.Type;
        ObjectId = alert.Id.ToString();
        DefineAlert(alert);

    }
    public void DefineAlert(Alert alert)
    {
        AlertName.Content = alert.Type switch
        {
            AlertType.ComputerDisconnected => "Computer Disconnected",
            AlertType.GpuIsMoreThan => "High GPU Usage",
            AlertType.GpuTempIsMoreThan => "Elevated GPU Temperature",
            AlertType.CpuIsMoreThan => "High CPU Load",
            AlertType.CpuTempIsMoreThan => "Increased CPU Temperature",
            AlertType.RamIsMoreThan => "Memory Usage Exceeded",
            AlertType.DriveIsMoreThan => "Low Disk Space Available",
            AlertType.BatteryLevelIsLessThan => "Low Battery Level",
            AlertType.BatteryDegradationLevelIsLessThan => "Battery Health Degraded",
            AlertType.ProcessUsesRamMoreThan => "Process Using Excessive RAM",
            AlertType.ProcessUsesCpuMoreThan => "Process Using Excessive CPU",
            _ => "Unknown Alert"
        };

        AlertDescription.Content = alert.Type switch
        {
            AlertType.ComputerDisconnected =>
                "This alert is triggered when the monitored client computer fails to report status for a prolonged period, indicating it may be offline or disconnected.",

            AlertType.GpuIsMoreThan =>
                "This alert notifies you when the GPU usage on the client machine reaches                %, suggesting potential graphical overload or high processing activity.",

            AlertType.GpuTempIsMoreThan =>
                "An alert will be triggered when the GPU temperature exceeds                    °C, which could indicate thermal stress or insufficient cooling.",

            AlertType.CpuIsMoreThan =>
                "You will receive an alert when CPU usage climbs to                    %, potentially indicating a heavy workload or performance bottleneck.",

            AlertType.CpuTempIsMoreThan =>
                "This alert will be sent if the CPU temperature exceeds                    °C, signaling the risk of overheating or inadequate thermal management.",

            AlertType.RamIsMoreThan =>
                "An alert will be issued when system memory usage surpasses                    %, which might cause performance degradation or application instability.",

            AlertType.DriveIsMoreThan =>
                "This alert triggers when disk usage exceeds                    %, warning of limited storage space that may affect system operations or logging.",

            AlertType.BatteryLevelIsLessThan =>
                "You’ll be notified when the battery charge level falls below                    %, which could lead to unexpected shutdowns if not addressed.",

            AlertType.BatteryDegradationLevelIsLessThan =>
                "An alert is triggered when the battery’s degradation level drops below                    %, indicating long-term wear and reduced capacity.",

            AlertType.ProcessUsesRamMoreThan =>
                "This alert notifies you when a specific process uses more than                    MB of RAM, which could impact system memory availability.",

            AlertType.ProcessUsesCpuMoreThan =>
                "An alert will be sent if a process consumes more than                    % of CPU resources, possibly affecting overall system performance.",

            _ => "This alert type is not recognized or lacks a defined description."
        };


        ValueTextBox.Content = alert.Value;
        if (alert.Type == AlertType.ComputerDisconnected)
            ValueTextBox.Hide();

        if (alert.Type is AlertType.GpuIsMoreThan)
            ValueTextBox.Location = new Point(105, 75);
        if (alert.Type is AlertType.GpuTempIsMoreThan)
            ValueTextBox.Location = new Point(561, 55);
        if (alert.Type is AlertType.CpuIsMoreThan)
            ValueTextBox.Location = new Point(469, 55);
        if (alert.Type is AlertType.CpuTempIsMoreThan)
            ValueTextBox.Location = new Point(469, 55);
        if (alert.Type is AlertType.RamIsMoreThan)
            ValueTextBox.Location = new Point(558, 55);
        if (alert.Type is AlertType.DriveIsMoreThan)
            ValueTextBox.Location = new Point(393, 55);
        if (alert.Type is AlertType.BatteryLevelIsLessThan)
            ValueTextBox.Location = new Point(558, 55);
        if (alert.Type is AlertType.BatteryDegradationLevelIsLessThan)
            ValueTextBox.Location = new Point(27, 74);
        if (alert.Type is AlertType.ProcessUsesCpuMoreThan)
            ValueTextBox.Location = new Point(459, 55);
        if (alert.Type is AlertType.ProcessUsesRamMoreThan)
            ValueTextBox.Location = new Point(561, 55);
    }

    private void SaveButton_Click(object sender, EventArgs e)
    {
        Alert.Enabled = EnabledAlert.Checked;
        Alert.Value = ValueTextBox.Content;
        this.sender.Send(new UpdateAlertCommand(Alert));
    }

    private void EnabledAlert_Click(object sender, EventArgs e)
    {

    }
}
