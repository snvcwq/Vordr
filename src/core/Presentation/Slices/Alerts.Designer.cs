namespace Presentation.Slices;

partial class Alerts
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        AlertsFlowChart = new FlowLayoutPanel();
        SuspendLayout();
        // 
        // AlertsFlowChart
        // 
        AlertsFlowChart.AutoScroll = true;
        AlertsFlowChart.Location = new Point(144, 12);
        AlertsFlowChart.Name = "AlertsFlowChart";
        AlertsFlowChart.Size = new Size(1133, 682);
        AlertsFlowChart.TabIndex = 0;
        // 
        // Alerts
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(1258, 692);
        Controls.Add(AlertsFlowChart);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Alerts";
        Text = "Alerts";
        ResumeLayout(false);
    }

    #endregion

    private FlowLayoutPanel AlertsFlowChart;
}