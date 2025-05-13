using Presentation.Models;
using Vordr.Application.Models.Process;
using Vordr.Application.StaticData;

namespace Presentation.Slices;
public partial class Processes : Form
{

    private ProcessModel[] _processes = [];
    public Processes()
    {
        InitializeComponent();
        ProcessesTable.DataSource = _processes;
        StaticProcesses.OnUpdated += HandleProcesses;

    }

    public async void HandleProcesses(List<ProcessInformation> processes)
    {
        // Update the UI thread with the list of processes
        // Make sure the UI update happens on the main thread using Invoke
        if (InvokeRequired)
        {
            // If the method is being called from a non-UI thread, invoke it on the UI thread
            await InvokeAsync(() => HandleProcesses(processes));
            return;
        }

        SetProcesses(processes);

    }

    private void SetProcesses(IEnumerable<ProcessInformation> processList)
    {
        var processes = processList.Select(p => new ProcessModel
        {
            Pid = p.Pid,
            Icon = p.Icon,
            Name = p.Name,
            StartTime = p.StartTime,
            Path = p.Path,
            Priority = p.Priority,
            Manufacturer = p.Company,
            Version = p.Version,
            Architecture = p.Architecture,
            Cpu = p.CpuUsage,
            Ram = p.RamUsage,
            Threads = p.ThreadCount,
            Handles = p.HandleCount,
            System = p.IsSystemProcess
        }).ToList();
        if (!SystemProcessSwitch.Checked)
            processes.RemoveAll(p => p.System);
        if (!NonSystemProcessSwitch.Checked)
            processes.RemoveAll(p => !p.System);

        _processes = processes.ToArray();
        ProcessesTable.DataSource = null;
        ProcessesTable.DataSource = _processes;
    }

    private void Processes_Load(object sender, EventArgs e)
    {

    }
}
