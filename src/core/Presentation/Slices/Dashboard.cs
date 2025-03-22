using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation.Slices;
public partial class Dashboard : Form
{
    public Dashboard()
    {
        InitializeComponent();
        DiskDPie.ChartPadding = 2;
        DiskCPie.ChartPadding = 2;
        DiskCPie.DataPoints = ["ocuppied_60", "free_140"];
        DiskDPie.DataPoints = ["ocuppied_90", "free_110"];
    }

    private void cuiLabel7_Load(object sender, EventArgs e)
    {

    }
}
