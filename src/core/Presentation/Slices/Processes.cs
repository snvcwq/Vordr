using Presentation.Models;

namespace Presentation.Slices;
public partial class Processes : Form
{
    public Processes()
    {
        InitializeComponent();
        AddProcesses();
    }
    private void AddProcesses()
    {
        var processes = new List<ProcessModel>();
        // Add some initial data
        processes.Add(GetProcess1());
        processes.Add(GetProcess2());
        processes.Add(GetProcess1());
        processes.Add(GetProcess2());
        processes.Add(GetProcess1());
        processes.Add(GetProcess2());
        processes.Add(GetProcess1());
        processes.Add(GetProcess2());
        processes.Add(GetProcess1());
        processes.Add(GetProcess2());
        processes.Add(GetProcess1());
        processes.Add(GetProcess2());
        processes.Add(GetProcess1());
        processes.Add(GetProcess2());
        processes.Add(GetProcess1());
        processes.Add(GetProcess2());
        // Set the data source for the BindingSource
        ProcessesGrid2.DataSource = processes;

        // Bind controls to properties*/
    }

    private ProcessModel GetProcess1() =>
        new()
        {
            Pid = 9272,
            Name = "Telegram",
            StartTime = default,
            //Icon = new byte[]
            //{
            //},
            Path = "D:\\Telegram\\Telegram.exe",
            Priority = 32,
            Manufacturer = "Telegram FZ-LLC",
            Version = "5.12.3.0",
            Architecture = "x64",
            CpuUsage = 0,
            RamUsage = 36.7,
            ThreadCount = 90,
            HandleCount = 1497
        };
    private ProcessModel GetProcess2() =>
        new()
        {
            Pid = 22652,
            Name = "FACEIT",
            StartTime = default,
            Icon = new byte[]
            {
            },
            Path = "C:\\Users\\user\\AppData\\Local\\FACEIT\\app-2.0.42\\FACEIT.exe",
            Priority = 32,
            Manufacturer = "FACEIT Ltd.",
            Version = "2.0.42",
            Architecture = "x64",
            CpuUsage = 0.09,
            RamUsage = 326,
            ThreadCount = 239,
            HandleCount = 4776
        };
}
