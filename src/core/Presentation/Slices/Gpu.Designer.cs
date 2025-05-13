namespace Presentation.Slices;

partial class Gpu
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(Gpu));
        cuiBorder7 = new CuoreUI.Controls.cuiBorder();
        LoadChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
        cuiSeparator2 = new CuoreUI.Controls.cuiSeparator();
        cuiLabel5 = new CuoreUI.Controls.cuiLabel();
        cuiBorder1 = new CuoreUI.Controls.cuiBorder();
        TempChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
        cuiSeparator4 = new CuoreUI.Controls.cuiSeparator();
        cuiLabel2 = new CuoreUI.Controls.cuiLabel();
        cuiBorder2 = new CuoreUI.Controls.cuiBorder();
        ClockChart = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
        cuiSeparator3 = new CuoreUI.Controls.cuiSeparator();
        cuiLabel3 = new CuoreUI.Controls.cuiLabel();
        cuiBorder6 = new CuoreUI.Controls.cuiBorder();
        DeviceLabel = new CuoreUI.Controls.cuiLabel();
        ModelLabel = new CuoreUI.Controls.cuiLabel();
        cuiLabel4 = new CuoreUI.Controls.cuiLabel();
        DeviceLabelText = new CuoreUI.Controls.cuiLabel();
        cuiLabel1 = new CuoreUI.Controls.cuiLabel();
        cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
        cuiLabel13 = new CuoreUI.Controls.cuiLabel();
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
        cuiBorder7.SuspendLayout();
        cuiBorder1.SuspendLayout();
        cuiBorder2.SuspendLayout();
        cuiBorder6.SuspendLayout();
        cuiBorder5.SuspendLayout();
        CalendarDateLabel.SuspendLayout();
        SuspendLayout();
        // 
        // cuiBorder7
        // 
        cuiBorder7.Controls.Add(LoadChart);
        cuiBorder7.Controls.Add(cuiSeparator2);
        cuiBorder7.Controls.Add(cuiLabel5);
        cuiBorder7.Location = new Point(12, 239);
        cuiBorder7.Margin = new Padding(3, 4, 3, 4);
        cuiBorder7.Name = "cuiBorder7";
        cuiBorder7.OutlineThickness = 1F;
        cuiBorder7.PanelColor = Color.White;
        cuiBorder7.PanelOutlineColor = Color.White;
        cuiBorder7.Rounding = new Padding(11);
        cuiBorder7.Size = new Size(1203, 190);
        cuiBorder7.TabIndex = 32;
        // 
        // LoadChart
        // 
        LoadChart.BackColor = Color.White;
        LoadChart.Location = new Point(216, 13);
        LoadChart.Margin = new Padding(4);
        LoadChart.MatchAxesScreenDataRatio = false;
        LoadChart.Name = "LoadChart";
        LoadChart.Size = new Size(983, 162);
        LoadChart.TabIndex = 49;
        // 
        // cuiSeparator2
        // 
        cuiSeparator2.BackColor = Color.Transparent;
        cuiSeparator2.ForeColor = Color.FromArgb(20, 39, 78);
        cuiSeparator2.Location = new Point(0, 31);
        cuiSeparator2.Margin = new Padding(4);
        cuiSeparator2.Name = "cuiSeparator2";
        cuiSeparator2.SeparatorMargin = 8;
        cuiSeparator2.Size = new Size(153, 10);
        cuiSeparator2.TabIndex = 39;
        cuiSeparator2.Thickness = 1F;
        cuiSeparator2.Vertical = false;
        // 
        // cuiLabel5
        // 
        cuiLabel5.BackColor = Color.Transparent;
        cuiLabel5.Content = "load";
        cuiLabel5.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel5.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel5.Location = new Point(0, 3);
        cuiLabel5.Margin = new Padding(4, 3, 4, 3);
        cuiLabel5.Name = "cuiLabel5";
        cuiLabel5.Size = new Size(150, 38);
        cuiLabel5.TabIndex = 22;
        // 
        // cuiBorder1
        // 
        cuiBorder1.Controls.Add(TempChart);
        cuiBorder1.Controls.Add(cuiSeparator4);
        cuiBorder1.Controls.Add(cuiLabel2);
        cuiBorder1.Location = new Point(12, 437);
        cuiBorder1.Margin = new Padding(3, 4, 3, 4);
        cuiBorder1.Name = "cuiBorder1";
        cuiBorder1.OutlineThickness = 1F;
        cuiBorder1.PanelColor = Color.White;
        cuiBorder1.PanelOutlineColor = Color.White;
        cuiBorder1.Rounding = new Padding(11);
        cuiBorder1.Size = new Size(402, 255);
        cuiBorder1.TabIndex = 33;
        // 
        // TempChart
        // 
        TempChart.BackColor = Color.White;
        TempChart.Location = new Point(0, 41);
        TempChart.Margin = new Padding(6);
        TempChart.MatchAxesScreenDataRatio = false;
        TempChart.Name = "TempChart";
        TempChart.Size = new Size(396, 200);
        TempChart.TabIndex = 51;
        // 
        // cuiSeparator4
        // 
        cuiSeparator4.BackColor = Color.Transparent;
        cuiSeparator4.ForeColor = Color.FromArgb(40, 53, 147);
        cuiSeparator4.Location = new Point(0, 30);
        cuiSeparator4.Margin = new Padding(6, 5, 6, 5);
        cuiSeparator4.Name = "cuiSeparator4";
        cuiSeparator4.SeparatorMargin = 8;
        cuiSeparator4.Size = new Size(197, 13);
        cuiSeparator4.TabIndex = 41;
        cuiSeparator4.Thickness = 1F;
        cuiSeparator4.Vertical = false;
        // 
        // cuiLabel2
        // 
        cuiLabel2.BackColor = Color.Transparent;
        cuiLabel2.Content = "temperature";
        cuiLabel2.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel2.Location = new Point(4, 3);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(193, 35);
        cuiLabel2.TabIndex = 22;
        // 
        // cuiBorder2
        // 
        cuiBorder2.Controls.Add(ClockChart);
        cuiBorder2.Controls.Add(cuiSeparator3);
        cuiBorder2.Controls.Add(cuiLabel3);
        cuiBorder2.Location = new Point(423, 437);
        cuiBorder2.Margin = new Padding(3, 4, 3, 4);
        cuiBorder2.Name = "cuiBorder2";
        cuiBorder2.OutlineThickness = 1F;
        cuiBorder2.PanelColor = Color.White;
        cuiBorder2.PanelOutlineColor = Color.White;
        cuiBorder2.Rounding = new Padding(11);
        cuiBorder2.Size = new Size(792, 255);
        cuiBorder2.TabIndex = 33;
        // 
        // ClockChart
        // 
        ClockChart.BackColor = Color.White;
        ClockChart.Location = new Point(5, 41);
        ClockChart.Margin = new Padding(5);
        ClockChart.MatchAxesScreenDataRatio = false;
        ClockChart.Name = "ClockChart";
        ClockChart.Size = new Size(787, 200);
        ClockChart.TabIndex = 50;
        // 
        // cuiSeparator3
        // 
        cuiSeparator3.BackColor = Color.Transparent;
        cuiSeparator3.ForeColor = Color.FromArgb(20, 39, 78);
        cuiSeparator3.Location = new Point(0, 28);
        cuiSeparator3.Margin = new Padding(6, 5, 6, 5);
        cuiSeparator3.Name = "cuiSeparator3";
        cuiSeparator3.SeparatorMargin = 8;
        cuiSeparator3.Size = new Size(197, 13);
        cuiSeparator3.TabIndex = 40;
        cuiSeparator3.Thickness = 1F;
        cuiSeparator3.Vertical = false;
        // 
        // cuiLabel3
        // 
        cuiLabel3.BackColor = Color.Transparent;
        cuiLabel3.Content = "clock";
        cuiLabel3.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel3.Location = new Point(0, 3);
        cuiLabel3.Margin = new Padding(4, 3, 4, 3);
        cuiLabel3.Name = "cuiLabel3";
        cuiLabel3.Size = new Size(92, 30);
        cuiLabel3.TabIndex = 22;
        // 
        // cuiBorder6
        // 
        cuiBorder6.BackColor = Color.Transparent;
        cuiBorder6.Controls.Add(DeviceLabel);
        cuiBorder6.Controls.Add(ModelLabel);
        cuiBorder6.Controls.Add(cuiLabel4);
        cuiBorder6.Controls.Add(DeviceLabelText);
        cuiBorder6.Controls.Add(cuiLabel1);
        cuiBorder6.Controls.Add(cuiSeparator1);
        cuiBorder6.Controls.Add(cuiLabel13);
        cuiBorder6.Controls.Add(cuiBorder5);
        cuiBorder6.ForeColor = Color.FromArgb(40, 53, 147);
        cuiBorder6.Location = new Point(12, 12);
        cuiBorder6.Margin = new Padding(3, 4, 3, 4);
        cuiBorder6.Name = "cuiBorder6";
        cuiBorder6.OutlineThickness = 1F;
        cuiBorder6.PanelColor = Color.White;
        cuiBorder6.PanelOutlineColor = Color.White;
        cuiBorder6.Rounding = new Padding(11);
        cuiBorder6.Size = new Size(1203, 219);
        cuiBorder6.TabIndex = 25;
        // 
        // DeviceLabel
        // 
        DeviceLabel.BackColor = Color.Transparent;
        DeviceLabel.Content = "";
        DeviceLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DeviceLabel.ForeColor = Color.FromArgb(40, 53, 147);
        DeviceLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        DeviceLabel.Location = new Point(138, 62);
        DeviceLabel.Margin = new Padding(4, 3, 4, 3);
        DeviceLabel.Name = "DeviceLabel";
        DeviceLabel.Size = new Size(305, 23);
        DeviceLabel.TabIndex = 39;
        // 
        // ModelLabel
        // 
        ModelLabel.BackColor = Color.Transparent;
        ModelLabel.Content = "";
        ModelLabel.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ModelLabel.ForeColor = Color.FromArgb(40, 53, 147);
        ModelLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        ModelLabel.Location = new Point(138, 38);
        ModelLabel.Margin = new Padding(4, 3, 4, 3);
        ModelLabel.Name = "ModelLabel";
        ModelLabel.Size = new Size(305, 23);
        ModelLabel.TabIndex = 38;
        // 
        // cuiLabel4
        // 
        cuiLabel4.BackColor = Color.Transparent;
        cuiLabel4.Content = "Track\\ GPU\\ performance\\ during\\ gaming\\ or\\ rendering\\ sessions\\.\\ Analyze\\ load,\\ temperature,\\ and\\ clock\\ speed\\ to\\ optimize\\ settings\\ and\\ prevent\\ performance\\ drops\\.";
        cuiLabel4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel4.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel4.Location = new Point(4, 109);
        cuiLabel4.Margin = new Padding(4, 3, 4, 3);
        cuiLabel4.Name = "cuiLabel4";
        cuiLabel4.Size = new Size(526, 92);
        cuiLabel4.TabIndex = 22;
        // 
        // DeviceLabelText
        // 
        DeviceLabelText.BackColor = Color.Transparent;
        DeviceLabelText.Content = "Device:";
        DeviceLabelText.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DeviceLabelText.ForeColor = Color.Black;
        DeviceLabelText.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        DeviceLabelText.Location = new Point(19, 64);
        DeviceLabelText.Margin = new Padding(4, 3, 4, 3);
        DeviceLabelText.Name = "DeviceLabelText";
        DeviceLabelText.Size = new Size(76, 21);
        DeviceLabelText.TabIndex = 26;
        // 
        // cuiLabel1
        // 
        cuiLabel1.BackColor = Color.Transparent;
        cuiLabel1.Content = "Model:";
        cuiLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel1.ForeColor = Color.Black;
        cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel1.Location = new Point(19, 38);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(76, 23);
        cuiLabel1.TabIndex = 24;
        // 
        // cuiSeparator1
        // 
        cuiSeparator1.ForeColor = Color.FromArgb(20, 39, 78);
        cuiSeparator1.Location = new Point(0, 92);
        cuiSeparator1.Margin = new Padding(4);
        cuiSeparator1.Name = "cuiSeparator1";
        cuiSeparator1.SeparatorMargin = 8;
        cuiSeparator1.Size = new Size(526, 15);
        cuiSeparator1.TabIndex = 23;
        cuiSeparator1.Thickness = 1F;
        cuiSeparator1.Vertical = false;
        // 
        // cuiLabel13
        // 
        cuiLabel13.BackColor = Color.White;
        cuiLabel13.Content = "Gpu\\ statistics";
        cuiLabel13.Font = new Font("Verdana", 21.75F, FontStyle.Bold);
        cuiLabel13.ForeColor = Color.Black;
        cuiLabel13.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel13.Location = new Point(4, 3);
        cuiLabel13.Margin = new Padding(4, 3, 4, 3);
        cuiLabel13.Name = "cuiLabel13";
        cuiLabel13.Size = new Size(256, 41);
        cuiLabel13.TabIndex = 16;
        // 
        // cuiBorder5
        // 
        cuiBorder5.BackColor = Color.Transparent;
        cuiBorder5.Controls.Add(DisplayResults);
        cuiBorder5.Controls.Add(CalendarDateLabel);
        cuiBorder5.Controls.Add(cuiGradientBorder1);
        cuiBorder5.ForeColor = Color.FromArgb(20, 39, 78);
        cuiBorder5.Location = new Point(546, 7);
        cuiBorder5.Margin = new Padding(3, 4, 3, 4);
        cuiBorder5.Name = "cuiBorder5";
        cuiBorder5.OutlineThickness = 2F;
        cuiBorder5.PanelColor = Color.FromArgb(57, 72, 103);
        cuiBorder5.PanelOutlineColor = Color.FromArgb(241, 244, 254);
        cuiBorder5.Rounding = new Padding(8);
        cuiBorder5.Size = new Size(641, 194);
        cuiBorder5.TabIndex = 22;
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
        DisplayResults.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DisplayResults.ForeColor = Color.Black;
        DisplayResults.HoverBackground = Color.White;
        DisplayResults.HoveredImageTint = Color.White;
        DisplayResults.HoverForeColor = Color.Black;
        DisplayResults.HoverOutline = Color.FromArgb(28, 46, 83);
        DisplayResults.Image = null;
        DisplayResults.ImageAutoCenter = true;
        DisplayResults.ImageExpand = new Point(0, 0);
        DisplayResults.ImageOffset = new Point(0, 0);
        DisplayResults.ImageTint = Color.White;
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
        CalendarDateLabel.Margin = new Padding(3, 4, 3, 4);
        CalendarDateLabel.Name = "CalendarDateLabel";
        CalendarDateLabel.OutlineThickness = 1F;
        CalendarDateLabel.PanelColor = Color.White;
        CalendarDateLabel.PanelOutlineColor = Color.White;
        CalendarDateLabel.Rounding = new Padding(10);
        CalendarDateLabel.Size = new Size(393, 142);
        CalendarDateLabel.TabIndex = 32;
        // 
        // DayLabel
        // 
        DayLabel.AllowDrop = true;
        DayLabel.BackColor = Color.Transparent;
        DayLabel.Content = "day";
        DayLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
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
        OneDayCheckbox.CheckedForeground = Color.FromArgb(20, 39, 78);
        OneDayCheckbox.CheckedOutlineColor = Color.FromArgb(20, 39, 78);
        OneDayCheckbox.CheckedSymbolColor = Color.White;
        OneDayCheckbox.Content = "cuiCheckbox";
        OneDayCheckbox.ForeColor = SystemColors.ButtonShadow;
        OneDayCheckbox.Location = new Point(335, 99);
        OneDayCheckbox.Margin = new Padding(3, 4, 3, 4);
        OneDayCheckbox.MinimumSize = new Size(16, 15);
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
        OneDayCheckbox.Click += OneDayCheckbox_Click;
        // 
        // ToLabel
        // 
        ToLabel.AllowDrop = true;
        ToLabel.BackColor = Color.Transparent;
        ToLabel.Content = "to:";
        ToLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
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
        FromLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
        FromLabel.ForeColor = Color.Black;
        FromLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        FromLabel.ImeMode = ImeMode.On;
        FromLabel.Location = new Point(178, 13);
        FromLabel.Margin = new Padding(4, 3, 4, 3);
        FromLabel.Name = "FromLabel";
        FromLabel.Size = new Size(81, 24);
        FromLabel.TabIndex = 32;
        // 
        // StartDateLabel
        // 
        StartDateLabel.AllowDrop = true;
        StartDateLabel.BackColor = Color.White;
        StartDateLabel.Content = "one\\ day\\ statistics";
        StartDateLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
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
        EndHour.Location = new Point(101, 49);
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
        EndHourLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
        EndHourLabel.ForeColor = Color.Black;
        EndHourLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        EndHourLabel.Location = new Point(0, 50);
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
        StartHour.Location = new Point(102, 14);
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
        StartHourLabel.Font = new Font("Verdana", 12F, FontStyle.Bold);
        StartHourLabel.ForeColor = Color.Black;
        StartHourLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        StartHourLabel.Location = new Point(4, 14);
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
        cuiGradientBorder1.ForeColor = Color.FromArgb(40, 52, 92);
        cuiGradientBorder1.GradientAngle = 0F;
        cuiGradientBorder1.Location = new Point(4, 4);
        cuiGradientBorder1.Margin = new Padding(3, 4, 3, 4);
        cuiGradientBorder1.Name = "cuiGradientBorder1";
        cuiGradientBorder1.OutlineThickness = 1F;
        cuiGradientBorder1.PanelColor1 = Color.FromArgb(40, 52, 92);
        cuiGradientBorder1.PanelColor2 = Color.Transparent;
        cuiGradientBorder1.PanelOutlineColor1 = Color.Transparent;
        cuiGradientBorder1.PanelOutlineColor2 = Color.Transparent;
        cuiGradientBorder1.Rounding = new Padding(8);
        cuiGradientBorder1.Size = new Size(637, 194);
        cuiGradientBorder1.TabIndex = 24;
        // 
        // Gpu
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(1227, 692);
        Controls.Add(cuiBorder6);
        Controls.Add(cuiBorder2);
        Controls.Add(cuiBorder1);
        Controls.Add(cuiBorder7);
        Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "Gpu";
        Text = "Gpu";
        cuiBorder7.ResumeLayout(false);
        cuiBorder1.ResumeLayout(false);
        cuiBorder2.ResumeLayout(false);
        cuiBorder6.ResumeLayout(false);
        cuiBorder5.ResumeLayout(false);
        CalendarDateLabel.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private CuoreUI.Controls.cuiBorder cuiBorder7;
    private CuoreUI.Controls.cuiLabel cuiLabel5;
    private CuoreUI.Controls.cuiBorder cuiBorder1;
    private CuoreUI.Controls.cuiLabel cuiLabel2;
    private CuoreUI.Controls.cuiBorder cuiBorder2;
    private CuoreUI.Controls.cuiLabel cuiLabel3;
    private CuoreUI.Controls.cuiSeparator cuiSeparator2;
    private CuoreUI.Controls.cuiSeparator cuiSeparator4;
    private CuoreUI.Controls.cuiSeparator cuiSeparator3;
    private CuoreUI.Controls.cuiBorder cuiBorder6;
    private CuoreUI.Controls.cuiLabel ModelLabel;
    private CuoreUI.Controls.cuiLabel cuiLabel4;
    private CuoreUI.Controls.cuiLabel DeviceLabelText;
    private CuoreUI.Controls.cuiLabel cuiLabel1;
    private CuoreUI.Controls.cuiSeparator cuiSeparator1;
    private CuoreUI.Controls.cuiLabel cuiLabel13;
    private CuoreUI.Controls.cuiBorder cuiBorder5;
    private CuoreUI.Controls.cuiButton DisplayResults;
    private CuoreUI.Controls.cuiBorder CalendarDateLabel;
    private CuoreUI.Controls.cuiLabel DayLabel;
    private CuoreUI.Controls.cuiCheckbox OneDayCheckbox;
    private CuoreUI.Controls.cuiLabel ToLabel;
    private CuoreUI.Controls.cuiLabel FromLabel;
    private CuoreUI.Controls.cuiLabel StartDateLabel;
    public CuoreUI.Controls.cuiTextBox2 EndHour;
    private CuoreUI.Controls.cuiLabel EndHourLabel;
    private CuoreUI.Controls.cuiCalendarDatePicker EndDate;
    public CuoreUI.Controls.cuiTextBox2 StartHour;
    private CuoreUI.Controls.cuiLabel StartHourLabel;
    private CuoreUI.Controls.cuiCalendarDatePicker StartDate;
    private CuoreUI.Controls.cuiGradientBorder cuiGradientBorder1;
    private CuoreUI.Controls.cuiLabel DeviceLabel;
    private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart LoadChart;
    private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart TempChart;
    private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart ClockChart;
}
