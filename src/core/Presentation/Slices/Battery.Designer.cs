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
        BatteryStatusChart = new CuoreUI.Controls.Charts.cuiChartLine();
        cuiBorder1 = new CuoreUI.Controls.cuiBorder();
        cuiSeparator2 = new CuoreUI.Controls.cuiSeparator();
        cuiLabel2 = new CuoreUI.Controls.cuiLabel();
        cuiBorder3 = new CuoreUI.Controls.cuiBorder();
        cuiSeparator3 = new CuoreUI.Controls.cuiSeparator();
        BatteryDegradationStatus = new CuoreUI.Controls.Charts.cuiChartLine();
        cuiLabel3 = new CuoreUI.Controls.cuiLabel();
        cuiBorder5 = new CuoreUI.Controls.cuiBorder();
        DisplayResults = new CuoreUI.Controls.cuiButton();
        CalendarDateLabel = new CuoreUI.Controls.cuiBorder();
        DayLabel = new CuoreUI.Controls.cuiLabel();
        OneDayCheckbox = new CuoreUI.Controls.cuiCheckbox();
        ToLabel = new CuoreUI.Controls.cuiLabel();
        FromLabel = new CuoreUI.Controls.cuiLabel();
        StartDateLabel = new CuoreUI.Controls.cuiLabel();
        EndHour = new CuoreUI.Controls.cuiTextBox2();
        EndHourLabel = new CuoreUI.Controls.cuiLabel();
        EndDate = new CuoreUI.Controls.cuiCalendarDatePicker();
        StartHour = new CuoreUI.Controls.cuiTextBox2();
        StartHourLabel = new CuoreUI.Controls.cuiLabel();
        StartDate = new CuoreUI.Controls.cuiCalendarDatePicker();
        cuiGradientBorder1 = new CuoreUI.Controls.cuiGradientBorder();
        cuiLabel4 = new CuoreUI.Controls.cuiLabel();
        cuiBorder6 = new CuoreUI.Controls.cuiBorder();
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
        cuiBorder1.SuspendLayout();
        cuiBorder3.SuspendLayout();
        cuiBorder5.SuspendLayout();
        CalendarDateLabel.SuspendLayout();
        cuiBorder6.SuspendLayout();
        SuspendLayout();
        // 
        // cuiLabel13
        // 
        cuiLabel13.BackColor = Color.White;
        cuiLabel13.Content = "Workstation\\ battery\\ log\\n";
        cuiLabel13.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel13.ForeColor = Color.Black;
        cuiLabel13.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel13.Location = new Point(28, 15);
        cuiLabel13.Margin = new Padding(4, 3, 4, 3);
        cuiLabel13.Name = "cuiLabel13";
        cuiLabel13.Size = new Size(365, 51);
        cuiLabel13.TabIndex = 16;
        // 
        // BatteryStatusChart
        // 
        BatteryStatusChart.AutoMaxValue = false;
        BatteryStatusChart.AxisColor = Color.Black;
        BatteryStatusChart.BackColor = Color.Transparent;
        BatteryStatusChart.ChartLineColor = Color.FromArgb(11, 35, 116);
        BatteryStatusChart.ChartPadding = 40;
        BatteryStatusChart.DayColor = Color.Black;
        BatteryStatusChart.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        BatteryStatusChart.GradientBackground = false;
        BatteryStatusChart.Location = new Point(0, 58);
        BatteryStatusChart.Margin = new Padding(8, 5, 8, 5);
        BatteryStatusChart.MaxValue = 100F;
        BatteryStatusChart.Name = "BatteryStatusChart";
        BatteryStatusChart.PointColor = Color.FromArgb(11, 35, 116);
        BatteryStatusChart.ShortDates = true;
        BatteryStatusChart.Size = new Size(610, 312);
        BatteryStatusChart.TabIndex = 18;
        BatteryStatusChart.UseBezier = true;
        BatteryStatusChart.UsePercent = true;
        // 
        // cuiBorder1
        // 
        cuiBorder1.Controls.Add(cuiSeparator2);
        cuiBorder1.Controls.Add(cuiLabel2);
        cuiBorder1.Controls.Add(BatteryStatusChart);
        cuiBorder1.Location = new Point(12, 316);
        cuiBorder1.Name = "cuiBorder1";
        cuiBorder1.OutlineThickness = 1F;
        cuiBorder1.PanelColor = Color.White;
        cuiBorder1.PanelOutlineColor = Color.White;
        cuiBorder1.Rounding = new Padding(10);
        cuiBorder1.Size = new Size(610, 374);
        cuiBorder1.TabIndex = 19;
        // 
        // cuiSeparator2
        // 
        cuiSeparator2.BackColor = Color.Transparent;
        cuiSeparator2.ForeColor = Color.FromArgb(40, 53, 147);
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
        cuiLabel2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel2.Location = new Point(4, 13);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(182, 41);
        cuiLabel2.TabIndex = 21;
        // 
        // cuiBorder3
        // 
        cuiBorder3.Controls.Add(cuiSeparator3);
        cuiBorder3.Controls.Add(BatteryDegradationStatus);
        cuiBorder3.Controls.Add(cuiLabel3);
        cuiBorder3.Location = new Point(652, 316);
        cuiBorder3.Name = "cuiBorder3";
        cuiBorder3.OutlineThickness = 1F;
        cuiBorder3.PanelColor = Color.White;
        cuiBorder3.PanelOutlineColor = Color.White;
        cuiBorder3.Rounding = new Padding(10);
        cuiBorder3.Size = new Size(563, 374);
        cuiBorder3.TabIndex = 20;
        // 
        // cuiSeparator3
        // 
        cuiSeparator3.BackColor = Color.Transparent;
        cuiSeparator3.ForeColor = Color.FromArgb(40, 53, 147);
        cuiSeparator3.Location = new Point(0, 49);
        cuiSeparator3.Margin = new Padding(4, 3, 4, 3);
        cuiSeparator3.Name = "cuiSeparator3";
        cuiSeparator3.SeparatorMargin = 8;
        cuiSeparator3.Size = new Size(563, 23);
        cuiSeparator3.TabIndex = 25;
        cuiSeparator3.Thickness = 1F;
        cuiSeparator3.Vertical = false;
        // 
        // BatteryDegradationStatus
        // 
        BatteryDegradationStatus.AutoMaxValue = false;
        BatteryDegradationStatus.AxisColor = Color.Black;
        BatteryDegradationStatus.BackColor = Color.Transparent;
        BatteryDegradationStatus.ChartLineColor = Color.FromArgb(11, 35, 116);
        BatteryDegradationStatus.ChartPadding = 40;
        BatteryDegradationStatus.DayColor = Color.Black;
        BatteryDegradationStatus.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        BatteryDegradationStatus.GradientBackground = false;
        BatteryDegradationStatus.Location = new Point(0, 62);
        BatteryDegradationStatus.Margin = new Padding(8, 5, 8, 5);
        BatteryDegradationStatus.MaxValue = 100F;
        BatteryDegradationStatus.Name = "BatteryDegradationStatus";
        BatteryDegradationStatus.PointColor = Color.FromArgb(11, 35, 116);
        BatteryDegradationStatus.ShortDates = true;
        BatteryDegradationStatus.Size = new Size(563, 312);
        BatteryDegradationStatus.TabIndex = 23;
        BatteryDegradationStatus.UseBezier = true;
        BatteryDegradationStatus.UsePercent = true;
        // 
        // cuiLabel3
        // 
        cuiLabel3.BackColor = Color.Transparent;
        cuiLabel3.Content = "degradation";
        cuiLabel3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel3.Location = new Point(4, 13);
        cuiLabel3.Margin = new Padding(4, 3, 4, 3);
        cuiLabel3.Name = "cuiLabel3";
        cuiLabel3.Size = new Size(165, 41);
        cuiLabel3.TabIndex = 22;
        // 
        // cuiBorder5
        // 
        cuiBorder5.BackColor = Color.Transparent;
        cuiBorder5.Controls.Add(DisplayResults);
        cuiBorder5.Controls.Add(CalendarDateLabel);
        cuiBorder5.Controls.Add(cuiGradientBorder1);
        cuiBorder5.Location = new Point(533, 34);
        cuiBorder5.Name = "cuiBorder5";
        cuiBorder5.OutlineThickness = 2F;
        cuiBorder5.PanelColor = Color.FromArgb(152, 148, 244);
        cuiBorder5.PanelOutlineColor = Color.FromArgb(241, 244, 254);
        cuiBorder5.Rounding = new Padding(8);
        cuiBorder5.Size = new Size(641, 194);
        cuiBorder5.TabIndex = 22;
        // 
        // DisplayResults
        // 
        DisplayResults.BackColor = Color.FromArgb(76, 88, 176);
        DisplayResults.CheckButton = false;
        DisplayResults.Checked = false;
        DisplayResults.CheckedBackground = Color.White;
        DisplayResults.CheckedForeColor = Color.Black;
        DisplayResults.CheckedImageTint = Color.White;
        DisplayResults.CheckedOutline = Color.FromArgb(40, 53, 147);
        DisplayResults.Content = "Display";
        DisplayResults.DialogResult = DialogResult.None;
        DisplayResults.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DisplayResults.ForeColor = Color.Black;
        DisplayResults.HoverBackground = Color.White;
        DisplayResults.HoveredImageTint = Color.White;
        DisplayResults.HoverForeColor = Color.Black;
        DisplayResults.HoverOutline = Color.FromArgb(40, 53, 147);
        DisplayResults.Image = null;
        DisplayResults.ImageAutoCenter = true;
        DisplayResults.ImageExpand = new Point(0, 0);
        DisplayResults.ImageOffset = new Point(0, 0);
        DisplayResults.ImageTint = Color.White;
        DisplayResults.Location = new Point(52, 64);
        DisplayResults.Name = "DisplayResults";
        DisplayResults.NormalBackground = Color.White;
        DisplayResults.NormalOutline = Color.FromArgb(40, 53, 147);
        DisplayResults.OutlineThickness = 0.1F;
        DisplayResults.PressedBackground = Color.White;
        DisplayResults.PressedForeColor = Color.Black;
        DisplayResults.PressedImageTint = Color.White;
        DisplayResults.PressedOutline = Color.FromArgb(40, 53, 147);
        DisplayResults.Rounding = new Padding(8);
        DisplayResults.Size = new Size(123, 61);
        DisplayResults.TabIndex = 25;
        DisplayResults.TextOffset = new Point(0, 0);
        DisplayResults.Click += DisplayResults_Click;
        // 
        // CalendarDateLabel
        // 
        CalendarDateLabel.Controls.Add(DayLabel);
        CalendarDateLabel.Controls.Add(OneDayCheckbox);
        CalendarDateLabel.Controls.Add(ToLabel);
        CalendarDateLabel.Controls.Add(FromLabel);
        CalendarDateLabel.Controls.Add(StartDateLabel);
        CalendarDateLabel.Controls.Add(EndHour);
        CalendarDateLabel.Controls.Add(EndHourLabel);
        CalendarDateLabel.Controls.Add(EndDate);
        CalendarDateLabel.Controls.Add(StartHour);
        CalendarDateLabel.Controls.Add(StartHourLabel);
        CalendarDateLabel.Controls.Add(StartDate);
        CalendarDateLabel.Location = new Point(224, 25);
        CalendarDateLabel.Name = "CalendarDateLabel";
        CalendarDateLabel.OutlineThickness = 1F;
        CalendarDateLabel.PanelColor = Color.White;
        CalendarDateLabel.PanelOutlineColor = Color.White;
        CalendarDateLabel.Rounding = new Padding(10);
        CalendarDateLabel.Size = new Size(393, 143);
        CalendarDateLabel.TabIndex = 32;
        // 
        // DayLabel
        // 
        DayLabel.AllowDrop = true;
        DayLabel.BackColor = Color.Transparent;
        DayLabel.Content = "day";
        DayLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        DayLabel.ForeColor = Color.Black;
        DayLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        OneDayCheckbox.CheckedForeground = Color.FromArgb(40, 53, 147);
        OneDayCheckbox.CheckedOutlineColor = Color.FromArgb(40, 53, 147);
        OneDayCheckbox.CheckedSymbolColor = Color.White;
        OneDayCheckbox.Content = "cuiCheckbox";
        OneDayCheckbox.ForeColor = SystemColors.ButtonShadow;
        OneDayCheckbox.Location = new Point(335, 99);
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
        OneDayCheckbox.UncheckedForeground = Color.FromArgb(40, 53, 147);
        OneDayCheckbox.UncheckedOutlineColor = Color.FromArgb(40, 53, 147);
        OneDayCheckbox.UncheckedSymbolColor = Color.White;
        OneDayCheckbox.Click += cuiCheckbox1_Click;
        // 
        // ToLabel
        // 
        ToLabel.AllowDrop = true;
        ToLabel.BackColor = Color.Transparent;
        ToLabel.Content = "to:";
        ToLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ToLabel.ForeColor = Color.Black;
        ToLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        FromLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FromLabel.ForeColor = Color.Black;
        FromLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        StartDateLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        StartDateLabel.ForeColor = Color.Black;
        StartDateLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        StartDateLabel.ImeMode = ImeMode.On;
        StartDateLabel.Location = new Point(149, 104);
        StartDateLabel.Margin = new Padding(4, 3, 4, 3);
        StartDateLabel.Name = "StartDateLabel";
        StartDateLabel.Size = new Size(190, 25);
        StartDateLabel.TabIndex = 29;
        // 
        // EndHour
        // 
        EndHour.AllowDrop = true;
        EndHour.BackColor = Color.White;
        EndHour.BorderColor = Color.Transparent;
        EndHour.BorderFocusColor = Color.WhiteSmoke;
        EndHour.BorderSize = 1;
        EndHour.CausesValidation = false;
        EndHour.Content = "";
        EndHour.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        EndHour.ForeColor = Color.Gray;
        EndHour.Location = new Point(106, 50);
        EndHour.Margin = new Padding(4);
        EndHour.Multiline = false;
        EndHour.Name = "EndHour";
        EndHour.Padding = new Padding(20, 6, 20, 0);
        EndHour.PasswordChar = false;
        EndHour.PlaceholderColor = Color.DimGray;
        EndHour.PlaceholderText = "14:00";
        EndHour.Rounding = 8;
        EndHour.Size = new Size(90, 33);
        EndHour.TabIndex = 31;
        EndHour.TextOffset = new Size(0, 0);
        EndHour.UnderlinedStyle = true;
        // 
        // EndHourLabel
        // 
        EndHourLabel.AllowDrop = true;
        EndHourLabel.BackColor = Color.Transparent;
        EndHourLabel.Content = "end\\ time";
        EndHourLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        EndHourLabel.ForeColor = Color.Black;
        EndHourLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        StartHour.AllowDrop = true;
        StartHour.BackColor = Color.White;
        StartHour.BorderColor = Color.Transparent;
        StartHour.BorderFocusColor = Color.WhiteSmoke;
        StartHour.BorderSize = 1;
        StartHour.CausesValidation = false;
        StartHour.Content = "";
        StartHour.Font = new Font("Century Schoolbook", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        StartHour.ForeColor = Color.Gray;
        StartHour.ImeMode = ImeMode.On;
        StartHour.Location = new Point(107, 15);
        StartHour.Margin = new Padding(4);
        StartHour.Multiline = false;
        StartHour.Name = "StartHour";
        StartHour.Padding = new Padding(20, 4, 20, 0);
        StartHour.PasswordChar = false;
        StartHour.PlaceholderColor = Color.DimGray;
        StartHour.PlaceholderText = "12:00";
        StartHour.Rounding = 8;
        StartHour.Size = new Size(89, 28);
        StartHour.TabIndex = 30;
        StartHour.TextOffset = new Size(0, 0);
        StartHour.UnderlinedStyle = true;
        // 
        // StartHourLabel
        // 
        StartHourLabel.AllowDrop = true;
        StartHourLabel.BackColor = Color.Transparent;
        StartHourLabel.Content = "start\\ time";
        StartHourLabel.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        StartHourLabel.ForeColor = Color.Black;
        StartHourLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        // cuiGradientBorder1
        // 
        cuiGradientBorder1.GradientAngle = 0F;
        cuiGradientBorder1.Location = new Point(0, 0);
        cuiGradientBorder1.Name = "cuiGradientBorder1";
        cuiGradientBorder1.OutlineThickness = 1F;
        cuiGradientBorder1.PanelColor1 = Color.FromArgb(40, 53, 147);
        cuiGradientBorder1.PanelColor2 = Color.Transparent;
        cuiGradientBorder1.PanelOutlineColor1 = Color.Transparent;
        cuiGradientBorder1.PanelOutlineColor2 = Color.Transparent;
        cuiGradientBorder1.Rounding = new Padding(8);
        cuiGradientBorder1.Size = new Size(638, 194);
        cuiGradientBorder1.TabIndex = 24;
        // 
        // cuiLabel4
        // 
        cuiLabel4.BackColor = Color.Transparent;
        cuiLabel4.Content = "Analyze\\ your\\ workstation's\\ battery\\ performance\\ over\\ a\\ selected\\ period\\ to\\ understand\\ usage\\ and\\ identify\\ degradation\\ trends\\.";
        cuiLabel4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel4.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel4.Location = new Point(0, 216);
        cuiLabel4.Margin = new Padding(4, 3, 4, 3);
        cuiLabel4.Name = "cuiLabel4";
        cuiLabel4.Size = new Size(526, 52);
        cuiLabel4.TabIndex = 22;
        // 
        // cuiBorder6
        // 
        cuiBorder6.BackColor = Color.Transparent;
        cuiBorder6.Controls.Add(ModelLabel);
        cuiBorder6.Controls.Add(ManufacturerLabel);
        cuiBorder6.Controls.Add(ChemistryLabel);
        cuiBorder6.Controls.Add(DesignedCapacityLabel);
        cuiBorder6.Controls.Add(FullChargedCapacityLabel);
        cuiBorder6.Controls.Add(cuiLabel12);
        cuiBorder6.Controls.Add(cuiLabel4);
        cuiBorder6.Controls.Add(cuiLabel10);
        cuiBorder6.Controls.Add(cuiLabel8);
        cuiBorder6.Controls.Add(cuiLabel6);
        cuiBorder6.Controls.Add(cuiLabel1);
        cuiBorder6.Controls.Add(cuiSeparator1);
        cuiBorder6.Controls.Add(cuiLabel13);
        cuiBorder6.Controls.Add(cuiBorder5);
        cuiBorder6.ForeColor = Color.FromArgb(40, 53, 147);
        cuiBorder6.Location = new Point(12, 16);
        cuiBorder6.Name = "cuiBorder6";
        cuiBorder6.OutlineThickness = 1F;
        cuiBorder6.PanelColor = Color.White;
        cuiBorder6.PanelOutlineColor = Color.White;
        cuiBorder6.Rounding = new Padding(10);
        cuiBorder6.Size = new Size(1203, 271);
        cuiBorder6.TabIndex = 23;
        // 
        // ModelLabel
        // 
        ModelLabel.BackColor = Color.Transparent;
        ModelLabel.Content = "";
        ModelLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ModelLabel.ForeColor = Color.FromArgb(40, 53, 147);
        ModelLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        ManufacturerLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ManufacturerLabel.ForeColor = Color.FromArgb(40, 53, 147);
        ManufacturerLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        ChemistryLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ChemistryLabel.ForeColor = Color.FromArgb(40, 53, 147);
        ChemistryLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        DesignedCapacityLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DesignedCapacityLabel.ForeColor = Color.FromArgb(40, 53, 147);
        DesignedCapacityLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        FullChargedCapacityLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FullChargedCapacityLabel.ForeColor = Color.FromArgb(40, 53, 147);
        FullChargedCapacityLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        cuiLabel12.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel12.ForeColor = Color.Black;
        cuiLabel12.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Right;
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
        cuiLabel10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel10.ForeColor = Color.Black;
        cuiLabel10.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Right;
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
        cuiLabel8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel8.ForeColor = Color.Black;
        cuiLabel8.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        cuiLabel6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel6.ForeColor = Color.Black;
        cuiLabel6.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
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
        cuiLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel1.ForeColor = Color.Black;
        cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel1.Location = new Point(28, 59);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(76, 23);
        cuiLabel1.TabIndex = 24;
        // 
        // cuiSeparator1
        // 
        cuiSeparator1.ForeColor = Color.FromArgb(40, 53, 147);
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
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(1227, 692);
        Controls.Add(cuiBorder3);
        Controls.Add(cuiBorder1);
        Controls.Add(cuiBorder6);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Battery";
        Text = "Drives";
        cuiBorder1.ResumeLayout(false);
        cuiBorder3.ResumeLayout(false);
        cuiBorder5.ResumeLayout(false);
        CalendarDateLabel.ResumeLayout(false);
        cuiBorder6.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private CuoreUI.Controls.cuiLabel cuiLabel13;
    private CuoreUI.Controls.cuiBorder cuiBorder1;
    public CuoreUI.Controls.Charts.cuiChartLine BatteryStatusChart;
    private CuoreUI.Controls.cuiBorder cuiBorder3;
    private CuoreUI.Controls.cuiBorder cuiBorder5;
    private CuoreUI.Controls.cuiButton DisplayResults;
    private CuoreUI.Controls.cuiCheckbox OneDayCheckbox;
    private CuoreUI.Controls.cuiLabel StartDateLabel;
    private CuoreUI.Controls.cuiCalendarDatePicker StartDate;
    private CuoreUI.Controls.cuiBorder CalendarDateLabel;
    private CuoreUI.Controls.cuiCalendarDatePicker EndDate;
    private CuoreUI.Controls.cuiLabel EndHourLabel;
    public CuoreUI.Controls.cuiTextBox2 EndHour;
    private CuoreUI.Controls.cuiLabel StartHourLabel;
    public CuoreUI.Controls.cuiTextBox2 StartHour;
    private CuoreUI.Controls.cuiLabel cuiLabel2;
    private CuoreUI.Controls.cuiLabel cuiLabel3;
    private CuoreUI.Controls.cuiLabel cuiLabel4;
    private CuoreUI.Controls.cuiBorder cuiBorder6;
    private CuoreUI.Controls.cuiLabel ToLabel;
    private CuoreUI.Controls.cuiLabel FromLabel;
    public CuoreUI.Controls.Charts.cuiChartLine BatteryDegradationStatus;
    private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder1;
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
}
