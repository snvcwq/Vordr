using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Interface;
using System.Runtime.InteropServices;
using Vordr.Application.Models.Hardware;
using Vordr.Application.Models.Process;

namespace Presentation.Slices;

public partial class MainForm : Form
{
    private readonly ISender _sender;
    private readonly IServiceScopeFactory _serviceScopeFactory;
    private readonly Battery _batteryForm;
    private readonly Workstations _workstationsForm;
    private bool _processesIntialized = false;
    private bool dashbordInitalized = false;
    private Form _currentForm = null;

    public MainForm(ISender sender, Battery batteryForm, Workstations workstationsForm, IServiceScopeFactory serviceScopeFactory)
    {
        _sender = sender;
        _batteryForm = batteryForm;
        _workstationsForm = workstationsForm;
        _serviceScopeFactory = serviceScopeFactory;
        InitializeComponent();
        WindowState = FormWindowState.Normal;
    }
    public delegate void OnPassingProcesses(List<ProcessInformation> processes);
    public event OnPassingProcesses PassingProcesses;

    public delegate void OnPassingMetrics(HardwareReport report);
    public event OnPassingMetrics PassingMetrics;

    override async protected void OnLoad(EventArgs e)
    {
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
            dashbordInitalized = true;
        }
    }
    private void LoadForm(object form)
    {
        _currentForm?.Hide(); // Optionally, hide the form or reset its data
        if (_currentForm is IResettable resettableForm)
        {
            resettableForm.Reset(); // If the form implements IResettable, reset its data
        }

        if (MainPanel.Controls.Count > 0)
            MainPanel.Controls.RemoveAt(0);

        if (form is not Form newForm)
            return;

        newForm.TopLevel = false;
        newForm.Dock = DockStyle.Fill;
        MainPanel.Controls.Add(newForm);
        MainPanel.Tag = newForm;
        newForm.Show();

        // Track the new form
        _currentForm = newForm;
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
    }

    private void ProcessButton_Click(object sender, EventArgs e)
    {
    }

    private void DrivesButton_Click(object sender, EventArgs e)
    {

    }

    private void BatteryButton_Click(object sender, EventArgs e)
    {
        LoadForm(_batteryForm);

    }

    private void CpuButton_Click(object sender, EventArgs e)
    {

    }

    private void GpuButton_Click(object sender, EventArgs e)
    {

    }

    private void RamButton_Click(object sender, EventArgs e)
    {

    }

    private async void CollectProcessesWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        while (true)
        {
            /*var processes = await _processCollectService.ExecuteProcessDataCollectingAsync();
            PassingProcesses?.Invoke(processes);
            await _sender.Send(new UploadCollectedProcessesCommand(processes));

            await Task.Delay(1000);
            GC.Collect();
*/
        }
    }

    private async void CollectHardwareWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
    {
        while (true)
        {
            /*
            var data = await _hardwareMetricsService.CollectHardwareAsync(CancellationToken.None);
            PassingMetrics?.Invoke(data);
            GC.Collect();
        */
        }
    }

    private void WorkstationsButton_Click(object sender, EventArgs e)
    {
        LoadForm(_workstationsForm);
    }
}
