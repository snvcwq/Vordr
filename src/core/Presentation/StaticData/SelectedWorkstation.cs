using Vordr.Application.Common.Extensions;
using Vordr.Application.StaticData;

namespace Presentation.StaticData;

public static class SelectedWorkstation
{
    public static string SelectedWorkstationId
    {
        get
        {
            return ApplicationSelectedWorkstation.SelectedWorkstationId;
        }
        set
        {
            ApplicationSelectedWorkstation.SelectedWorkstationId = value;
        }
    }

    public static string GetSelectedWorkstationId()
    {
        if(SelectedWorkstationId.IsNullOrWhiteSpace())
        {
            MessageBox.Show("Please select a workstation.", "Error", MessageBoxButtons.OK);
            return null;
        }
        else
            return SelectedWorkstationId;
    }
}
