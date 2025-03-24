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
        cuiProgressBarVertical2 = new CuoreUI.Controls.cuiProgressBarVertical();
        DiskCPie = new CuoreUI.Controls.Charts.cuiChartPie();
        cuiLabel13 = new CuoreUI.Controls.cuiLabel();
        cuiLabel8 = new CuoreUI.Controls.cuiLabel();
        cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
        GpuLoadTrack = new CuoreUI.Controls.cuiCircleKnob();
        cuiBorder7 = new CuoreUI.Controls.cuiBorder();
        cuiLabel10 = new CuoreUI.Controls.cuiLabel();
        CpuLoadTrack = new CuoreUI.Controls.cuiCircleKnob();
        cuiLabel5 = new CuoreUI.Controls.cuiLabel();
        cuiLabel6 = new CuoreUI.Controls.cuiLabel();
        cuiLabel9 = new CuoreUI.Controls.cuiLabel();
        cuiBorder8 = new CuoreUI.Controls.cuiBorder();
        BatteryPanel = new CuoreUI.Controls.cuiBorder();
        DegradationLevelValue = new CuoreUI.Controls.cuiLabel();
        ChargeLevelValue = new CuoreUI.Controls.cuiLabel();
        cuiLabel4 = new CuoreUI.Controls.cuiLabel();
        DegradationLevelBar = new CuoreUI.Controls.cuiProgressBarHorizontal();
        cuiLabel2 = new CuoreUI.Controls.cuiLabel();
        cuiLabel3 = new CuoreUI.Controls.cuiLabel();
        cuiLabel1 = new CuoreUI.Controls.cuiLabel();
        ChargeLevelBar = new CuoreUI.Controls.cuiProgressBarHorizontal();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        cuiBorder1 = new CuoreUI.Controls.cuiBorder();
        cuiBorder2 = new CuoreUI.Controls.cuiBorder();
        GpuTemperature = new CuoreUI.Controls.cuiLabel();
        CpuTemperature = new CuoreUI.Controls.cuiLabel();
        cuiLabel12 = new CuoreUI.Controls.cuiLabel();
        CpuTemperatureTrack = new CuoreUI.Controls.cuiProgressBarVertical();
        cuiLabel14 = new CuoreUI.Controls.cuiLabel();
        cuiLabel11 = new CuoreUI.Controls.cuiLabel();
        GpuTemperatureTrack = new CuoreUI.Controls.cuiProgressBarVertical();
        cuiLabel7 = new CuoreUI.Controls.cuiLabel();
        cuiBorder3 = new CuoreUI.Controls.cuiBorder();
        CDrive = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
        cuiLabel19 = new CuoreUI.Controls.cuiLabel();
        cuiLabel20 = new CuoreUI.Controls.cuiLabel();
        cuiBorder4 = new CuoreUI.Controls.cuiBorder();
        DDrive = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
        cuiLabel15 = new CuoreUI.Controls.cuiLabel();
        cuiLabel16 = new CuoreUI.Controls.cuiLabel();
        cuiBorder7.SuspendLayout();
        BatteryPanel.SuspendLayout();
        cuiBorder1.SuspendLayout();
        cuiBorder2.SuspendLayout();
        cuiBorder3.SuspendLayout();
        cuiBorder4.SuspendLayout();
        SuspendLayout();
        // 
        // cuiProgressBarVertical2
        // 
        cuiProgressBarVertical2.Background = Color.FromArgb(108, 124, 204);
        cuiProgressBarVertical2.Flipped = true;
        cuiProgressBarVertical2.Foreground = Color.White;
        cuiProgressBarVertical2.Location = new Point(269, 51);
        cuiProgressBarVertical2.MaxValue = 100;
        cuiProgressBarVertical2.Name = "cuiProgressBarVertical2";
        cuiProgressBarVertical2.Rounding = 8;
        cuiProgressBarVertical2.Size = new Size(15, 112);
        cuiProgressBarVertical2.TabIndex = 12;
        cuiProgressBarVertical2.Value = 50;
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
        DiskCPie.Location = new Point(31, 11);
        DiskCPie.Margin = new Padding(5, 4, 5, 4);
        DiskCPie.MinimumSize = new Size(154, 152);
        DiskCPie.Name = "DiskCPie";
        DiskCPie.SegmentBorderColor = Color.Black;
        DiskCPie.SegmentColor = Color.Green;
        DiskCPie.ShowPopup = true;
        DiskCPie.Size = new Size(154, 152);
        DiskCPie.SliceBorderColor = Color.FromArgb(108, 124, 204);
        DiskCPie.SliceBorderThickness = 1F;
        DiskCPie.TabIndex = 3;
        // 
        // cuiLabel13
        // 
        cuiLabel13.BackColor = Color.Transparent;
        cuiLabel13.Content = "Live\\ Dasboard";
        cuiLabel13.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel13.ForeColor = Color.Black;
        cuiLabel13.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel13.Location = new Point(13, 12);
        cuiLabel13.Margin = new Padding(4, 3, 4, 3);
        cuiLabel13.Name = "cuiLabel13";
        cuiLabel13.Size = new Size(219, 44);
        cuiLabel13.TabIndex = 16;
        cuiLabel13.Load += cuiLabel13_Load;
        // 
        // cuiLabel8
        // 
        cuiLabel8.BackColor = Color.Transparent;
        cuiLabel8.Content = "View\\ real\\ time\\ information\\ about\\ your\\ workstation";
        cuiLabel8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel8.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel8.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel8.Location = new Point(277, 14);
        cuiLabel8.Margin = new Padding(4, 3, 4, 3);
        cuiLabel8.Name = "cuiLabel8";
        cuiLabel8.Size = new Size(288, 42);
        cuiLabel8.TabIndex = 17;
        // 
        // cuiSeparator1
        // 
        cuiSeparator1.BackColor = Color.Transparent;
        cuiSeparator1.ForeColor = Color.FromArgb(40, 53, 147);
        cuiSeparator1.Location = new Point(-7, 51);
        cuiSeparator1.Margin = new Padding(5, 4, 5, 4);
        cuiSeparator1.Name = "cuiSeparator1";
        cuiSeparator1.SeparatorMargin = 8;
        cuiSeparator1.Size = new Size(592, 20);
        cuiSeparator1.TabIndex = 24;
        cuiSeparator1.Thickness = 1F;
        cuiSeparator1.Vertical = false;
        // 
        // GpuLoadTrack
        // 
        GpuLoadTrack.BackColor = Color.Transparent;
        GpuLoadTrack.Enabled = false;
        GpuLoadTrack.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GpuLoadTrack.ForeColor = Color.FromArgb(108, 124, 204);
        GpuLoadTrack.KnobStyle = CuoreUI.Controls.cuiCircleKnob.KnobStyles.Arc;
        GpuLoadTrack.Location = new Point(193, 95);
        GpuLoadTrack.Margin = new Padding(8, 6, 8, 6);
        GpuLoadTrack.MaxValue = 100F;
        GpuLoadTrack.MinValue = 0F;
        GpuLoadTrack.Name = "GpuLoadTrack";
        GpuLoadTrack.RightToLeft = RightToLeft.No;
        GpuLoadTrack.ShowValueText = true;
        GpuLoadTrack.Size = new Size(187, 187);
        GpuLoadTrack.TabIndex = 0;
        GpuLoadTrack.ThumbColor = Color.FromArgb(108, 124, 204);
        GpuLoadTrack.TrackColor = Color.White;
        GpuLoadTrack.TrackThickness = 20;
        GpuLoadTrack.Value = 60F;
        // 
        // cuiBorder7
        // 
        cuiBorder7.Controls.Add(cuiLabel10);
        cuiBorder7.Controls.Add(CpuLoadTrack);
        cuiBorder7.Controls.Add(cuiLabel5);
        cuiBorder7.Controls.Add(cuiLabel6);
        cuiBorder7.Controls.Add(cuiLabel9);
        cuiBorder7.Controls.Add(GpuLoadTrack);
        cuiBorder7.Location = new Point(826, 78);
        cuiBorder7.Name = "cuiBorder7";
        cuiBorder7.OutlineThickness = 1F;
        cuiBorder7.PanelColor = Color.White;
        cuiBorder7.PanelOutlineColor = Color.White;
        cuiBorder7.Rounding = new Padding(12);
        cuiBorder7.Size = new Size(380, 362);
        cuiBorder7.TabIndex = 26;
        // 
        // cuiLabel10
        // 
        cuiLabel10.BackColor = Color.Transparent;
        cuiLabel10.Content = "GPU\\(%\\)";
        cuiLabel10.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel10.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel10.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel10.Location = new Point(255, 291);
        cuiLabel10.Margin = new Padding(4, 3, 4, 3);
        cuiLabel10.Name = "cuiLabel10";
        cuiLabel10.Size = new Size(89, 22);
        cuiLabel10.TabIndex = 42;
        // 
        // CpuLoadTrack
        // 
        CpuLoadTrack.BackColor = Color.Transparent;
        CpuLoadTrack.Enabled = false;
        CpuLoadTrack.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        CpuLoadTrack.ForeColor = Color.FromArgb(108, 124, 204);
        CpuLoadTrack.KnobStyle = CuoreUI.Controls.cuiCircleKnob.KnobStyles.Arc;
        CpuLoadTrack.Location = new Point(0, 95);
        CpuLoadTrack.Margin = new Padding(8, 6, 8, 6);
        CpuLoadTrack.MaxValue = 100F;
        CpuLoadTrack.MinValue = 0F;
        CpuLoadTrack.Name = "CpuLoadTrack";
        CpuLoadTrack.RightToLeft = RightToLeft.No;
        CpuLoadTrack.ShowValueText = true;
        CpuLoadTrack.Size = new Size(187, 187);
        CpuLoadTrack.TabIndex = 41;
        CpuLoadTrack.ThumbColor = Color.FromArgb(108, 124, 204);
        CpuLoadTrack.TrackColor = Color.White;
        CpuLoadTrack.TrackThickness = 20;
        CpuLoadTrack.Value = 80F;
        // 
        // cuiLabel5
        // 
        cuiLabel5.BackColor = Color.Transparent;
        cuiLabel5.BackgroundImage = Resources.speedometer;
        cuiLabel5.Content = "";
        cuiLabel5.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel5.Location = new Point(21, 30);
        cuiLabel5.Margin = new Padding(4, 3, 4, 3);
        cuiLabel5.Name = "cuiLabel5";
        cuiLabel5.Size = new Size(31, 32);
        cuiLabel5.TabIndex = 38;
        // 
        // cuiLabel6
        // 
        cuiLabel6.BackColor = Color.Transparent;
        cuiLabel6.Content = "Load";
        cuiLabel6.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel6.ForeColor = Color.Black;
        cuiLabel6.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel6.Location = new Point(55, 34);
        cuiLabel6.Margin = new Padding(4, 3, 4, 3);
        cuiLabel6.Name = "cuiLabel6";
        cuiLabel6.Size = new Size(77, 34);
        cuiLabel6.TabIndex = 37;
        // 
        // cuiLabel9
        // 
        cuiLabel9.BackColor = Color.Transparent;
        cuiLabel9.Content = "CPU\\(%\\)";
        cuiLabel9.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel9.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel9.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel9.Location = new Point(55, 291);
        cuiLabel9.Margin = new Padding(4, 3, 4, 3);
        cuiLabel9.Name = "cuiLabel9";
        cuiLabel9.Size = new Size(89, 22);
        cuiLabel9.TabIndex = 40;
        // 
        // cuiBorder8
        // 
        cuiBorder8.Location = new Point(13, 246);
        cuiBorder8.Name = "cuiBorder8";
        cuiBorder8.OutlineThickness = 1F;
        cuiBorder8.PanelColor = Color.White;
        cuiBorder8.PanelOutlineColor = Color.White;
        cuiBorder8.Rounding = new Padding(12);
        cuiBorder8.Size = new Size(779, 194);
        cuiBorder8.TabIndex = 27;
        // 
        // BatteryPanel
        // 
        BatteryPanel.Controls.Add(DegradationLevelValue);
        BatteryPanel.Controls.Add(ChargeLevelValue);
        BatteryPanel.Controls.Add(cuiLabel4);
        BatteryPanel.Controls.Add(DegradationLevelBar);
        BatteryPanel.Controls.Add(cuiLabel2);
        BatteryPanel.Controls.Add(cuiLabel3);
        BatteryPanel.Controls.Add(cuiLabel1);
        BatteryPanel.Controls.Add(ChargeLevelBar);
        BatteryPanel.Location = new Point(13, 470);
        BatteryPanel.Name = "BatteryPanel";
        BatteryPanel.OutlineThickness = 1F;
        BatteryPanel.PanelColor = Color.White;
        BatteryPanel.PanelOutlineColor = Color.White;
        BatteryPanel.Rounding = new Padding(12);
        BatteryPanel.Size = new Size(374, 210);
        BatteryPanel.TabIndex = 27;
        // 
        // DegradationLevelValue
        // 
        DegradationLevelValue.BackColor = Color.Transparent;
        DegradationLevelValue.Content = "0";
        DegradationLevelValue.ForeColor = Color.FromArgb(108, 124, 204);
        DegradationLevelValue.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        DegradationLevelValue.Location = new Point(-1, 108);
        DegradationLevelValue.Margin = new Padding(4, 3, 4, 3);
        DegradationLevelValue.Name = "DegradationLevelValue";
        DegradationLevelValue.Size = new Size(43, 24);
        DegradationLevelValue.TabIndex = 36;
        // 
        // ChargeLevelValue
        // 
        ChargeLevelValue.BackColor = Color.Transparent;
        ChargeLevelValue.Content = "0";
        ChargeLevelValue.ForeColor = Color.FromArgb(108, 124, 204);
        ChargeLevelValue.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        ChargeLevelValue.Location = new Point(0, 169);
        ChargeLevelValue.Margin = new Padding(4, 3, 4, 3);
        ChargeLevelValue.Name = "ChargeLevelValue";
        ChargeLevelValue.Size = new Size(43, 24);
        ChargeLevelValue.TabIndex = 35;
        // 
        // cuiLabel4
        // 
        cuiLabel4.BackColor = Color.Transparent;
        cuiLabel4.Content = "Degradation\\ level\\(%\\):";
        cuiLabel4.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel4.Location = new Point(16, 78);
        cuiLabel4.Margin = new Padding(4, 3, 4, 3);
        cuiLabel4.Name = "cuiLabel4";
        cuiLabel4.Size = new Size(188, 24);
        cuiLabel4.TabIndex = 34;
        // 
        // DegradationLevelBar
        // 
        DegradationLevelBar.Background = Color.White;
        DegradationLevelBar.Flipped = false;
        DegradationLevelBar.Foreground = Color.FromArgb(108, 124, 204);
        DegradationLevelBar.Location = new Point(45, 108);
        DegradationLevelBar.MaxValue = 100;
        DegradationLevelBar.Name = "DegradationLevelBar";
        DegradationLevelBar.Rounding = 8;
        DegradationLevelBar.Size = new Size(326, 21);
        DegradationLevelBar.TabIndex = 32;
        DegradationLevelBar.Value = 50;
        // 
        // cuiLabel2
        // 
        cuiLabel2.BackColor = Color.Transparent;
        cuiLabel2.BackgroundImage = Resources.battery;
        cuiLabel2.Content = "";
        cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel2.Location = new Point(16, 18);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(31, 35);
        cuiLabel2.TabIndex = 31;
        // 
        // cuiLabel3
        // 
        cuiLabel3.BackColor = Color.Transparent;
        cuiLabel3.Content = "Charge\\ Level\\(%\\):";
        cuiLabel3.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel3.Location = new Point(16, 139);
        cuiLabel3.Margin = new Padding(4, 3, 4, 3);
        cuiLabel3.Name = "cuiLabel3";
        cuiLabel3.Size = new Size(156, 24);
        cuiLabel3.TabIndex = 33;
        // 
        // cuiLabel1
        // 
        cuiLabel1.BackColor = Color.Transparent;
        cuiLabel1.Content = "Battery";
        cuiLabel1.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel1.ForeColor = Color.Black;
        cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel1.Location = new Point(45, 26);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(77, 34);
        cuiLabel1.TabIndex = 30;
        cuiLabel1.Load += cuiLabel1_Load;
        // 
        // ChargeLevelBar
        // 
        ChargeLevelBar.Background = Color.White;
        ChargeLevelBar.Flipped = false;
        ChargeLevelBar.Foreground = Color.FromArgb(108, 124, 204);
        ChargeLevelBar.Location = new Point(45, 169);
        ChargeLevelBar.MaxValue = 100;
        ChargeLevelBar.Name = "ChargeLevelBar";
        ChargeLevelBar.Rounding = 8;
        ChargeLevelBar.Size = new Size(319, 21);
        ChargeLevelBar.TabIndex = 0;
        ChargeLevelBar.Value = 50;
        // 
        // tabPage1
        // 
        tabPage1.Location = new Point(4, 46);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(204, 84);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 46);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(204, 84);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // cuiBorder1
        // 
        cuiBorder1.Controls.Add(cuiProgressBarVertical2);
        cuiBorder1.Controls.Add(DiskCPie);
        cuiBorder1.Location = new Point(426, 470);
        cuiBorder1.Name = "cuiBorder1";
        cuiBorder1.OutlineThickness = 1F;
        cuiBorder1.PanelColor = Color.White;
        cuiBorder1.PanelOutlineColor = Color.White;
        cuiBorder1.Rounding = new Padding(12);
        cuiBorder1.Size = new Size(366, 210);
        cuiBorder1.TabIndex = 28;
        // 
        // cuiBorder2
        // 
        cuiBorder2.Controls.Add(GpuTemperature);
        cuiBorder2.Controls.Add(CpuTemperature);
        cuiBorder2.Controls.Add(cuiLabel12);
        cuiBorder2.Controls.Add(CpuTemperatureTrack);
        cuiBorder2.Controls.Add(cuiLabel14);
        cuiBorder2.Controls.Add(cuiLabel11);
        cuiBorder2.Controls.Add(GpuTemperatureTrack);
        cuiBorder2.Controls.Add(cuiLabel7);
        cuiBorder2.Location = new Point(826, 470);
        cuiBorder2.Name = "cuiBorder2";
        cuiBorder2.OutlineThickness = 1F;
        cuiBorder2.PanelColor = Color.White;
        cuiBorder2.PanelOutlineColor = Color.White;
        cuiBorder2.Rounding = new Padding(12);
        cuiBorder2.Size = new Size(380, 210);
        cuiBorder2.TabIndex = 29;
        // 
        // GpuTemperature
        // 
        GpuTemperature.BackColor = Color.Transparent;
        GpuTemperature.Content = "0";
        GpuTemperature.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GpuTemperature.ForeColor = Color.FromArgb(108, 124, 204);
        GpuTemperature.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        GpuTemperature.Location = new Point(222, 173);
        GpuTemperature.Margin = new Padding(4, 3, 4, 3);
        GpuTemperature.Name = "GpuTemperature";
        GpuTemperature.Size = new Size(42, 24);
        GpuTemperature.TabIndex = 45;
        // 
        // CpuTemperature
        // 
        CpuTemperature.BackColor = Color.Transparent;
        CpuTemperature.Content = "0";
        CpuTemperature.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        CpuTemperature.ForeColor = Color.FromArgb(108, 124, 204);
        CpuTemperature.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        CpuTemperature.Location = new Point(322, 174);
        CpuTemperature.Margin = new Padding(4, 3, 4, 3);
        CpuTemperature.Name = "CpuTemperature";
        CpuTemperature.Size = new Size(44, 24);
        CpuTemperature.TabIndex = 43;
        // 
        // cuiLabel12
        // 
        cuiLabel12.BackColor = Color.Transparent;
        cuiLabel12.BackgroundImage = Resources.speedometer;
        cuiLabel12.Content = "";
        cuiLabel12.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel12.Location = new Point(11, 18);
        cuiLabel12.Margin = new Padding(4, 3, 4, 3);
        cuiLabel12.Name = "cuiLabel12";
        cuiLabel12.Size = new Size(31, 32);
        cuiLabel12.TabIndex = 44;
        // 
        // CpuTemperatureTrack
        // 
        CpuTemperatureTrack.Background = Color.White;
        CpuTemperatureTrack.Flipped = true;
        CpuTemperatureTrack.Foreground = Color.FromArgb(108, 124, 204);
        CpuTemperatureTrack.Location = new Point(332, 12);
        CpuTemperatureTrack.MaxValue = 100;
        CpuTemperatureTrack.Name = "CpuTemperatureTrack";
        CpuTemperatureTrack.Rounding = 8;
        CpuTemperatureTrack.Size = new Size(22, 151);
        CpuTemperatureTrack.TabIndex = 38;
        CpuTemperatureTrack.Value = 50;
        // 
        // cuiLabel14
        // 
        cuiLabel14.BackColor = Color.Transparent;
        cuiLabel14.Content = "Temperature";
        cuiLabel14.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel14.ForeColor = Color.Black;
        cuiLabel14.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Right;
        cuiLabel14.Location = new Point(45, 20);
        cuiLabel14.Margin = new Padding(4, 3, 4, 3);
        cuiLabel14.Name = "cuiLabel14";
        cuiLabel14.Size = new Size(142, 33);
        cuiLabel14.TabIndex = 43;
        // 
        // cuiLabel11
        // 
        cuiLabel11.BackColor = Color.Transparent;
        cuiLabel11.Content = "CPU\\(°\\)";
        cuiLabel11.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel11.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel11.Location = new Point(264, 94);
        cuiLabel11.Margin = new Padding(4, 3, 4, 3);
        cuiLabel11.Name = "cuiLabel11";
        cuiLabel11.Size = new Size(72, 25);
        cuiLabel11.TabIndex = 39;
        // 
        // GpuTemperatureTrack
        // 
        GpuTemperatureTrack.Background = Color.White;
        GpuTemperatureTrack.Flipped = true;
        GpuTemperatureTrack.Foreground = Color.FromArgb(108, 124, 204);
        GpuTemperatureTrack.Location = new Point(235, 11);
        GpuTemperatureTrack.MaxValue = 100;
        GpuTemperatureTrack.Name = "GpuTemperatureTrack";
        GpuTemperatureTrack.Rounding = 8;
        GpuTemperatureTrack.Size = new Size(22, 151);
        GpuTemperatureTrack.TabIndex = 1;
        GpuTemperatureTrack.Value = 50;
        // 
        // cuiLabel7
        // 
        cuiLabel7.BackColor = Color.Transparent;
        cuiLabel7.Content = "GPU\\(°\\)";
        cuiLabel7.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel7.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel7.Location = new Point(161, 93);
        cuiLabel7.Margin = new Padding(4, 3, 4, 3);
        cuiLabel7.Name = "cuiLabel7";
        cuiLabel7.Size = new Size(71, 25);
        cuiLabel7.TabIndex = 37;
        // 
        // cuiBorder3
        // 
        cuiBorder3.Controls.Add(CDrive);
        cuiBorder3.Controls.Add(cuiLabel19);
        cuiBorder3.Controls.Add(cuiLabel20);
        cuiBorder3.Location = new Point(426, 78);
        cuiBorder3.Name = "cuiBorder3";
        cuiBorder3.OutlineThickness = 1F;
        cuiBorder3.PanelColor = Color.White;
        cuiBorder3.PanelOutlineColor = Color.White;
        cuiBorder3.Rounding = new Padding(12);
        cuiBorder3.Size = new Size(365, 138);
        cuiBorder3.TabIndex = 28;
        // 
        // CDrive
        // 
        CDrive.BackColor = Color.White;
        CDrive.InitialRotation = 0D;
        CDrive.IsClockwise = true;
        CDrive.Location = new Point(126, 12);
        CDrive.MaxAngle = 360D;
        CDrive.MaxValue = double.NaN;
        CDrive.MinValue = 0D;
        CDrive.Name = "CDrive";
        CDrive.Size = new Size(224, 115);
        CDrive.TabIndex = 49;
        // 
        // cuiLabel19
        // 
        cuiLabel19.BackColor = Color.Transparent;
        cuiLabel19.BackgroundImage = Resources.pie_chart1;
        cuiLabel19.Content = "";
        cuiLabel19.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel19.Location = new Point(8, 12);
        cuiLabel19.Margin = new Padding(4, 3, 4, 3);
        cuiLabel19.Name = "cuiLabel19";
        cuiLabel19.Size = new Size(31, 32);
        cuiLabel19.TabIndex = 48;
        // 
        // cuiLabel20
        // 
        cuiLabel20.BackColor = Color.Transparent;
        cuiLabel20.Content = "D\\ drive";
        cuiLabel20.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel20.ForeColor = Color.Black;
        cuiLabel20.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Right;
        cuiLabel20.Location = new Point(42, 12);
        cuiLabel20.Margin = new Padding(4, 3, 4, 3);
        cuiLabel20.Name = "cuiLabel20";
        cuiLabel20.Size = new Size(77, 32);
        cuiLabel20.TabIndex = 47;
        // 
        // cuiBorder4
        // 
        cuiBorder4.Controls.Add(DDrive);
        cuiBorder4.Controls.Add(cuiLabel15);
        cuiBorder4.Controls.Add(cuiLabel16);
        cuiBorder4.Location = new Point(22, 78);
        cuiBorder4.Name = "cuiBorder4";
        cuiBorder4.OutlineThickness = 1F;
        cuiBorder4.PanelColor = Color.White;
        cuiBorder4.PanelOutlineColor = Color.White;
        cuiBorder4.Rounding = new Padding(12);
        cuiBorder4.Size = new Size(365, 138);
        cuiBorder4.TabIndex = 50;
        // 
        // DDrive
        // 
        DDrive.BackColor = Color.White;
        DDrive.InitialRotation = 0D;
        DDrive.IsClockwise = true;
        DDrive.Location = new Point(135, 12);
        DDrive.MaxAngle = 360D;
        DDrive.MaxValue = double.NaN;
        DDrive.MinValue = 0D;
        DDrive.Name = "DDrive";
        DDrive.Size = new Size(220, 115);
        DDrive.TabIndex = 49;
        // 
        // cuiLabel15
        // 
        cuiLabel15.BackColor = Color.Transparent;
        cuiLabel15.BackgroundImage = Resources.pie_chart1;
        cuiLabel15.Content = "";
        cuiLabel15.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel15.Location = new Point(8, 12);
        cuiLabel15.Margin = new Padding(4, 3, 4, 3);
        cuiLabel15.Name = "cuiLabel15";
        cuiLabel15.Size = new Size(31, 32);
        cuiLabel15.TabIndex = 48;
        // 
        // cuiLabel16
        // 
        cuiLabel16.BackColor = Color.Transparent;
        cuiLabel16.Content = "D\\ drive";
        cuiLabel16.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel16.ForeColor = Color.Black;
        cuiLabel16.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Right;
        cuiLabel16.Location = new Point(42, 12);
        cuiLabel16.Margin = new Padding(4, 3, 4, 3);
        cuiLabel16.Name = "cuiLabel16";
        cuiLabel16.Size = new Size(77, 32);
        cuiLabel16.TabIndex = 47;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(1227, 692);
        Controls.Add(cuiBorder4);
        Controls.Add(cuiBorder3);
        Controls.Add(cuiBorder2);
        Controls.Add(cuiBorder1);
        Controls.Add(BatteryPanel);
        Controls.Add(cuiBorder8);
        Controls.Add(cuiBorder7);
        Controls.Add(cuiSeparator1);
        Controls.Add(cuiLabel8);
        Controls.Add(cuiLabel13);
        Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "Dashboard";
        Text = "Dashboard";
        cuiBorder7.ResumeLayout(false);
        BatteryPanel.ResumeLayout(false);
        cuiBorder1.ResumeLayout(false);
        cuiBorder2.ResumeLayout(false);
        cuiBorder3.ResumeLayout(false);
        cuiBorder4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private CuoreUI.Controls.cuiProgressBarVertical cuiProgressBarVertical2;
    public CuoreUI.Controls.Charts.cuiChartPie DiskCPie;
    private CuoreUI.Controls.cuiLabel cuiLabel13;
    private CuoreUI.Controls.cuiLabel cuiLabel8;
    private CuoreUI.Controls.cuiSeparator cuiSeparator1;
    private CuoreUI.Controls.cuiBorder cuiBorder5;
    private CuoreUI.Controls.cuiBorder cuiBorder7;
    private CuoreUI.Controls.cuiBorder cuiBorder8;
    private CuoreUI.Controls.cuiBorder BatteryPanel;
    private CuoreUI.Controls.cuiBorder cuiBorder1;
    private CuoreUI.Controls.cuiBorder cuiBorder2;
    private TabPage tabPage1;
    private TabPage tabPage2;
    public CuoreUI.Controls.cuiCircleKnob GpuLoadTrack;
    public CuoreUI.Controls.cuiCircleKnob CpuLoadTrack;
    private CuoreUI.Controls.cuiLabel cuiLabel1;
    private CuoreUI.Controls.cuiLabel cuiLabel2;
    private CuoreUI.Controls.cuiLabel cuiLabel4;
    private CuoreUI.Controls.cuiLabel cuiLabel3;
    private CuoreUI.Controls.cuiLabel DegradationLevelValue;
    private CuoreUI.Controls.cuiLabel ChargeLevelValue;
    private CuoreUI.Controls.cuiLabel cuiLabel5;
    private CuoreUI.Controls.cuiLabel cuiLabel6;
    private CuoreUI.Controls.cuiLabel cuiLabel9;
    private CuoreUI.Controls.cuiLabel cuiLabel7;
    private CuoreUI.Controls.cuiLabel cuiLabel10;
    private CuoreUI.Controls.cuiBorder cuiBorder3;
    private CuoreUI.Controls.cuiLabel cuiLabel12;
    private CuoreUI.Controls.cuiLabel cuiLabel14;
    private CuoreUI.Controls.cuiLabel cuiLabel11;
    private CuoreUI.Controls.cuiLabel cuiLabel17;
    private CuoreUI.Controls.cuiLabel cuiLabel18;
    private CuoreUI.Controls.cuiLabel cuiLabel19;
    private CuoreUI.Controls.cuiLabel cuiLabel20;
    private CuoreUI.Controls.cuiBorder cuiBorder4;
    private CuoreUI.Controls.cuiLabel cuiLabel15;
    private CuoreUI.Controls.cuiLabel cuiLabel16;
    public CuoreUI.Controls.cuiProgressBarHorizontal DegradationLevelBar;
    public CuoreUI.Controls.cuiLabel GpuTemperature;
    public CuoreUI.Controls.cuiLabel CpuTemperature;
    public CuoreUI.Controls.cuiProgressBarVertical CpuTemperatureTrack;
    public LiveChartsCore.SkiaSharpView.WinForms.PieChart CDrive;
    public LiveChartsCore.SkiaSharpView.WinForms.PieChart DDrive;
    public CuoreUI.Controls.cuiProgressBarVertical GpuTemperatureTrack;
    public CuoreUI.Controls.cuiProgressBarHorizontal ChargeLevelBar;
}