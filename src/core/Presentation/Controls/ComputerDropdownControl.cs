using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Controls;
public partial class ComputerDropdownControl : UserControl
{
    public ComputerDropdownControl(string clientId)
    {
        ClientId = clientId;
        InitializeComponent();
    }

    public static bool IsSelected = false;
    public static string ValueSelected;
    public string ClientId;
    public static  string SelectedClientId;

    public void SetItemName(string itemName)
    {
        WorkstationName.Content = itemName;
    }

    private void WorkstationName_Click(object sender, EventArgs e)
    {
        IsSelected = true;
        ValueSelected = WorkstationName.Content;
        SelectedClientId = ClientId;
    }
}
