namespace Presentation.Slices;

partial class Battery

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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(Battery));
        cuiLabel13 = new CuoreUI.Controls.cuiLabel();
        ChargeLevelChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
        cuiSeparator2 = new CuoreUI.Controls.cuiSeparator();
        cuiLabel2 = new CuoreUI.Controls.cuiLabel();
        DegradationLevelChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
        cuiSeparator3 = new CuoreUI.Controls.cuiSeparator();
        cuiLabel3 = new CuoreUI.Controls.cuiLabel();
        DisplayResults = new CuoreUI.Controls.cuiButton();
        DayLabel = new CuoreUI.Controls.cuiLabel();
        OneDayCheckbox = new CuoreUI.Controls.cuiCheckbox();
        ToLabel = new CuoreUI.Controls.cuiLabel();
        FromLabel = new CuoreUI.Controls.cuiLabel();
        StartDateLabel = new CuoreUI.Controls.cuiLabel();
        EndHourLabel = new CuoreUI.Controls.cuiLabel();
        EndDate = new CuoreUI.Controls.cuiCalendarDatePicker();
        StartHourLabel = new CuoreUI.Controls.cuiLabel();
        StartDate = new CuoreUI.Controls.cuiCalendarDatePicker();
        ModelLabel = new CuoreUI.Controls.cuiLabel();
        ManufacturerLabel = new CuoreUI.Controls.cuiLabel();
        ChemistryLabel = new CuoreUI.Controls.cuiLabel();
        DesignedCapacityLabel = new CuoreUI.Controls.cuiLabel();
        FullChargedCapacityLabel = new CuoreUI.Controls.cuiLabel();
        cuiLabel12 = new CuoreUI.Controls.cuiLabel();
        cuiLabel10 = new CuoreUI.Controls.cuiLabel();
        cuiLabel8 = new CuoreUI.Controls.cuiLabel();
        cuiLabel6 = new CuoreUI.Controls.cuiLabel();
        cuiLabel1 = new CuoreUI.Controls.cuiLabel();
        cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
        SuspendLayout();
        // 
        // cuiLabel13
        // 
        cuiLabel13.BackColor = Color.White;
        cuiLabel13.Content = "Workstation\\ battery\\ log\\n";
        cuiLabel13.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel13.ForeColor = Color.Black;
        cuiLabel13.Location = new Point(28, 15);
        cuiLabel13.Margin = new Padding(4, 3, 4, 3);
        cuiLabel13.Name = "cuiLabel13";
        cuiLabel13.Size = new Size(429, 51);
        cuiLabel13.TabIndex = 16;
        // 
        // ChargeLevelChart
        // 
        ChargeLevelChart.BackColor = Color.White;
        ChargeLevelChart.Location = new Point(4, 49);
        ChargeLevelChart.MatchAxesScreenDataRatio = false;
        ChargeLevelChart.Name = "ChargeLevelChart";
        ChargeLevelChart.Size = new Size(603, 315);
        ChargeLevelChart.TabIndex = 25;
        // 
        // cuiSeparator2
        // 
        cuiSeparator2.BackColor = Color.Transparent;
        cuiSeparator2.ForeColor = Color.FromArgb(20, 39, 78);
        cuiSeparator2.Location = new Point(1, 49);
        cuiSeparator2.Margin = new Padding(4, 3, 4, 3);
        cuiSeparator2.Name = "cuiSeparator2";
        cuiSeparator2.SeparatorMargin = 8;
        cuiSeparator2.Size = new Size(610, 23);
        cuiSeparator2.TabIndex = 24;
        cuiSeparator2.Thickness = 1F;
        cuiSeparator2.Vertical = false;
        // 
        // cuiLabel2
        // 
        cuiLabel2.BackColor = Color.Transparent;
        cuiLabel2.Content = "charge\\ level";
        cuiLabel2.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel2.Location = new Point(4, 13);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(233, 41);
        cuiLabel2.TabIndex = 21;
        // 
        // DegradationLevelChart
        // 
        DegradationLevelChart.BackColor = Color.White;
        DegradationLevelChart.Location = new Point(4, 60);
        DegradationLevelChart.MatchAxesScreenDataRatio = false;
        DegradationLevelChart.Name = "DegradationLevelChart";
        DegradationLevelChart.Size = new Size(556, 311);
        DegradationLevelChart.TabIndex = 26;
        // 
        // cuiSeparator3
        // 
        cuiSeparator3.BackColor = Color.Transparent;
        cuiSeparator3.ForeColor = Color.FromArgb(20, 39, 78);
        cuiSeparator3.Location = new Point(0, 49);
        cuiSeparator3.Margin = new Padding(4, 3, 4, 3);
        cuiSeparator3.Name = "cuiSeparator3";
        cuiSeparator3.SeparatorMargin = 8;
        cuiSeparator3.Size = new Size(563, 23);
        cuiSeparator3.TabIndex = 25;
        cuiSeparator3.Thickness = 1F;
        cuiSeparator3.Vertical = false;
        // 
        // cuiLabel3
        // 
        cuiLabel3.BackColor = Color.Transparent;
        cuiLabel3.Content = "degradation";
        cuiLabel3.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel3.Location = new Point(4, 13);
        cuiLabel3.Margin = new Padding(4, 3, 4, 3);
        cuiLabel3.Name = "cuiLabel3";
        cuiLabel3.Size = new Size(251, 41);
        cuiLabel3.TabIndex = 22;
        // 
        // DisplayResults
        // 
        DisplayResults.BackColor = Color.FromArgb(28, 46, 83);
        DisplayResults.CheckButton = false;
        DisplayResults.Checked = false;
        DisplayResults.CheckedBackground = Color.White;
        DisplayResults.CheckedForeColor = Color.Black;
        DisplayResults.CheckedImageTint = Color.White;
        DisplayResults.CheckedOutline = Color.FromArgb(28, 46, 83);
        DisplayResults.Content = "Display";
        DisplayResults.DialogResult = DialogResult.None;
        DisplayResults.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DisplayResults.ForeColor = Color.Black;
        DisplayResults.HoverBackground = Color.White;
        DisplayResults.HoveredImageTint = Color.White;
        DisplayResults.HoverForeColor = Color.Black;
        DisplayResults.HoverOutline = Color.FromArgb(28, 46, 83);
        DisplayResults.Image = null;
        DisplayResults.ImageAutoCenter = true;
        DisplayResults.ImageExpand = new Point(0, 0);
        DisplayResults.ImageOffset = new Point(0, 0);
        DisplayResults.Location = new Point(52, 64);
        DisplayResults.Name = "DisplayResults";
        DisplayResults.NormalBackground = Color.White;
        DisplayResults.NormalOutline = Color.FromArgb(28, 46, 83);
        DisplayResults.OutlineThickness = 0.1F;
        DisplayResults.PressedBackground = Color.White;
        DisplayResults.PressedForeColor = Color.Black;
        DisplayResults.PressedImageTint = Color.White;
        DisplayResults.PressedOutline = Color.FromArgb(28, 46, 83);
        DisplayResults.Rounding = new Padding(8);
        DisplayResults.Size = new Size(123, 61);
        DisplayResults.TabIndex = 25;
        DisplayResults.TextOffset = new Point(0, 0);
        DisplayResults.Click += DisplayResults_Click;
        // 
        // DayLabel
        // 
        DayLabel.AllowDrop = true;
        DayLabel.BackColor = Color.Transparent;
        DayLabel.Content = "day";
        DayLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
        DayLabel.ForeColor = Color.Black;
        DayLabel.ImeMode = ImeMode.On;
        DayLabel.Location = new Point(240, 12);
        DayLabel.Margin = new Padding(4, 3, 4, 3);
        DayLabel.Name = "DayLabel";
        DayLabel.Size = new Size(81, 24);
        DayLabel.TabIndex = 34;
        DayLabel.Visible = false;
        // 
        // OneDayCheckbox
        // 
        OneDayCheckbox.BackColor = Color.White;
        OneDayCheckbox.Checked = false;
        OneDayCheckbox.CheckedForeground = Color.FromArgb(20, 39, 78);
        OneDayCheckbox.CheckedOutlineColor = Color.FromArgb(20, 39, 78);
        OneDayCheckbox.CheckedSymbolColor = Color.White;
        OneDayCheckbox.Content = "cuiCheckbox";
        OneDayCheckbox.ForeColor = SystemColors.ButtonShadow;
        OneDayCheckbox.Location = new Point(335, 93);
        OneDayCheckbox.MinimumSize = new Size(16, 16);
        OneDayCheckbox.Name = "OneDayCheckbox";
        OneDayCheckbox.OutlineStyle = false;
        OneDayCheckbox.OutlineThickness = 2F;
        OneDayCheckbox.Padding = new Padding(8);
        OneDayCheckbox.Rounding = 10;
        OneDayCheckbox.ShowSymbols = true;
        OneDayCheckbox.Size = new Size(32, 30);
        OneDayCheckbox.TabIndex = 26;
        OneDayCheckbox.Text = "cuiCheckbox1";
        OneDayCheckbox.UncheckedForeground = Color.FromArgb(20, 39, 78);
        OneDayCheckbox.UncheckedOutlineColor = Color.FromArgb(20, 39, 78);
        OneDayCheckbox.UncheckedSymbolColor = Color.White;
        OneDayCheckbox.Click += cuiCheckbox1_Click;
        // 
        // ToLabel
        // 
        ToLabel.AllowDrop = true;
        ToLabel.BackColor = Color.Transparent;
        ToLabel.Content = "to:";
        ToLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
        ToLabel.ForeColor = Color.Black;
        ToLabel.ImeMode = ImeMode.On;
        ToLabel.Location = new Point(178, 49);
        ToLabel.Margin = new Padding(4, 3, 4, 3);
        ToLabel.Name = "ToLabel";
        ToLabel.Size = new Size(81, 24);
        ToLabel.TabIndex = 33;
        // 
        // FromLabel
        // 
        FromLabel.AllowDrop = true;
        FromLabel.BackColor = Color.Transparent;
        FromLabel.Content = "from:";
        FromLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
        FromLabel.ForeColor = Color.Black;
        FromLabel.ImeMode = ImeMode.On;
        FromLabel.Location = new Point(178, 13);
        FromLabel.Margin = new Padding(4, 3, 4, 3);
        FromLabel.Name = "FromLabel";
        FromLabel.Size = new Size(81, 24);
        FromLabel.TabIndex = 32;
        FromLabel.Load += FromLabel_Load;
        // 
        // StartDateLabel
        // 
        StartDateLabel.AllowDrop = true;
        StartDateLabel.BackColor = Color.White;
        StartDateLabel.Content = "one\\ day\\ statistics";
        StartDateLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        StartDateLabel.ForeColor = Color.Black;
        StartDateLabel.ImeMode = ImeMode.On;
        StartDateLabel.Location = new Point(165, 99);
        StartDateLabel.Margin = new Padding(4, 3, 4, 3);
        StartDateLabel.Name = "StartDateLabel";
        StartDateLabel.Size = new Size(173, 30);
        StartDateLabel.TabIndex = 29;
        // EndHourLabel
        // 
        EndHourLabel.AllowDrop = true;
        EndHourLabel.BackColor = Color.Transparent;
        EndHourLabel.Content = "end\\ time";
        EndHourLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
        EndHourLabel.ForeColor = Color.Black;
        EndHourLabel.Location = new Point(0, 49);
        EndHourLabel.Margin = new Padding(4, 3, 4, 3);
        EndHourLabel.Name = "EndHourLabel";
        EndHourLabel.Size = new Size(104, 25);
        EndHourLabel.TabIndex = 31;
        // 
        // EndDate
        // 
        EndDate.BackColor = Color.Transparent;
        EndDate.EnableThemeChangeButton = true;
        EndDate.Font = new Font("Segoe UI", 9.75F);
        EndDate.ForeColor = Color.Black;
        EndDate.HoverBackground = Color.Transparent;
        EndDate.HoverOutline = Color.Transparent;
        EndDate.Icon = (Image)resources.GetObject("EndDate.Icon");
        EndDate.IconTint = Color.Black;
        EndDate.Location = new Point(252, 39);
        EndDate.Margin = new Padding(4, 3, 4, 3);
        EndDate.Name = "EndDate";
        EndDate.NormalBackground = Color.White;
        EndDate.NormalOutline = Color.White;
        EndDate.OutlineThickness = 2F;
        EndDate.PressedBackground = Color.White;
        EndDate.PressedOutline = Color.White;
        EndDate.Rounding = 8;
        EndDate.ShowIcon = true;
        EndDate.Size = new Size(126, 44);
        EndDate.TabIndex = 29;
        EndDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Dark;
        EndDate.Value = new DateTime(2025, 3, 21, 0, 0, 0, 0);
        // 
        // StartHour
        // 
        // 
        // StartHourLabel
        // 
        StartHourLabel.AllowDrop = true;
        StartHourLabel.BackColor = Color.Transparent;
        StartHourLabel.Content = "start\\ time";
        StartHourLabel.Font = new Font("Verdana", 11.25F, FontStyle.Bold);
        StartHourLabel.ForeColor = Color.Black;
        StartHourLabel.Location = new Point(4, 13);
        StartHourLabel.Margin = new Padding(4, 3, 4, 3);
        StartHourLabel.Name = "StartHourLabel";
        StartHourLabel.Size = new Size(100, 23);
        StartHourLabel.TabIndex = 29;
        // 
        // StartDate
        // 
        StartDate.BackColor = Color.Transparent;
        StartDate.EnableThemeChangeButton = true;
        StartDate.Font = new Font("Segoe UI", 9.75F);
        StartDate.ForeColor = Color.Black;
        StartDate.HoverBackground = Color.Transparent;
        StartDate.HoverOutline = Color.Transparent;
        StartDate.Icon = (Image)resources.GetObject("StartDate.Icon");
        StartDate.IconTint = Color.Black;
        StartDate.Location = new Point(267, 3);
        StartDate.Margin = new Padding(4, 3, 4, 3);
        StartDate.Name = "StartDate";
        StartDate.NormalBackground = Color.White;
        StartDate.NormalOutline = Color.White;
        StartDate.OutlineThickness = 2F;
        StartDate.PressedBackground = Color.White;
        StartDate.PressedOutline = Color.White;
        StartDate.Rounding = 8;
        StartDate.ShowIcon = true;
        StartDate.Size = new Size(100, 46);
        StartDate.TabIndex = 28;
        StartDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Dark;
        StartDate.Value = new DateTime(2025, 3, 21, 0, 0, 0, 0);
        // 
        // cuiLabel4
        // 
        cuiLabel4.BackColor = Color.Transparent;
        cuiLabel4.Content = "Analyze\\ your\\ workstation's\\ battery\\ performance\\ over\\ a\\ selected\\ period\\ to\\ understand\\ usage\\ and\\ identify\\ degradation\\ trends\\.";
        cuiLabel4.Font = new Font("Verdana", 12F);
        cuiLabel4.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel4.Location = new Point(0, 208);
        cuiLabel4.Margin = new Padding(4, 3, 4, 3);
        cuiLabel4.Name = "cuiLabel4";
        cuiLabel4.Size = new Size(526, 60);
        cuiLabel4.TabIndex = 22;
        // 
        // ModelLabel
        // 
        ModelLabel.BackColor = Color.Transparent;
        ModelLabel.Content = "";
        ModelLabel.Font = new Font("Verdana", 12F);
        ModelLabel.ForeColor = Color.FromArgb(20, 39, 78);
        ModelLabel.Location = new Point(221, 60);
        ModelLabel.Margin = new Padding(4, 3, 4, 3);
        ModelLabel.Name = "ModelLabel";
        ModelLabel.Size = new Size(305, 23);
        ModelLabel.TabIndex = 38;
        ModelLabel.Load += ModelLabel_Load;
        // 
        // ManufacturerLabel
        // 
        ManufacturerLabel.BackColor = Color.Transparent;
        ManufacturerLabel.Content = "";
        ManufacturerLabel.Font = new Font("Verdana", 12F);
        ManufacturerLabel.ForeColor = Color.FromArgb(20, 39, 78);
        ManufacturerLabel.Location = new Point(221, 89);
        ManufacturerLabel.Margin = new Padding(4, 3, 4, 3);
        ManufacturerLabel.Name = "ManufacturerLabel";
        ManufacturerLabel.Size = new Size(305, 23);
        ManufacturerLabel.TabIndex = 37;
        // 
        // ChemistryLabel
        // 
        ChemistryLabel.BackColor = Color.Transparent;
        ChemistryLabel.Content = "";
        ChemistryLabel.Font = new Font("Verdana", 12F);
        ChemistryLabel.ForeColor = Color.FromArgb(20, 39, 78);
        ChemistryLabel.Location = new Point(221, 118);
        ChemistryLabel.Margin = new Padding(4, 3, 4, 3);
        ChemistryLabel.Name = "ChemistryLabel";
        ChemistryLabel.Size = new Size(305, 23);
        ChemistryLabel.TabIndex = 36;
        // 
        // DesignedCapacityLabel
        // 
        DesignedCapacityLabel.BackColor = Color.Transparent;
        DesignedCapacityLabel.Content = "";
        DesignedCapacityLabel.Font = new Font("Verdana", 12F);
        DesignedCapacityLabel.ForeColor = Color.FromArgb(20, 39, 78);
        DesignedCapacityLabel.Location = new Point(221, 147);
        DesignedCapacityLabel.Margin = new Padding(4, 3, 4, 3);
        DesignedCapacityLabel.Name = "DesignedCapacityLabel";
        DesignedCapacityLabel.Size = new Size(305, 23);
        DesignedCapacityLabel.TabIndex = 35;
        // 
        // FullChargedCapacityLabel
        // 
        FullChargedCapacityLabel.BackColor = Color.Transparent;
        FullChargedCapacityLabel.Content = "";
        FullChargedCapacityLabel.Font = new Font("Verdana", 12F);
        FullChargedCapacityLabel.ForeColor = Color.FromArgb(20, 39, 78);
        FullChargedCapacityLabel.Location = new Point(221, 179);
        FullChargedCapacityLabel.Margin = new Padding(4, 3, 4, 3);
        FullChargedCapacityLabel.Name = "FullChargedCapacityLabel";
        FullChargedCapacityLabel.Size = new Size(305, 23);
        FullChargedCapacityLabel.TabIndex = 34;
        // 
        // cuiLabel12
        // 
        cuiLabel12.BackColor = Color.Transparent;
        cuiLabel12.Content = "Chemistry:";
        cuiLabel12.Font = new Font("Verdana", 12F);
        cuiLabel12.ForeColor = Color.Black;
        cuiLabel12.Location = new Point(28, 118);
        cuiLabel12.Margin = new Padding(4, 3, 4, 3);
        cuiLabel12.Name = "cuiLabel12";
        cuiLabel12.Size = new Size(93, 23);
        cuiLabel12.TabIndex = 32;
        // 
        // cuiLabel10
        // 
        cuiLabel10.BackColor = Color.Transparent;
        cuiLabel10.Content = "Full\\ charged\\ capaticy:";
        cuiLabel10.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel10.ForeColor = Color.Black;
        cuiLabel10.Location = new Point(18, 176);
        cuiLabel10.Margin = new Padding(4, 3, 4, 3);
        cuiLabel10.Name = "cuiLabel10";
        cuiLabel10.Size = new Size(195, 26);
        cuiLabel10.TabIndex = 30;
        // 
        // cuiLabel8
        // 
        cuiLabel8.BackColor = Color.Transparent;
        cuiLabel8.Content = "Designed\\ capalicy:";
        cuiLabel8.Font = new Font("Verdana", 12F);
        cuiLabel8.ForeColor = Color.Black;
        cuiLabel8.Location = new Point(28, 147);
        cuiLabel8.Margin = new Padding(4, 3, 4, 3);
        cuiLabel8.Name = "cuiLabel8";
        cuiLabel8.Size = new Size(168, 23);
        cuiLabel8.TabIndex = 28;
        // 
        // cuiLabel6
        // 
        cuiLabel6.BackColor = Color.Transparent;
        cuiLabel6.Content = "Manufacturer:";
        cuiLabel6.Font = new Font("Verdana", 12F);
        cuiLabel6.ForeColor = Color.Black;
        cuiLabel6.Location = new Point(28, 91);
        cuiLabel6.Margin = new Padding(4, 3, 4, 3);
        cuiLabel6.Name = "cuiLabel6";
        cuiLabel6.Size = new Size(128, 23);
        cuiLabel6.TabIndex = 26;
        // 
        // cuiLabel1
        // 
        cuiLabel1.BackColor = Color.Transparent;
        cuiLabel1.Content = "Model:";
        cuiLabel1.Font = new Font("Verdana", 12F);
        cuiLabel1.ForeColor = Color.Black;
        cuiLabel1.Location = new Point(28, 59);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(76, 23);
        cuiLabel1.TabIndex = 24;
        // 
        // cuiSeparator1
        // 
        cuiSeparator1.ForeColor = Color.FromArgb(20, 39, 78);
        cuiSeparator1.Location = new Point(0, 195);
        cuiSeparator1.Margin = new Padding(4, 3, 4, 3);
        cuiSeparator1.Name = "cuiSeparator1";
        cuiSeparator1.SeparatorMargin = 8;
        cuiSeparator1.Size = new Size(526, 16);
        cuiSeparator1.TabIndex = 23;
        cuiSeparator1.Thickness = 1F;
        cuiSeparator1.Vertical = false;
        // 
        // Battery
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(155, 164, 180);
        ClientSize = new Size(1227, 692);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Battery";
        Text = "Drives";
        ResumeLayout(false);
    }

    #endregion

    private CuoreUI.Controls.cuiLabel cuiLabel13;
    private CuoreUI.Controls.cuiButton DisplayResults;
    private CuoreUI.Controls.cuiCheckbox OneDayCheckbox;
    private CuoreUI.Controls.cuiLabel StartDateLabel;
    private CuoreUI.Controls.cuiCalendarDatePicker StartDate;
    private CuoreUI.Controls.cuiCalendarDatePicker EndDate;
    private CuoreUI.Controls.cuiLabel EndHourLabel;
    private CuoreUI.Controls.cuiLabel StartHourLabel;
    private CuoreUI.Controls.cuiLabel cuiLabel2;
    private CuoreUI.Controls.cuiLabel cuiLabel3;
    private CuoreUI.Controls.cuiLabel cuiLabel4;
    private CuoreUI.Controls.cuiLabel ToLabel;
    private CuoreUI.Controls.cuiLabel FromLabel;
    private CuoreUI.Controls.cuiLabel DayLabel;
    private CuoreUI.Controls.cuiSeparator cuiSeparator1;
    private CuoreUI.Controls.cuiLabel cuiLabel12;
    private CuoreUI.Controls.cuiLabel cuiLabel10;
    private CuoreUI.Controls.cuiLabel cuiLabel8;
    private CuoreUI.Controls.cuiLabel cuiLabel6;
    private CuoreUI.Controls.cuiLabel cuiLabel1;
    private CuoreUI.Controls.cuiLabel ModelLabel;
    private CuoreUI.Controls.cuiLabel ManufacturerLabel;
    private CuoreUI.Controls.cuiLabel ChemistryLabel;
    private CuoreUI.Controls.cuiLabel DesignedCapacityLabel;
    private CuoreUI.Controls.cuiLabel FullChargedCapacityLabel;
    private CuoreUI.Controls.cuiSeparator cuiSeparator2;
    private CuoreUI.Controls.cuiSeparator cuiSeparator3;
    public LiveChartsCore.SkiaSharpView.WinForms.CartesianChart ChargeLevelChart;
    public LiveChartsCore.SkiaSharpView.WinForms.CartesianChart DegradationLevelChart;
}
