namespace Presentation.Slices;

partial class Dashboard
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
        cuiCircleKnob3 = new CuoreUI.Controls.cuiCircleKnob();
        cuiLabel4 = new CuoreUI.Controls.cuiLabel();
        cuiBorder4 = new CuoreUI.Controls.cuiBorder();
        cuiBorder1 = new CuoreUI.Controls.cuiBorder();
        cuiLabel1 = new CuoreUI.Controls.cuiLabel();
        cuiCircleKnob1 = new CuoreUI.Controls.cuiCircleKnob();
        cuiBorder2 = new CuoreUI.Controls.cuiBorder();
        cuiLabel3 = new CuoreUI.Controls.cuiLabel();
        cuiProgressBarVertical2 = new CuoreUI.Controls.cuiProgressBarVertical();
        cuiLabel7 = new CuoreUI.Controls.cuiLabel();
        cuiProgressBarVertical1 = new CuoreUI.Controls.cuiProgressBarVertical();
        cuiLabel2 = new CuoreUI.Controls.cuiLabel();
        cuiBorder3 = new CuoreUI.Controls.cuiBorder();
        DiskCPie = new CuoreUI.Controls.Charts.cuiChartPie();
        cuiLabel5 = new CuoreUI.Controls.cuiLabel();
        cuiBorder5 = new CuoreUI.Controls.cuiBorder();
        DiskDPie = new CuoreUI.Controls.Charts.cuiChartPie();
        cuiLabel6 = new CuoreUI.Controls.cuiLabel();
        cuiBorder4.SuspendLayout();
        cuiBorder1.SuspendLayout();
        cuiBorder2.SuspendLayout();
        cuiBorder3.SuspendLayout();
        cuiBorder5.SuspendLayout();
        SuspendLayout();
        // 
        // cuiCircleKnob3
        // 
        cuiCircleKnob3.BackColor = Color.Transparent;
        cuiCircleKnob3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiCircleKnob3.ForeColor = Color.Black;
        cuiCircleKnob3.KnobStyle = CuoreUI.Controls.cuiCircleKnob.KnobStyles.Arc;
        cuiCircleKnob3.Location = new Point(108, 64);
        cuiCircleKnob3.Margin = new Padding(8, 6, 8, 6);
        cuiCircleKnob3.MaxValue = 100F;
        cuiCircleKnob3.MinValue = 0F;
        cuiCircleKnob3.Name = "cuiCircleKnob3";
        cuiCircleKnob3.RightToLeft = RightToLeft.No;
        cuiCircleKnob3.ShowValueText = true;
        cuiCircleKnob3.Size = new Size(162, 162);
        cuiCircleKnob3.TabIndex = 0;
        cuiCircleKnob3.ThumbColor = Color.FromArgb(108, 124, 204);
        cuiCircleKnob3.TrackColor = Color.White;
        cuiCircleKnob3.TrackThickness = 10;
        cuiCircleKnob3.Value = 60F;
        // 
        // cuiLabel4
        // 
        cuiLabel4.BackColor = Color.Transparent;
        cuiLabel4.Content = "CPU\\ Usage:";
        cuiLabel4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel4.Location = new Point(4, 8);
        cuiLabel4.Margin = new Padding(4, 3, 4, 3);
        cuiLabel4.Name = "cuiLabel4";
        cuiLabel4.Size = new Size(153, 47);
        cuiLabel4.TabIndex = 1;
        // 
        // cuiBorder4
        // 
        cuiBorder4.Controls.Add(cuiLabel4);
        cuiBorder4.Controls.Add(cuiCircleKnob3);
        cuiBorder4.Location = new Point(26, 73);
        cuiBorder4.Name = "cuiBorder4";
        cuiBorder4.OutlineThickness = 0F;
        cuiBorder4.PanelColor = Color.White;
        cuiBorder4.PanelOutlineColor = Color.FromArgb(241, 244, 254);
        cuiBorder4.Rounding = new Padding(8);
        cuiBorder4.Size = new Size(270, 226);
        cuiBorder4.TabIndex = 3;
        // 
        // cuiBorder1
        // 
        cuiBorder1.Controls.Add(cuiLabel1);
        cuiBorder1.Controls.Add(cuiCircleKnob1);
        cuiBorder1.Location = new Point(349, 73);
        cuiBorder1.Name = "cuiBorder1";
        cuiBorder1.OutlineThickness = 0F;
        cuiBorder1.PanelColor = Color.White;
        cuiBorder1.PanelOutlineColor = Color.FromArgb(241, 244, 254);
        cuiBorder1.Rounding = new Padding(8);
        cuiBorder1.Size = new Size(270, 226);
        cuiBorder1.TabIndex = 4;
        // 
        // cuiLabel1
        // 
        cuiLabel1.BackColor = Color.Transparent;
        cuiLabel1.Content = "Gpu\\ Usage:";
        cuiLabel1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel1.Location = new Point(4, 8);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(153, 47);
        cuiLabel1.TabIndex = 1;
        // 
        // cuiCircleKnob1
        // 
        cuiCircleKnob1.BackColor = Color.Transparent;
        cuiCircleKnob1.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiCircleKnob1.ForeColor = Color.Black;
        cuiCircleKnob1.KnobStyle = CuoreUI.Controls.cuiCircleKnob.KnobStyles.Arc;
        cuiCircleKnob1.Location = new Point(108, 64);
        cuiCircleKnob1.Margin = new Padding(8, 6, 8, 6);
        cuiCircleKnob1.MaxValue = 100F;
        cuiCircleKnob1.MinValue = 0F;
        cuiCircleKnob1.Name = "cuiCircleKnob1";
        cuiCircleKnob1.RightToLeft = RightToLeft.No;
        cuiCircleKnob1.ShowValueText = true;
        cuiCircleKnob1.Size = new Size(162, 162);
        cuiCircleKnob1.TabIndex = 0;
        cuiCircleKnob1.ThumbColor = Color.FromArgb(108, 124, 204);
        cuiCircleKnob1.TrackColor = Color.White;
        cuiCircleKnob1.TrackThickness = 10;
        cuiCircleKnob1.Value = 60F;
        // 
        // cuiBorder2
        // 
        cuiBorder2.Controls.Add(cuiLabel3);
        cuiBorder2.Controls.Add(cuiProgressBarVertical2);
        cuiBorder2.Controls.Add(cuiLabel7);
        cuiBorder2.Controls.Add(cuiProgressBarVertical1);
        cuiBorder2.Controls.Add(cuiLabel2);
        cuiBorder2.Location = new Point(664, 73);
        cuiBorder2.Name = "cuiBorder2";
        cuiBorder2.OutlineThickness = 0F;
        cuiBorder2.PanelColor = Color.White;
        cuiBorder2.PanelOutlineColor = Color.FromArgb(241, 244, 254);
        cuiBorder2.Rounding = new Padding(8);
        cuiBorder2.Size = new Size(196, 304);
        cuiBorder2.TabIndex = 5;
        // 
        // cuiLabel3
        // 
        cuiLabel3.BackColor = Color.Transparent;
        cuiLabel3.Content = "GPU";
        cuiLabel3.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel3.Location = new Point(114, 238);
        cuiLabel3.Margin = new Padding(4, 3, 4, 3);
        cuiLabel3.Name = "cuiLabel3";
        cuiLabel3.Size = new Size(45, 23);
        cuiLabel3.TabIndex = 13;
        // 
        // cuiProgressBarVertical2
        // 
        cuiProgressBarVertical2.Background = Color.FromArgb(108, 124, 204);
        cuiProgressBarVertical2.Flipped = false;
        cuiProgressBarVertical2.Foreground = Color.White;
        cuiProgressBarVertical2.Location = new Point(128, 48);
        cuiProgressBarVertical2.MaxValue = 100;
        cuiProgressBarVertical2.Name = "cuiProgressBarVertical2";
        cuiProgressBarVertical2.Rounding = 8;
        cuiProgressBarVertical2.Size = new Size(16, 184);
        cuiProgressBarVertical2.TabIndex = 12;
        cuiProgressBarVertical2.Value = 50;
        // 
        // cuiLabel7
        // 
        cuiLabel7.BackColor = Color.Transparent;
        cuiLabel7.Content = "CPU";
        cuiLabel7.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel7.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel7.Location = new Point(42, 238);
        cuiLabel7.Margin = new Padding(4, 3, 4, 3);
        cuiLabel7.Name = "cuiLabel7";
        cuiLabel7.Size = new Size(45, 23);
        cuiLabel7.TabIndex = 11;
        cuiLabel7.Load += cuiLabel7_Load;
        // 
        // cuiProgressBarVertical1
        // 
        cuiProgressBarVertical1.Background = Color.FromArgb(108, 124, 204);
        cuiProgressBarVertical1.Flipped = false;
        cuiProgressBarVertical1.Foreground = Color.White;
        cuiProgressBarVertical1.Location = new Point(56, 48);
        cuiProgressBarVertical1.MaxValue = 100;
        cuiProgressBarVertical1.Name = "cuiProgressBarVertical1";
        cuiProgressBarVertical1.Rounding = 8;
        cuiProgressBarVertical1.Size = new Size(16, 184);
        cuiProgressBarVertical1.TabIndex = 3;
        cuiProgressBarVertical1.Value = 50;
        // 
        // cuiLabel2
        // 
        cuiLabel2.BackColor = Color.Transparent;
        cuiLabel2.Content = "Temperature";
        cuiLabel2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel2.Location = new Point(4, 8);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(172, 47);
        cuiLabel2.TabIndex = 1;
        // 
        // cuiBorder3
        // 
        cuiBorder3.Controls.Add(DiskCPie);
        cuiBorder3.Controls.Add(cuiLabel5);
        cuiBorder3.Location = new Point(26, 339);
        cuiBorder3.Name = "cuiBorder3";
        cuiBorder3.OutlineThickness = 0F;
        cuiBorder3.PanelColor = Color.White;
        cuiBorder3.PanelOutlineColor = Color.FromArgb(241, 244, 254);
        cuiBorder3.Rounding = new Padding(8);
        cuiBorder3.Size = new Size(270, 226);
        cuiBorder3.TabIndex = 4;
        // 
        // DiskCPie
        // 
        DiskCPie.BackColor = Color.White;
        DiskCPie.ChartBorderColor = Color.FromArgb(108, 124, 204);
        DiskCPie.ChartBorderThickness = 1.6F;
        DiskCPie.ChartPadding = 30;
        DiskCPie.DataPoints = new string[]
{
    "data1_100",
    "data2_90",
    "data3_50",
    "data4_50",
    "data5_300"
};
        DiskCPie.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        DiskCPie.ForeColor = Color.FromArgb(108, 124, 204);
        DiskCPie.Location = new Point(89, 48);
        DiskCPie.Margin = new Padding(5, 4, 5, 4);
        DiskCPie.MinimumSize = new Size(154, 152);
        DiskCPie.Name = "DiskCPie";
        DiskCPie.SegmentBorderColor = Color.Black;
        DiskCPie.SegmentColor = Color.Green;
        DiskCPie.ShowPopup = true;
        DiskCPie.Size = new Size(181, 178);
        DiskCPie.SliceBorderColor = Color.FromArgb(108, 124, 204);
        DiskCPie.SliceBorderThickness = 1F;
        DiskCPie.TabIndex = 3;
        // 
        // cuiLabel5
        // 
        cuiLabel5.BackColor = Color.Transparent;
        cuiLabel5.Content = "Disk\\ C:";
        cuiLabel5.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel5.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel5.Location = new Point(4, 8);
        cuiLabel5.Margin = new Padding(4, 3, 4, 3);
        cuiLabel5.Name = "cuiLabel5";
        cuiLabel5.Size = new Size(153, 47);
        cuiLabel5.TabIndex = 1;
        // 
        // cuiBorder5
        // 
        cuiBorder5.Controls.Add(DiskDPie);
        cuiBorder5.Controls.Add(cuiLabel6);
        cuiBorder5.Location = new Point(353, 339);
        cuiBorder5.Name = "cuiBorder5";
        cuiBorder5.OutlineThickness = 0F;
        cuiBorder5.PanelColor = Color.White;
        cuiBorder5.PanelOutlineColor = Color.FromArgb(241, 244, 254);
        cuiBorder5.Rounding = new Padding(8);
        cuiBorder5.Size = new Size(270, 226);
        cuiBorder5.TabIndex = 4;
        // 
        // DiskDPie
        // 
        DiskDPie.BackColor = Color.White;
        DiskDPie.ChartBorderColor = Color.FromArgb(108, 124, 204);
        DiskDPie.ChartBorderThickness = 1.6F;
        DiskDPie.ChartPadding = 30;
        DiskDPie.DataPoints = new string[]
{
    "data1_100",
    "data2_90",
    "data3_50",
    "data4_50",
    "data5_300"
};
        DiskDPie.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        DiskDPie.ForeColor = Color.FromArgb(108, 124, 204);
        DiskDPie.Location = new Point(85, 44);
        DiskDPie.Margin = new Padding(5, 4, 5, 4);
        DiskDPie.MinimumSize = new Size(154, 152);
        DiskDPie.Name = "DiskDPie";
        DiskDPie.SegmentBorderColor = Color.Black;
        DiskDPie.SegmentColor = Color.Green;
        DiskDPie.ShowPopup = true;
        DiskDPie.Size = new Size(181, 178);
        DiskDPie.SliceBorderColor = Color.FromArgb(108, 124, 204);
        DiskDPie.SliceBorderThickness = 1F;
        DiskDPie.TabIndex = 2;
        // 
        // cuiLabel6
        // 
        cuiLabel6.BackColor = Color.Transparent;
        cuiLabel6.Content = "Disk\\ D:";
        cuiLabel6.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel6.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel6.Location = new Point(4, 8);
        cuiLabel6.Margin = new Padding(4, 3, 4, 3);
        cuiLabel6.Name = "cuiLabel6";
        cuiLabel6.Size = new Size(153, 47);
        cuiLabel6.TabIndex = 1;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(1227, 692);
        Controls.Add(cuiBorder5);
        Controls.Add(cuiBorder3);
        Controls.Add(cuiBorder2);
        Controls.Add(cuiBorder1);
        Controls.Add(cuiBorder4);
        Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "Dashboard";
        Text = "Dashboard";
        cuiBorder4.ResumeLayout(false);
        cuiBorder1.ResumeLayout(false);
        cuiBorder2.ResumeLayout(false);
        cuiBorder3.ResumeLayout(false);
        cuiBorder5.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private CuoreUI.Controls.cuiCircleKnob cuiCircleKnob3;
    private CuoreUI.Controls.cuiLabel cuiLabel4;
    private CuoreUI.Controls.cuiBorder cuiBorder4;
    private CuoreUI.Controls.cuiBorder cuiBorder1;
    private CuoreUI.Controls.cuiLabel cuiLabel1;
    private CuoreUI.Controls.cuiCircleKnob cuiCircleKnob1;
    private CuoreUI.Controls.cuiBorder cuiBorder2;
    private CuoreUI.Controls.cuiLabel cuiLabel2;
    private CuoreUI.Controls.cuiProgressBarVertical cuiProgressBarVertical1;
    private CuoreUI.Controls.cuiLabel cuiLabel7;
    private CuoreUI.Controls.cuiLabel cuiLabel3;
    private CuoreUI.Controls.cuiProgressBarVertical cuiProgressBarVertical2;
    private CuoreUI.Controls.cuiBorder cuiBorder3;
    private CuoreUI.Controls.cuiLabel cuiLabel5;
    private CuoreUI.Controls.cuiBorder cuiBorder5;
    private CuoreUI.Controls.cuiLabel cuiLabel6;
    public CuoreUI.Controls.Charts.cuiChartPie DiskCPie;
    public CuoreUI.Controls.Charts.cuiChartPie DiskDPie;
}