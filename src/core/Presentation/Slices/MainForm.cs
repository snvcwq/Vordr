using MediatR;
using Presentation.Models;
using System.Runtime.InteropServices;
using Vordr.Application.Common.Interfaces.Services;
using Vordr.Application.Models.Hardware;
using Vordr.Application.Models.Process;
using Vordr.Application.Process.Commands.Upload;

namespace Presentation.Slices;

public partial class MainForm : Form
{
    private readonly ISender _sender;
    private readonly Battery batteryForm;
    private readonly Dashboard dashboard;
    private readonly Cpu cpuForm;
    private readonly Drives drivesForm;
    private readonly Gpu gpuForm;
    private readonly Monitoring monitoringForm;
    private readonly Processes processesForm;
    private readonly Ram ramForm;
    private readonly IHardwareMetricsCollectService _hardwareMetricsService;
    private readonly IProcessCollectService _processCollectService;
    private bool processesIntialized = false;
    private bool dashbordInitalized = false;
    public MainForm(ISender sender, Battery batteryForm, Cpu cpuForm, Drives drivesForm, Gpu gpuForm, Monitoring monitoringForm, Processes processesForm, Ram ramForm, IHardwareMetricsCollectService hardwareMetricsService, IProcessCollectService processCollectService, Dashboard dashboard)
    {
        _sender = sender;
        this.batteryForm = batteryForm;
        this.cpuForm = cpuForm;

        this.drivesForm = drivesForm;
        this.gpuForm = gpuForm;
        this.monitoringForm = monitoringForm;
        this.processesForm = processesForm;
        this.ramForm = ramForm;
        _hardwareMetricsService = hardwareMetricsService;
        _processCollectService = processCollectService;
        this.dashboard = dashboard;
        InitializeComponent();
        WindowState = FormWindowState.Normal;
    }
    public delegate void OnPassingProcesses(List<ProcessInformation> processes);
    public event OnPassingProcesses PassingProcesses;
    
    public delegate void OnPassingMetrics(HardwareReport report);
    public event OnPassingMetrics PassingMetrics;

    override async protected void OnLoad(EventArgs e)
    {
        CollectProcessesWorker.RunWorkerAsync(this);
        CollectHardwareWorker.RunWorkerAsync(this);

        base.OnLoad(e);
    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {
        //Padding = new Padding(2);
        //this.BackColor = Color.White;
    }

    //Drag Form
    [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
    private static extern void ReleaseCapture();

    [DllImport("user32.DLL", EntryPoint = "SendMessage")]
    private static extern void SendMessage(IntPtr hWnd, int wMmg, int wParam, int lParam);

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
        ReleaseCapture();
        SendMessage(Handle, 0x112, 0xf012, 0);
    }

    private void CloseButton_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void MinimizeButton_Click(object sender, EventArgs e)
    {
        WindowState = FormWindowState.Minimized;
    }

    private void DashboardButton_Click_2(object sender, EventArgs e)
    {
        if (!dashbordInitalized)
        {
            PassingMetrics += dashboard.HandleNewMetrics;
            dashbordInitalized = true;
        }
        LoadForm(dashboard);
    }
    private void LoadForm(object form)
    {
        if (MainPanel.Controls.Count > 0)
            MainPanel.Controls.RemoveAt(0);
        if (form is not Form newForm)
            return;
        newForm.TopLevel = false;
        newForm.Dock = DockStyle.Fill;
        MainPanel.Controls.Add(newForm);
        MainPanel.Tag = newForm;
        newForm.Show();
    }

    private void NetworkButton_Click(object sender, EventArgs e)
    {

    }

    private void MaximizeButton_Click(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Normal)
            WindowState = FormWindowState.Maximized;
        else if (WindowState == FormWindowState.Maximized)
            WindowState = FormWindowState.Normal;

    }

    private void SettingsButton_Click(object sender, EventArgs e)
    {
        LoadForm(monitoringForm);
    }

    private void ProcessButton_Click(object sender, EventArgs e)
    {
        if (!processesIntialized)
        {
            PassingProcesses += processesForm.HandleProcesses;
            processesIntialized = true;
        }
        LoadForm(processesForm);
    }

    private void DrivesButton_Click(object sender, EventArgs e)
    {
        LoadForm(drivesForm);

    }

    private void BatteryButton_Click(object sender, EventArgs e)
    {
        LoadForm(batteryForm);

    }

    private void CpuButton_Click(object sender, EventArgs e)
    {
        LoadForm(cpuForm);

    }

    private void GpuButton_Click(object sender, EventArgs e)
    {
        LoadForm(gpuForm);

    }

    private void RamButton_Click(object sender, EventArgs e)
    {
        LoadForm(ramForm);

    }

    private async void CollectProcessesWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        while (true)
        {
            var processes = await _processCollectService.ExecuteProcessDataCollectingAsync();
            PassingProcesses?.Invoke(processes);
            await _sender.Send(new UploadCollectedProcessesCommand(processes));

            await Task.Delay(1000);
            GC.Collect();

        }
    }

    private async void CollectHardwareWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        while (true)
        {
            
            var data = await _hardwareMetricsService.CollectHardwareAsync(CancellationToken.None);
            PassingMetrics?.Invoke(data);
            GC.Collect();
        }
    }
}
