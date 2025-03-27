using Vordr.Application.Common.Interfaces.Persistence;
using Vordr.Domain.Entities;
using Vordr.Domain.Enums;

namespace Presentation.Slices;
public partial class Monitoring : Form
{
    private IMonitoringConfigurationRepository _repository;
    private MonitoringConfiguration configuration;
    public Monitoring(IMonitoringConfigurationRepository repository)
    {
        _repository = repository;
        InitializeComponent();
    }
    override async protected void OnLoad(EventArgs e)
    {
        var response = await _repository.RetrieveMonitoringConfigurationAsync();
        response.Switch(
            config =>
            {
                configuration = config;
            },
            _ =>
            {
            });
        base.OnLoad(e);

        CpuSwitch.Checked = IsMonitored(configuration.MonitorCpu);
        GpuSwitch.Checked = IsMonitored(configuration.MonitorGpu);
        BatterySwitch.Checked = IsMonitored(configuration.MonitorPowerSupply);
        RamSwitch.Checked = IsMonitored(configuration.MonitorRam);
        DrivesSwitch.Checked = IsMonitored(configuration.MonitorDrives);
        ProcessesSwitch.Checked = IsMonitored(configuration.ProcessMonitoringConfig.MonitoringStatus);
    }

    private bool IsMonitored(MonitoringStatus status)
    {
        return status == MonitoringStatus.Enabled ? true : false;
    }

    private async void cuiSwitch1_Click(object sender, EventArgs e)
    {
        await Task.Delay(50);
        var monitoringStatus = CpuSwitch.Checked ? MonitoringStatus.Enabled : MonitoringStatus.Disabled;
        await _repository.UpdateCpuMonitoringAsync(monitoringStatus);
    }

    private void cuiLabel2_Load(object sender, EventArgs e)
    {

    }

    private void cuiLabel4_Load(object sender, EventArgs e)
    {

    }

    private void cuiLabel12_Load(object sender, EventArgs e)
    {

    }

    private void Monitoring_Load(object sender, EventArgs e)
    {

    }

    private async void GpuSwitch_Click(object sender, EventArgs e)
    {
        await Task.Delay(50);
        var monitoringStatus = CpuSwitch.Checked ? MonitoringStatus.Enabled : MonitoringStatus.Disabled;
        await _repository.UpdateGpuMonitoringAsync(monitoringStatus);
    }

    private async void BatterySwitch_Click(object sender, EventArgs e)
    {
        await Task.Delay(50);
        var monitoringStatus = CpuSwitch.Checked ? MonitoringStatus.Enabled : MonitoringStatus.Disabled;
        await _repository.UpdatePowerSupplyMonitoringAsync(monitoringStatus);
    }

    private async void RamSwitch_Click(object sender, EventArgs e)
    {
        await Task.Delay(50);
        var monitoringStatus = CpuSwitch.Checked ? MonitoringStatus.Enabled : MonitoringStatus.Disabled;
        await _repository.UpdateRamMonitoringAsync(monitoringStatus);
    }

    private async void DrivesSwitch_Click(object sender, EventArgs e)
    {
        await Task.Delay(50);
        var monitoringStatus = CpuSwitch.Checked ? MonitoringStatus.Enabled : MonitoringStatus.Disabled;
        await _repository.UpdateDrivesMonitoringAsync(monitoringStatus);
    }

    private async void ProcessesSwitch_Click(object sender, EventArgs e)
    {
        await Task.Delay(50);
        var monitoringStatus = CpuSwitch.Checked ? MonitoringStatus.Enabled : MonitoringStatus.Disabled;
        await _repository.UpdateProcessMonitoringAsync(monitoringStatus);
    }
}
