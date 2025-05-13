using Vordr.Application.Models.Process;

namespace Vordr.Application.StaticData;

public class StaticProcesses
{
    public static event Action<List<ProcessInformation>>? OnUpdated;

    public static List<ProcessInformation> LatestData { get; private set; } = new();

    public static void UpdateData(List<ProcessInformation> newData, string clientId)
    {
        if(ApplicationSelectedWorkstation.SelectedWorkstationId != clientId)
            return;
        LatestData = newData;
        OnUpdated?.Invoke(newData);
    }
}
