namespace Presentation.Slices;

partial class Drives
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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(Drives));
        cuiLabel13 = new CuoreUI.Controls.cuiLabel();
        DriveCChart = new CuoreUI.Controls.Charts.cuiChartLine();
        cuiBorder1 = new CuoreUI.Controls.cuiBorder();
        cuiBorder2 = new CuoreUI.Controls.cuiBorder();
        cuiChartLine2 = new CuoreUI.Controls.Charts.cuiChartLine();
        DriveDChart = new CuoreUI.Controls.Charts.cuiChartLine();
        cuiBorder3 = new CuoreUI.Controls.cuiBorder();
        cuiBorder4 = new CuoreUI.Controls.cuiBorder();
        cuiChartLine4 = new CuoreUI.Controls.Charts.cuiChartLine();
        cuiBorder5 = new CuoreUI.Controls.cuiBorder();
        cuiLabel1 = new CuoreUI.Controls.cuiLabel();
        ShortTermCheckbox = new CuoreUI.Controls.cuiCheckbox();
        DisplayResults = new CuoreUI.Controls.cuiButton();
        CalendarDateLabel = new CuoreUI.Controls.cuiBorder();
        EndHour = new CuoreUI.Controls.cuiTextBox2();
        EndHourLabel = new CuoreUI.Controls.cuiLabel();
        EndDateLabel = new CuoreUI.Controls.cuiLabel();
        EndDate = new CuoreUI.Controls.cuiCalendarDatePicker();
        StartHour = new CuoreUI.Controls.cuiTextBox2();
        StartDateLabel = new CuoreUI.Controls.cuiLabel();
        StartHourLabel = new CuoreUI.Controls.cuiLabel();
        StartDate = new CuoreUI.Controls.cuiCalendarDatePicker();
        cuiLabel2 = new CuoreUI.Controls.cuiLabel();
        cuiLabel3 = new CuoreUI.Controls.cuiLabel();
        cuiLabel4 = new CuoreUI.Controls.cuiLabel();
        cuiBorder6 = new CuoreUI.Controls.cuiBorder();
        cuiBorder1.SuspendLayout();
        cuiBorder2.SuspendLayout();
        cuiBorder3.SuspendLayout();
        cuiBorder4.SuspendLayout();
        cuiBorder5.SuspendLayout();
        CalendarDateLabel.SuspendLayout();
        cuiBorder6.SuspendLayout();
        SuspendLayout();
        // 
        // cuiLabel13
        // 
        cuiLabel13.BackColor = Color.White;
        cuiLabel13.Content = "View\\ workstation\\ drives\\ history";
        cuiLabel13.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel13.ForeColor = Color.Black;
        cuiLabel13.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel13.Location = new Point(175, 23);
        cuiLabel13.Margin = new Padding(4, 3, 4, 3);
        cuiLabel13.Name = "cuiLabel13";
        cuiLabel13.Size = new Size(338, 72);
        cuiLabel13.TabIndex = 16;
        // 
        // DriveCChart
        // 
        DriveCChart.AutoMaxValue = false;
        DriveCChart.AxisColor = Color.Black;
        DriveCChart.BackColor = Color.Transparent;
        DriveCChart.ChartLineColor = Color.FromArgb(11, 35, 116);
        DriveCChart.ChartPadding = 40;
        DriveCChart.CustomXAxis = new string[]
{
    "1",
    "2",
    "3"
};
        DriveCChart.DataPoints = new float[]
{
    100F,
    40F,
    80F,
    75F,
    100F,
    65F,
    60F
};
        DriveCChart.DayColor = Color.Black;
        DriveCChart.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DriveCChart.GradientBackground = false;
        DriveCChart.Location = new Point(139, 19);
        DriveCChart.Margin = new Padding(6, 4, 6, 4);
        DriveCChart.MaxValue = 100F;
        DriveCChart.Name = "DriveCChart";
        DriveCChart.PointColor = Color.FromArgb(11, 35, 116);
        DriveCChart.ShortDates = true;
        DriveCChart.Size = new Size(719, 215);
        DriveCChart.TabIndex = 18;
        DriveCChart.UseBezier = true;
        DriveCChart.UsePercent = true;
        // 
        // cuiBorder1
        // 
        cuiBorder1.Controls.Add(cuiLabel2);
        cuiBorder1.Controls.Add(cuiBorder2);
        cuiBorder1.Controls.Add(DriveCChart);
        cuiBorder1.Location = new Point(171, 201);
        cuiBorder1.Name = "cuiBorder1";
        cuiBorder1.OutlineThickness = 1F;
        cuiBorder1.PanelColor = Color.White;
        cuiBorder1.PanelOutlineColor = Color.White;
        cuiBorder1.Rounding = new Padding(10);
        cuiBorder1.Size = new Size(906, 245);
        cuiBorder1.TabIndex = 19;
        // 
        // cuiBorder2
        // 
        cuiBorder2.Controls.Add(cuiChartLine2);
        cuiBorder2.Location = new Point(446, 255);
        cuiBorder2.Name = "cuiBorder2";
        cuiBorder2.OutlineThickness = 1F;
        cuiBorder2.PanelColor = Color.White;
        cuiBorder2.PanelOutlineColor = Color.White;
        cuiBorder2.Rounding = new Padding(8);
        cuiBorder2.Size = new Size(536, 295);
        cuiBorder2.TabIndex = 20;
        // 
        // cuiChartLine2
        // 
        cuiChartLine2.AutoMaxValue = false;
        cuiChartLine2.AxisColor = Color.Black;
        cuiChartLine2.BackColor = Color.Transparent;
        cuiChartLine2.ChartLineColor = Color.FromArgb(11, 35, 116);
        cuiChartLine2.ChartPadding = 40;
        cuiChartLine2.CustomXAxis = new string[]
{
    "1",
    "2",
    "3"
};
        cuiChartLine2.DataPoints = new float[]
{
    100F,
    40F,
    80F,
    75F,
    100F,
    65F,
    60F
};
        cuiChartLine2.DayColor = Color.Black;
        cuiChartLine2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiChartLine2.GradientBackground = false;
        cuiChartLine2.Location = new Point(20, 18);
        cuiChartLine2.Margin = new Padding(6, 4, 6, 4);
        cuiChartLine2.MaxValue = 100F;
        cuiChartLine2.Name = "cuiChartLine2";
        cuiChartLine2.PointColor = Color.FromArgb(11, 35, 116);
        cuiChartLine2.ShortDates = true;
        cuiChartLine2.Size = new Size(560, 256);
        cuiChartLine2.TabIndex = 18;
        cuiChartLine2.UseBezier = true;
        cuiChartLine2.UsePercent = true;
        // 
        // DriveDChart
        // 
        DriveDChart.AutoMaxValue = false;
        DriveDChart.AxisColor = Color.Black;
        DriveDChart.BackColor = Color.Transparent;
        DriveDChart.ChartLineColor = Color.FromArgb(11, 35, 116);
        DriveDChart.ChartPadding = 40;
        DriveDChart.CustomXAxis = new string[]
{
    "1",
    "2",
    "3"
};
        DriveDChart.DataPoints = new float[]
{
    100F,
    40F,
    80F,
    75F,
    100F,
    65F,
    60F
};
        DriveDChart.DayColor = Color.Black;
        DriveDChart.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DriveDChart.GradientBackground = false;
        DriveDChart.Location = new Point(139, 18);
        DriveDChart.Margin = new Padding(6, 4, 6, 4);
        DriveDChart.MaxValue = 100F;
        DriveDChart.Name = "DriveDChart";
        DriveDChart.PointColor = Color.FromArgb(11, 35, 116);
        DriveDChart.ShortDates = true;
        DriveDChart.Size = new Size(719, 211);
        DriveDChart.TabIndex = 18;
        DriveDChart.UseBezier = true;
        DriveDChart.UsePercent = true;
        // 
        // cuiBorder3
        // 
        cuiBorder3.Controls.Add(cuiLabel3);
        cuiBorder3.Controls.Add(cuiBorder4);
        cuiBorder3.Controls.Add(DriveDChart);
        cuiBorder3.Location = new Point(171, 463);
        cuiBorder3.Name = "cuiBorder3";
        cuiBorder3.OutlineThickness = 1F;
        cuiBorder3.PanelColor = Color.White;
        cuiBorder3.PanelOutlineColor = Color.White;
        cuiBorder3.Rounding = new Padding(10);
        cuiBorder3.Size = new Size(906, 233);
        cuiBorder3.TabIndex = 20;
        // 
        // cuiBorder4
        // 
        cuiBorder4.Controls.Add(cuiChartLine4);
        cuiBorder4.Location = new Point(446, 255);
        cuiBorder4.Name = "cuiBorder4";
        cuiBorder4.OutlineThickness = 1F;
        cuiBorder4.PanelColor = Color.White;
        cuiBorder4.PanelOutlineColor = Color.White;
        cuiBorder4.Rounding = new Padding(8);
        cuiBorder4.Size = new Size(536, 295);
        cuiBorder4.TabIndex = 20;
        // 
        // cuiChartLine4
        // 
        cuiChartLine4.AutoMaxValue = false;
        cuiChartLine4.AxisColor = Color.Black;
        cuiChartLine4.BackColor = Color.Transparent;
        cuiChartLine4.ChartLineColor = Color.FromArgb(11, 35, 116);
        cuiChartLine4.ChartPadding = 40;
        cuiChartLine4.CustomXAxis = new string[]
{
    "1",
    "2",
    "3"
};
        cuiChartLine4.DataPoints = new float[]
{
    100F,
    40F,
    80F,
    75F,
    100F,
    65F,
    60F
};
        cuiChartLine4.DayColor = Color.Black;
        cuiChartLine4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiChartLine4.GradientBackground = false;
        cuiChartLine4.Location = new Point(20, 18);
        cuiChartLine4.Margin = new Padding(6, 4, 6, 4);
        cuiChartLine4.MaxValue = 100F;
        cuiChartLine4.Name = "cuiChartLine4";
        cuiChartLine4.PointColor = Color.FromArgb(11, 35, 116);
        cuiChartLine4.ShortDates = true;
        cuiChartLine4.Size = new Size(560, 256);
        cuiChartLine4.TabIndex = 18;
        cuiChartLine4.UseBezier = true;
        cuiChartLine4.UsePercent = true;
        // 
        // cuiBorder5
        // 
        cuiBorder5.BackColor = Color.Transparent;
        cuiBorder5.Controls.Add(cuiLabel1);
        cuiBorder5.Controls.Add(ShortTermCheckbox);
        cuiBorder5.Controls.Add(DisplayResults);
        cuiBorder5.Controls.Add(CalendarDateLabel);
        cuiBorder5.Location = new Point(524, 16);
        cuiBorder5.Name = "cuiBorder5";
        cuiBorder5.OutlineThickness = 2F;
        cuiBorder5.PanelColor = Color.FromArgb(11, 35, 116);
        cuiBorder5.PanelOutlineColor = Color.FromArgb(241, 244, 254);
        cuiBorder5.Rounding = new Padding(8);
        cuiBorder5.Size = new Size(534, 166);
        cuiBorder5.TabIndex = 22;
        // 
        // cuiLabel1
        // 
        cuiLabel1.BackColor = Color.Transparent;
        cuiLabel1.Content = "Short\\ Term";
        cuiLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel1.ForeColor = Color.White;
        cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel1.Location = new Point(0, 15);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(107, 21);
        cuiLabel1.TabIndex = 27;
        // 
        // ShortTermCheckbox
        // 
        ShortTermCheckbox.BackColor = Color.FromArgb(11, 35, 116);
        ShortTermCheckbox.Checked = false;
        ShortTermCheckbox.CheckedForeground = Color.FromArgb(152, 148, 244);
        ShortTermCheckbox.CheckedOutlineColor = Color.FromArgb(152, 148, 244);
        ShortTermCheckbox.CheckedSymbolColor = Color.White;
        ShortTermCheckbox.Content = "cuiCheckbox";
        ShortTermCheckbox.ForeColor = SystemColors.ButtonShadow;
        ShortTermCheckbox.Location = new Point(113, 12);
        ShortTermCheckbox.MinimumSize = new Size(16, 16);
        ShortTermCheckbox.Name = "ShortTermCheckbox";
        ShortTermCheckbox.OutlineStyle = true;
        ShortTermCheckbox.OutlineThickness = 1F;
        ShortTermCheckbox.Rounding = 5;
        ShortTermCheckbox.ShowSymbols = true;
        ShortTermCheckbox.Size = new Size(32, 30);
        ShortTermCheckbox.TabIndex = 26;
        ShortTermCheckbox.Text = "cuiCheckbox1";
        ShortTermCheckbox.UncheckedForeground = Color.FromArgb(152, 148, 244);
        ShortTermCheckbox.UncheckedOutlineColor = Color.FromArgb(152, 148, 244);
        ShortTermCheckbox.UncheckedSymbolColor = Color.White;
        ShortTermCheckbox.Click += cuiCheckbox1_Click;
        // 
        // DisplayResults
        // 
        DisplayResults.BackColor = Color.Transparent;
        DisplayResults.CheckButton = false;
        DisplayResults.Checked = false;
        DisplayResults.CheckedBackground = Color.White;
        DisplayResults.CheckedForeColor = Color.Black;
        DisplayResults.CheckedImageTint = Color.White;
        DisplayResults.CheckedOutline = Color.White;
        DisplayResults.Content = "Display";
        DisplayResults.DialogResult = DialogResult.None;
        DisplayResults.Font = new Font("Microsoft Sans Serif", 9.75F);
        DisplayResults.ForeColor = Color.Black;
        DisplayResults.HoverBackground = Color.White;
        DisplayResults.HoveredImageTint = Color.White;
        DisplayResults.HoverForeColor = Color.Black;
        DisplayResults.HoverOutline = Color.Empty;
        DisplayResults.Image = null;
        DisplayResults.ImageAutoCenter = true;
        DisplayResults.ImageExpand = new Point(0, 0);
        DisplayResults.ImageOffset = new Point(0, 0);
        DisplayResults.ImageTint = Color.White;
        DisplayResults.Location = new Point(22, 77);
        DisplayResults.Name = "DisplayResults";
        DisplayResults.NormalBackground = Color.White;
        DisplayResults.NormalOutline = Color.Empty;
        DisplayResults.OutlineThickness = 1.6F;
        DisplayResults.PressedBackground = Color.White;
        DisplayResults.PressedForeColor = Color.White;
        DisplayResults.PressedImageTint = Color.White;
        DisplayResults.PressedOutline = Color.Empty;
        DisplayResults.Rounding = new Padding(8);
        DisplayResults.Size = new Size(112, 45);
        DisplayResults.TabIndex = 25;
        DisplayResults.TextOffset = new Point(0, 0);
        // 
        // CalendarDateLabel
        // 
        CalendarDateLabel.Controls.Add(EndHour);
        CalendarDateLabel.Controls.Add(EndHourLabel);
        CalendarDateLabel.Controls.Add(EndDateLabel);
        CalendarDateLabel.Controls.Add(EndDate);
        CalendarDateLabel.Controls.Add(StartHour);
        CalendarDateLabel.Controls.Add(StartDateLabel);
        CalendarDateLabel.Controls.Add(StartHourLabel);
        CalendarDateLabel.Controls.Add(StartDate);
        CalendarDateLabel.Location = new Point(169, 7);
        CalendarDateLabel.Name = "CalendarDateLabel";
        CalendarDateLabel.OutlineThickness = 1F;
        CalendarDateLabel.PanelColor = Color.White;
        CalendarDateLabel.PanelOutlineColor = Color.White;
        CalendarDateLabel.Rounding = new Padding(10);
        CalendarDateLabel.Size = new Size(338, 150);
        CalendarDateLabel.TabIndex = 32;
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
        EndHour.Location = new Point(197, 70);
        EndHour.Margin = new Padding(4);
        EndHour.Multiline = false;
        EndHour.Name = "EndHour";
        EndHour.Padding = new Padding(20, 6, 20, 0);
        EndHour.PasswordChar = false;
        EndHour.PlaceholderColor = Color.DimGray;
        EndHour.PlaceholderText = "14:00";
        EndHour.Rounding = 8;
        EndHour.Size = new Size(105, 33);
        EndHour.TabIndex = 31;
        EndHour.TextOffset = new Size(0, 0);
        EndHour.UnderlinedStyle = true;
        // 
        // EndHourLabel
        // 
        EndHourLabel.AllowDrop = true;
        EndHourLabel.BackColor = Color.White;
        EndHourLabel.Content = "End\\ Hour";
        EndHourLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        EndHourLabel.ForeColor = Color.FromArgb(11, 35, 116);
        EndHourLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        EndHourLabel.Location = new Point(172, 20);
        EndHourLabel.Margin = new Padding(4, 3, 4, 3);
        EndHourLabel.Name = "EndHourLabel";
        EndHourLabel.Size = new Size(130, 43);
        EndHourLabel.TabIndex = 31;
        // 
        // EndDateLabel
        // 
        EndDateLabel.BackColor = Color.White;
        EndDateLabel.Content = "End\\ Date";
        EndDateLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        EndDateLabel.ForeColor = Color.FromArgb(11, 35, 116);
        EndDateLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        EndDateLabel.Location = new Point(172, 20);
        EndDateLabel.Margin = new Padding(4, 3, 4, 3);
        EndDateLabel.Name = "EndDateLabel";
        EndDateLabel.Size = new Size(130, 43);
        EndDateLabel.TabIndex = 31;
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
        EndDate.Location = new Point(172, 57);
        EndDate.Margin = new Padding(4, 3, 4, 3);
        EndDate.Name = "EndDate";
        EndDate.NormalBackground = Color.White;
        EndDate.NormalOutline = Color.White;
        EndDate.OutlineThickness = 2F;
        EndDate.PressedBackground = Color.FromArgb(80, 128, 128, 128);
        EndDate.PressedOutline = Color.FromArgb(210, 128, 128, 128);
        EndDate.Rounding = 8;
        EndDate.ShowIcon = true;
        EndDate.Size = new Size(130, 58);
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
        StartHour.Location = new Point(57, 70);
        StartHour.Margin = new Padding(4);
        StartHour.Multiline = false;
        StartHour.Name = "StartHour";
        StartHour.Padding = new Padding(20, 6, 20, 0);
        StartHour.PasswordChar = false;
        StartHour.PlaceholderColor = Color.DimGray;
        StartHour.PlaceholderText = "12:00";
        StartHour.Rounding = 8;
        StartHour.Size = new Size(107, 33);
        StartHour.TabIndex = 30;
        StartHour.TextOffset = new Size(0, 0);
        StartHour.UnderlinedStyle = true;
        // 
        // StartDateLabel
        // 
        StartDateLabel.AllowDrop = true;
        StartDateLabel.BackColor = Color.White;
        StartDateLabel.Content = "Start\\ Date";
        StartDateLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        StartDateLabel.ForeColor = Color.FromArgb(11, 35, 116);
        StartDateLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        StartDateLabel.ImeMode = ImeMode.On;
        StartDateLabel.Location = new Point(34, 20);
        StartDateLabel.Margin = new Padding(4, 3, 4, 3);
        StartDateLabel.Name = "StartDateLabel";
        StartDateLabel.Size = new Size(130, 43);
        StartDateLabel.TabIndex = 29;
        // 
        // StartHourLabel
        // 
        StartHourLabel.AllowDrop = true;
        StartHourLabel.BackColor = Color.White;
        StartHourLabel.Content = "Start\\ Hour";
        StartHourLabel.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        StartHourLabel.ForeColor = Color.FromArgb(11, 35, 116);
        StartHourLabel.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        StartHourLabel.Location = new Point(34, 20);
        StartHourLabel.Margin = new Padding(4, 3, 4, 3);
        StartHourLabel.Name = "StartHourLabel";
        StartHourLabel.Size = new Size(130, 43);
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
        StartDate.Location = new Point(34, 57);
        StartDate.Margin = new Padding(4, 3, 4, 3);
        StartDate.Name = "StartDate";
        StartDate.NormalBackground = Color.White;
        StartDate.NormalOutline = Color.White;
        StartDate.OutlineThickness = 2F;
        StartDate.PressedBackground = Color.FromArgb(80, 128, 128, 128);
        StartDate.PressedOutline = Color.FromArgb(210, 128, 128, 128);
        StartDate.Rounding = 8;
        StartDate.ShowIcon = true;
        StartDate.Size = new Size(130, 58);
        StartDate.TabIndex = 28;
        StartDate.Theme = CuoreUI.Controls.Forms.DatePicker.Themes.Dark;
        StartDate.Value = new DateTime(2025, 3, 21, 0, 0, 0, 0);
        // 
        // cuiLabel2
        // 
        cuiLabel2.BackColor = Color.Transparent;
        cuiLabel2.Content = "Disk\\ C:";
        cuiLabel2.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel2.Location = new Point(13, 46);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(116, 41);
        cuiLabel2.TabIndex = 21;
        // 
        // cuiLabel3
        // 
        cuiLabel3.BackColor = Color.Transparent;
        cuiLabel3.Content = "Disk\\ D:";
        cuiLabel3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel3.Location = new Point(13, 45);
        cuiLabel3.Margin = new Padding(4, 3, 4, 3);
        cuiLabel3.Name = "cuiLabel3";
        cuiLabel3.Size = new Size(116, 41);
        cuiLabel3.TabIndex = 22;
        // 
        // cuiLabel4
        // 
        cuiLabel4.BackColor = Color.White;
        cuiLabel4.Content = "View\\ how\\ load\\ in\\ MB\\ on\\ computer\\ evolved\\ over\\ time";
        cuiLabel4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel4.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel4.Location = new Point(46, 95);
        cuiLabel4.Margin = new Padding(4, 3, 4, 3);
        cuiLabel4.Name = "cuiLabel4";
        cuiLabel4.Size = new Size(286, 53);
        cuiLabel4.TabIndex = 22;
        // 
        // cuiBorder6
        // 
        cuiBorder6.BackColor = Color.Transparent;
        cuiBorder6.Controls.Add(cuiLabel4);
        cuiBorder6.Location = new Point(171, 16);
        cuiBorder6.Name = "cuiBorder6";
        cuiBorder6.OutlineThickness = 1F;
        cuiBorder6.PanelColor = Color.White;
        cuiBorder6.PanelOutlineColor = Color.White;
        cuiBorder6.Rounding = new Padding(10);
        cuiBorder6.Size = new Size(342, 166);
        cuiBorder6.TabIndex = 23;
        // 
        // Drives
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(1227, 692);
        Controls.Add(cuiBorder3);
        Controls.Add(cuiBorder1);
        Controls.Add(cuiLabel13);
        Controls.Add(cuiBorder5);
        Controls.Add(cuiBorder6);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Drives";
        Text = "Drives";
        cuiBorder1.ResumeLayout(false);
        cuiBorder2.ResumeLayout(false);
        cuiBorder3.ResumeLayout(false);
        cuiBorder4.ResumeLayout(false);
        cuiBorder5.ResumeLayout(false);
        CalendarDateLabel.ResumeLayout(false);
        cuiBorder6.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private CuoreUI.Controls.cuiLabel cuiLabel13;
    private CuoreUI.Controls.Charts.cuiChartLine cuiChartLine1;
    private CuoreUI.Controls.cuiBorder cuiBorder1;
    public CuoreUI.Controls.Charts.cuiChartLine DriveCChart;
    private CuoreUI.Controls.cuiBorder cuiBorder2;
    public CuoreUI.Controls.Charts.cuiChartLine cuiChartLine2;
    public CuoreUI.Controls.Charts.cuiChartLine DriveDChart;
    private CuoreUI.Controls.cuiBorder cuiBorder3;
    private CuoreUI.Controls.cuiBorder cuiBorder4;
    public CuoreUI.Controls.Charts.cuiChartLine cuiChartLine4;
    private CuoreUI.Controls.cuiBorder cuiBorder5;
    private CuoreUI.Controls.cuiButton DisplayResults;
    private CuoreUI.Controls.cuiCheckbox ShortTermCheckbox;
    private CuoreUI.Controls.cuiLabel EndDateLabel;
    private CuoreUI.Controls.cuiLabel StartDateLabel;
    private CuoreUI.Controls.cuiCalendarDatePicker StartDate;
    private CuoreUI.Controls.cuiLabel cuiLabel1;
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
}
