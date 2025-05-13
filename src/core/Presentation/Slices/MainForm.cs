using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Presentation.Controls;
using Presentation.StaticData;
using System.Runtime.InteropServices;
using Vordr.Application.Models.Hardware;
using Vordr.Application.Models.Process;
using Vordr.Application.Workstations.GetWorkstation;
using Vordr.Domain.Entities;

namespace Presentation.Slices;

public partial class MainForm : Form
{
    private readonly ISender _sender;
    private readonly IServiceScopeFactory _serviceScopeFactory;
    private bool _processesIntialized = false;
    private bool _dashbordInitalized;


    private Battery _battery = null;
    private Cpu _cpu = null;
    private Dashboard _dashboard = null;
    private Drives _drives = null;
    private Gpu _gpu = null;
    private Processes _processes = null;
    private Ram _ram = null;
    private Workstations _workstation = null;
    private Settings _settings = null;
    private Alerts _alert = null;

    public MainForm(ISender sender, IServiceScopeFactory serviceScopeFactory)
    {
        _sender = sender;
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
        _dashboard = new Dashboard();
        LoadForm(_dashboard);

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

    private void MaximizeButton_Click(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Normal)
            WindowState = FormWindowState.Maximized;
        else if (WindowState == FormWindowState.Maximized)
            WindowState = FormWindowState.Normal;

    }

    private void SettingsButton_Click(object sender, EventArgs e)
    {
        _settings = new Settings(_sender);
        LoadForm(_settings);
    }

    private void ProcessButton_Click(object sender, EventArgs e)
    {
        _processes = new Processes();
        LoadForm(_processes);
    }

    private void DrivesButton_Click(object sender, EventArgs e)
    {
        _drives = new Drives(_sender);
        LoadForm(_drives);
    }

    private void BatteryButton_Click(object sender, EventArgs e)
    {
        _battery = new Battery(_sender);
        LoadForm(_battery);
    }

    private void CpuButton_Click(object sender, EventArgs e)
    {
        _cpu = new Cpu(_sender);
        LoadForm(_cpu);
    }

    private void GpuButton_Click(object sender, EventArgs e)
    {
        _gpu = new Gpu(_sender);
        LoadForm(_gpu);
    }

    private void RamButton_Click(object sender, EventArgs e)
    {
        _ram = new Ram(_sender);
        LoadForm(_ram);
    }

    private void WorkstationsButton_Click(object sender, EventArgs e)
    {
        _workstation = new Workstations(_sender, _serviceScopeFactory);
        LoadForm(_workstation);
    }

    private bool _isExpand;
    private async void SelectWorkstationButton_Click(object sender, EventArgs e)
    {
        if (_isExpand is false)
        {
            var workstations = await _sender.Send(new GetWorkstationCommand());
            foreach (var workstation in workstations)
            {
                var control = new ComputerDropdownControl(workstation.ClientId);
                control.SetItemName(workstation.Name);
                DropdownContainer.Controls.Add(control);
            }
            DropdownContainer.MaximumSize = new Size(279, 47 * workstations.Count());
            DropdownContainer.Height = 47 * workstations.Count();
            _isExpand = true;
        }
        else
        {
            DropdownContainer.Height = 47;

            _isExpand = false;

        }

    }

    private void RefreshWorkstationState_Tick(object sender, EventArgs e)
    {
        if (!ComputerDropdownControl.IsSelected)
            return;

        var controlsToRemove = DropdownContainer.Controls
            .Cast<ComputerDropdownControl>()
            .Where(c => c.ClientId != ComputerDropdownControl.SelectedClientId)
            .ToList();
        foreach (var ctrl in controlsToRemove)
        {
            DropdownContainer.Controls.Remove(ctrl);
        }
        ComputerDropdownControl.IsSelected = false;
        SelectedWorkstation.SelectedWorkstationId = ComputerDropdownControl.SelectedClientId;
        DropdownContainer.Height = 47;
    }

    private void AlertsButton_Click(object sender, EventArgs e)
    {
        _alert = new Alerts(_sender);
        LoadForm(_alert);
    }
}
