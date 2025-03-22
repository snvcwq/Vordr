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
public partial class Drives : Form
{
    public Drives()
    {
        InitializeComponent();
        DriveCChart.DataPoints = [66, 68, 70, 90, 60, 44, 35, 22, 11];
        DriveDChart.DataPoints = [80,90,50,67,24,2,4,51];

    }

    private void cuiCheckbox1_Click(object sender, EventArgs e)
    {
        if (ShortTermCheckbox.Checked) 
        { 
            StartDateLabel.Visible = false;
            StartDate.Visible = false;
            EndDateLabel.Visible = false;
            EndDate.Visible = false;
            StartDateLabel.Enabled = false;
            StartDate.Enabled = false;
            EndDateLabel.Enabled = false;
            EndDate.Enabled = false;
            StartHour.Visible = true;
            EndHour.Visible = true;
            StartHourLabel.Visible = true;
            EndHourLabel.Visible = true;
            StartHour.Enabled = true;
            EndHour.Enabled = true;
            StartHourLabel.Enabled = true;
            EndHourLabel.Enabled = true;
        }
        else
        {
            StartDateLabel.Visible = true;
            StartDate.Visible = true;
            EndDateLabel.Visible = true;
            EndDate.Visible = true;
            StartHour.Visible = false;
            EndHour.Visible = false;
            StartHourLabel.Visible = false;
            EndHourLabel.Visible = false;
            StartHour.Enabled = false;
            EndHour.Enabled = false;
            StartHourLabel.Enabled = false;
            EndHourLabel.Enabled = false;
            StartDateLabel.Enabled = true;
            StartDate.Enabled = true;
            EndDateLabel.Enabled = true;
            EndDate.Enabled = true;
        }
    }
}
