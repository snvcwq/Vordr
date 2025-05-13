using Vordr.Application.Models.Hardware;

namespace Vordr.Application.StaticData;

public static class DashboardInformation
{
    public static event Action<HardwareReport>? OnUpdated;

    public static HardwareReport LatestData { get; private set; } = new();

    public static void UpdateData(HardwareReport newData, string clientId)
    {
        if(ApplicationSelectedWorkstation.SelectedWorkstationId != clientId)
            return;
        LatestData = newData;
        OnUpdated?.Invoke(newData);
    }
}
