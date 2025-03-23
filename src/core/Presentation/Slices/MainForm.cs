using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.InteropServices;
using Vordr.Application.HardwareComponent.Queries;
using Vordr.Application.HardwareComponent.Queries.RetrieveAsync;
using Vordr.Domain.Entities;

namespace Presentation.Slices;

public partial class MainForm : Form
{
    private readonly IServiceProvider _serviceProvider;
    private readonly ISender _sender;
    private HardwareComponents _hardwareComponents;
    public MainForm(IServiceProvider serviceProvider, ISender sender)
    {
        _sender = sender;
        this._serviceProvider = serviceProvider;
        InitializeComponent();
    }
    
    override async protected void OnLoad(EventArgs e)
    {
        
        _hardwareComponents = await _sender.Send(new RetrieveHardwareComponentQueryAsync());

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

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void cartesianChart1_Load(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void RamChart_Load(object sender, EventArgs e)
    {

    }

    private void DashboardButton_Click(object sender, EventArgs e)
    {

    }

    private void DashboardButton_Click_1(object sender, EventArgs e)
    {
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void panel3_Paint(object sender, PaintEventArgs e)
    {

    }

    private void cuiChartLine1_Load(object sender, EventArgs e)
    {

    }

    private void cuiBorder1_Paint(object sender, PaintEventArgs e)
    {
    }

    private void cuiBorder1_Paint_1(object sender, PaintEventArgs e)
    {
    }

    private void button7_Click(object sender, EventArgs e)
    {

    }

    private void cuiButtonGroup1_Click(object sender, EventArgs e)
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
        LoadForm(new Dashboard());
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
        LoadForm(new Monitoring());
    }

    private void ProcessButton_Click(object sender, EventArgs e)
    {
        LoadForm(new Processes());
    }

    private void DrivesButton_Click(object sender, EventArgs e)
    {
        LoadForm(new Drives(_hardwareComponents.Drives, _sender));

    }

    private void BatteryButton_Click(object sender, EventArgs e)
    {
        LoadForm(new Battery(_sender, _hardwareComponents.Battery));

    }

    private void CpuButton_Click(object sender, EventArgs e)
    {
        LoadForm(new Cpu(_hardwareComponents.Cpu, _sender));

    }

    private void GpuButton_Click(object sender, EventArgs e)
    {
        LoadForm(new Gpu(_hardwareComponents.Gpu.ToArray(), _sender));

    }

    private void RamButton_Click(object sender, EventArgs e)
    {
        LoadForm(new Ram(_sender));

    }
}
