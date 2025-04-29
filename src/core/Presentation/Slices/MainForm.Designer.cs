namespace Presentation.Slices;

partial class MainForm
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        panel2 = new Panel();
        BatteryButton = new CuoreUI.Controls.cuiButtonGroup();
        DrivesButton = new CuoreUI.Controls.cuiButtonGroup();
        NotificationButton = new CuoreUI.Controls.cuiButtonGroup();
        NetworkButton = new CuoreUI.Controls.cuiButtonGroup();
        SettingsButton = new CuoreUI.Controls.cuiButtonGroup();
        GpuButton = new CuoreUI.Controls.cuiButtonGroup();
        CpuButton = new CuoreUI.Controls.cuiButtonGroup();
        RamButton = new CuoreUI.Controls.cuiButtonGroup();
        DashboardButton = new CuoreUI.Controls.cuiButtonGroup();
        ProcessButton = new CuoreUI.Controls.cuiButtonGroup();
        AppName = new CuoreUI.Controls.cuiLabel();
        cuiButton1 = new CuoreUI.Controls.cuiButton();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        tabPage3 = new TabPage();
        tabPage4 = new TabPage();
        panel1 = new Panel();
        MaximizeButton = new CuoreUI.Controls.cuiButtonGroup();
        MainPannel = new Panel();
        MinimizeButton = new CuoreUI.Controls.cuiButtonGroup();
        CloseButton = new CuoreUI.Controls.cuiButtonGroup();
        MainPanel = new Panel();
        CollectProcessesWorker = new System.ComponentModel.BackgroundWorker();
        CollectHardwareWorker = new System.ComponentModel.BackgroundWorker();
        panel2.SuspendLayout();
        panel1.SuspendLayout();
        SuspendLayout();
        // 
        // panel2
        // 
        panel2.BackColor = Color.White;
        panel2.Controls.Add(BatteryButton);
        panel2.Controls.Add(DrivesButton);
        panel2.Controls.Add(NotificationButton);
        panel2.Controls.Add(NetworkButton);
        panel2.Controls.Add(SettingsButton);
        panel2.Controls.Add(GpuButton);
        panel2.Controls.Add(CpuButton);
        panel2.Controls.Add(RamButton);
        panel2.Controls.Add(DashboardButton);
        panel2.Controls.Add(ProcessButton);
        panel2.Controls.Add(AppName);
        panel2.Controls.Add(cuiButton1);
        panel2.Dock = DockStyle.Left;
        panel2.Location = new Point(0, 22);
        panel2.Name = "panel2";
        panel2.Size = new Size(204, 774);
        panel2.TabIndex = 2;
        // 
        // BatteryButton
        // 
        BatteryButton.BackColor = Color.Transparent;
        BatteryButton.Checked = false;
        BatteryButton.CheckedBackground = Color.FromArgb(241, 244, 254);
        BatteryButton.CheckedForeColor = Color.FromArgb(140, 140, 244);
        BatteryButton.CheckedImageTint = Color.FromArgb(140, 140, 244);
        BatteryButton.CheckedOutline = Color.FromArgb(140, 140, 244);
        BatteryButton.Content = "Battery";
        BatteryButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        BatteryButton.ForeColor = Color.FromArgb(11, 35, 116);
        BatteryButton.Group = 0;
        BatteryButton.HoverBackground = Color.White;
        BatteryButton.HoveredImageTint = Color.White;
        BatteryButton.HoverForeColor = Color.FromArgb(140, 140, 244);
        BatteryButton.HoverOutline = Color.FromArgb(140, 140, 244);
        BatteryButton.Image = Resources.BatteryIcon;
        BatteryButton.ImageAutoCenter = true;
        BatteryButton.ImageExpand = new Point(0, 0);
        BatteryButton.ImageOffset = new Point(-40, 0);
        BatteryButton.Location = new Point(24, 565);
        BatteryButton.Margin = new Padding(4);
        BatteryButton.Name = "BatteryButton";
        BatteryButton.NormalBackground = Color.White;
        BatteryButton.NormalOutline = Color.White;
        BatteryButton.OutlineThickness = 0F;
        BatteryButton.PressedBackground = Color.FromArgb(241, 244, 254);
        BatteryButton.PressedForeColor = Color.FromArgb(140, 140, 244);
        BatteryButton.PressedImageTint = Color.FromArgb(140, 140, 244);
        BatteryButton.PressedOutline = Color.FromArgb(140, 140, 244);
        BatteryButton.RightToLeft = RightToLeft.No;
        BatteryButton.Rounding = new Padding(8);
        BatteryButton.Size = new Size(191, 56);
        BatteryButton.TabIndex = 30;
        BatteryButton.TextOffset = new Point(-20, 0);
        BatteryButton.Click += BatteryButton_Click;
        // 
        // DrivesButton
        // 
        DrivesButton.BackColor = Color.Transparent;
        DrivesButton.Checked = false;
        DrivesButton.CheckedBackground = Color.FromArgb(241, 244, 254);
        DrivesButton.CheckedForeColor = Color.FromArgb(140, 140, 244);
        DrivesButton.CheckedImageTint = Color.FromArgb(140, 140, 244);
        DrivesButton.CheckedOutline = Color.FromArgb(140, 140, 244);
        DrivesButton.Content = "Drives";
        DrivesButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        DrivesButton.ForeColor = Color.FromArgb(11, 35, 116);
        DrivesButton.Group = 0;
        DrivesButton.HoverBackground = Color.White;
        DrivesButton.HoveredImageTint = Color.White;
        DrivesButton.HoverForeColor = Color.FromArgb(140, 140, 244);
        DrivesButton.HoverOutline = Color.FromArgb(140, 140, 244);
        DrivesButton.Image = Resources.DrivesIcon;
        DrivesButton.ImageAutoCenter = true;
        DrivesButton.ImageExpand = new Point(0, 0);
        DrivesButton.ImageOffset = new Point(-40, 0);
        DrivesButton.Location = new Point(24, 501);
        DrivesButton.Margin = new Padding(4);
        DrivesButton.Name = "DrivesButton";
        DrivesButton.NormalBackground = Color.White;
        DrivesButton.NormalOutline = Color.White;
        DrivesButton.OutlineThickness = 0F;
        DrivesButton.PressedBackground = Color.FromArgb(241, 244, 254);
        DrivesButton.PressedForeColor = Color.FromArgb(140, 140, 244);
        DrivesButton.PressedImageTint = Color.FromArgb(140, 140, 244);
        DrivesButton.PressedOutline = Color.FromArgb(140, 140, 244);
        DrivesButton.RightToLeft = RightToLeft.No;
        DrivesButton.Rounding = new Padding(8);
        DrivesButton.Size = new Size(191, 56);
        DrivesButton.TabIndex = 29;
        DrivesButton.TextOffset = new Point(-20, 0);
        DrivesButton.Click += DrivesButton_Click;
        // 
        // NotificationButton
        // 
        NotificationButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        NotificationButton.Checked = false;
        NotificationButton.CheckedBackground = Color.FromArgb(241, 244, 254);
        NotificationButton.CheckedForeColor = Color.FromArgb(241, 244, 254);
        NotificationButton.CheckedImageTint = Color.FromArgb(241, 244, 254);
        NotificationButton.CheckedOutline = Color.FromArgb(241, 244, 254);
        NotificationButton.Content = "";
        NotificationButton.Font = new Font("Microsoft Sans Serif", 9.75F);
        NotificationButton.ForeColor = Color.White;
        NotificationButton.Group = 0;
        NotificationButton.HoverBackground = Color.FromArgb(241, 244, 254);
        NotificationButton.HoveredImageTint = Color.FromArgb(241, 244, 254);
        NotificationButton.HoverForeColor = Color.FromArgb(241, 244, 254);
        NotificationButton.HoverOutline = Color.Empty;
        NotificationButton.Image = Resources.notification_bell;
        NotificationButton.ImageAutoCenter = true;
        NotificationButton.ImageExpand = new Point(3, 3);
        NotificationButton.ImageOffset = new Point(0, 0);
        NotificationButton.Location = new Point(113, 9);
        NotificationButton.Margin = new Padding(9);
        NotificationButton.Name = "NotificationButton";
        NotificationButton.NormalBackground = Color.FromArgb(241, 244, 254);
        NotificationButton.NormalOutline = Color.Empty;
        NotificationButton.OutlineThickness = 1.6F;
        NotificationButton.PressedBackground = Color.FromArgb(241, 244, 254);
        NotificationButton.PressedForeColor = Color.FromArgb(241, 244, 254);
        NotificationButton.PressedImageTint = Color.FromArgb(241, 244, 254);
        NotificationButton.PressedOutline = Color.Empty;
        NotificationButton.Rounding = new Padding(8);
        NotificationButton.Size = new Size(34, 34);
        NotificationButton.TabIndex = 23;
        NotificationButton.TextOffset = new Point(0, 0);
        // 
        // NetworkButton
        // 
        NetworkButton.BackColor = Color.Transparent;
        NetworkButton.Checked = false;
        NetworkButton.CheckedBackground = Color.FromArgb(241, 244, 254);
        NetworkButton.CheckedForeColor = Color.FromArgb(140, 140, 244);
        NetworkButton.CheckedImageTint = Color.FromArgb(140, 140, 244);
        NetworkButton.CheckedOutline = Color.FromArgb(140, 140, 244);
        NetworkButton.Content = "Network";
        NetworkButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        NetworkButton.ForeColor = Color.FromArgb(11, 35, 116);
        NetworkButton.Group = 0;
        NetworkButton.HoverBackground = Color.White;
        NetworkButton.HoveredImageTint = Color.White;
        NetworkButton.HoverForeColor = Color.FromArgb(140, 140, 244);
        NetworkButton.HoverOutline = Color.FromArgb(140, 140, 244);
        NetworkButton.Image = Resources.NetworkIcon;
        NetworkButton.ImageAutoCenter = true;
        NetworkButton.ImageExpand = new Point(0, 0);
        NetworkButton.ImageOffset = new Point(-30, 0);
        NetworkButton.Location = new Point(24, 437);
        NetworkButton.Margin = new Padding(4);
        NetworkButton.Name = "NetworkButton";
        NetworkButton.NormalBackground = Color.White;
        NetworkButton.NormalOutline = Color.White;
        NetworkButton.OutlineThickness = 0F;
        NetworkButton.PressedBackground = Color.FromArgb(241, 244, 254);
        NetworkButton.PressedForeColor = Color.FromArgb(140, 140, 244);
        NetworkButton.PressedImageTint = Color.FromArgb(140, 140, 244);
        NetworkButton.PressedOutline = Color.FromArgb(140, 140, 244);
        NetworkButton.RightToLeft = RightToLeft.No;
        NetworkButton.Rounding = new Padding(8);
        NetworkButton.Size = new Size(191, 56);
        NetworkButton.TabIndex = 28;
        NetworkButton.TextOffset = new Point(-20, 0);
        NetworkButton.Click += NetworkButton_Click;
        // 
        // SettingsButton
        // 
        SettingsButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        SettingsButton.Checked = false;
        SettingsButton.CheckedBackground = Color.FromArgb(241, 244, 254);
        SettingsButton.CheckedForeColor = Color.FromArgb(241, 244, 254);
        SettingsButton.CheckedImageTint = Color.FromArgb(241, 244, 254);
        SettingsButton.CheckedOutline = Color.FromArgb(241, 244, 254);
        SettingsButton.Content = "";
        SettingsButton.Font = new Font("Microsoft Sans Serif", 9.75F);
        SettingsButton.ForeColor = Color.White;
        SettingsButton.Group = 0;
        SettingsButton.HoverBackground = Color.FromArgb(241, 244, 254);
        SettingsButton.HoveredImageTint = Color.FromArgb(241, 244, 254);
        SettingsButton.HoverForeColor = Color.FromArgb(241, 244, 254);
        SettingsButton.HoverOutline = Color.Empty;
        SettingsButton.Image = Resources.setting;
        SettingsButton.ImageAutoCenter = true;
        SettingsButton.ImageExpand = new Point(3, 3);
        SettingsButton.ImageOffset = new Point(0, 0);
        SettingsButton.Location = new Point(165, 9);
        SettingsButton.Margin = new Padding(9);
        SettingsButton.Name = "SettingsButton";
        SettingsButton.NormalBackground = Color.FromArgb(241, 244, 254);
        SettingsButton.NormalOutline = Color.Empty;
        SettingsButton.OutlineThickness = 1.6F;
        SettingsButton.PressedBackground = Color.FromArgb(241, 244, 254);
        SettingsButton.PressedForeColor = Color.FromArgb(241, 244, 254);
        SettingsButton.PressedImageTint = Color.FromArgb(241, 244, 254);
        SettingsButton.PressedOutline = Color.Empty;
        SettingsButton.Rounding = new Padding(8);
        SettingsButton.Size = new Size(33, 34);
        SettingsButton.TabIndex = 22;
        SettingsButton.TextOffset = new Point(0, 0);
        SettingsButton.Click += SettingsButton_Click;
        // 
        // GpuButton
        // 
        GpuButton.BackColor = Color.Transparent;
        GpuButton.Checked = false;
        GpuButton.CheckedBackground = Color.FromArgb(241, 244, 254);
        GpuButton.CheckedForeColor = Color.FromArgb(140, 140, 244);
        GpuButton.CheckedImageTint = Color.FromArgb(140, 140, 244);
        GpuButton.CheckedOutline = Color.FromArgb(140, 140, 244);
        GpuButton.Content = "Gpu Usage";
        GpuButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        GpuButton.ForeColor = Color.FromArgb(11, 35, 116);
        GpuButton.Group = 0;
        GpuButton.HoverBackground = Color.White;
        GpuButton.HoveredImageTint = Color.White;
        GpuButton.HoverForeColor = Color.FromArgb(140, 140, 244);
        GpuButton.HoverOutline = Color.FromArgb(140, 140, 244);
        GpuButton.Image = Resources.GpuIcon;
        GpuButton.ImageAutoCenter = true;
        GpuButton.ImageExpand = new Point(0, 0);
        GpuButton.ImageOffset = new Point(-24, 0);
        GpuButton.Location = new Point(24, 373);
        GpuButton.Margin = new Padding(4);
        GpuButton.Name = "GpuButton";
        GpuButton.NormalBackground = Color.White;
        GpuButton.NormalOutline = Color.White;
        GpuButton.OutlineThickness = 0F;
        GpuButton.PressedBackground = Color.FromArgb(241, 244, 254);
        GpuButton.PressedForeColor = Color.FromArgb(140, 140, 244);
        GpuButton.PressedImageTint = Color.FromArgb(140, 140, 244);
        GpuButton.PressedOutline = Color.FromArgb(140, 140, 244);
        GpuButton.RightToLeft = RightToLeft.No;
        GpuButton.Rounding = new Padding(8);
        GpuButton.Size = new Size(191, 56);
        GpuButton.TabIndex = 27;
        GpuButton.TextOffset = new Point(-20, 0);
        GpuButton.Click += GpuButton_Click;
        // 
        // CpuButton
        // 
        CpuButton.BackColor = Color.Transparent;
        CpuButton.Checked = false;
        CpuButton.CheckedBackground = Color.FromArgb(241, 244, 254);
        CpuButton.CheckedForeColor = Color.FromArgb(140, 140, 244);
        CpuButton.CheckedImageTint = Color.FromArgb(140, 140, 244);
        CpuButton.CheckedOutline = Color.FromArgb(140, 140, 244);
        CpuButton.Content = "CPU Usage";
        CpuButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        CpuButton.ForeColor = Color.FromArgb(11, 35, 116);
        CpuButton.Group = 0;
        CpuButton.HoverBackground = Color.White;
        CpuButton.HoveredImageTint = Color.White;
        CpuButton.HoverForeColor = Color.FromArgb(140, 140, 244);
        CpuButton.HoverOutline = Color.FromArgb(140, 140, 244);
        CpuButton.Image = Resources.CpuIcon;
        CpuButton.ImageAutoCenter = true;
        CpuButton.ImageExpand = new Point(0, 0);
        CpuButton.ImageOffset = new Point(-24, 0);
        CpuButton.Location = new Point(24, 309);
        CpuButton.Margin = new Padding(4);
        CpuButton.Name = "CpuButton";
        CpuButton.NormalBackground = Color.White;
        CpuButton.NormalOutline = Color.White;
        CpuButton.OutlineThickness = 0F;
        CpuButton.PressedBackground = Color.FromArgb(241, 244, 254);
        CpuButton.PressedForeColor = Color.FromArgb(140, 140, 244);
        CpuButton.PressedImageTint = Color.FromArgb(140, 140, 244);
        CpuButton.PressedOutline = Color.FromArgb(140, 140, 244);
        CpuButton.RightToLeft = RightToLeft.No;
        CpuButton.Rounding = new Padding(8);
        CpuButton.Size = new Size(191, 56);
        CpuButton.TabIndex = 26;
        CpuButton.TextOffset = new Point(-20, 0);
        CpuButton.Click += CpuButton_Click;
        // 
        // RamButton
        // 
        RamButton.BackColor = Color.Transparent;
        RamButton.Checked = false;
        RamButton.CheckedBackground = Color.FromArgb(241, 244, 254);
        RamButton.CheckedForeColor = Color.FromArgb(140, 140, 244);
        RamButton.CheckedImageTint = Color.FromArgb(140, 140, 244);
        RamButton.CheckedOutline = Color.FromArgb(140, 140, 244);
        RamButton.Content = "RAM Usage";
        RamButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        RamButton.ForeColor = Color.FromArgb(11, 35, 116);
        RamButton.Group = 0;
        RamButton.HoverBackground = Color.White;
        RamButton.HoveredImageTint = Color.White;
        RamButton.HoverForeColor = Color.FromArgb(140, 140, 244);
        RamButton.HoverOutline = Color.FromArgb(140, 140, 244);
        RamButton.Image = Resources.RamIcon;
        RamButton.ImageAutoCenter = true;
        RamButton.ImageExpand = new Point(0, 0);
        RamButton.ImageOffset = new Point(-24, 0);
        RamButton.Location = new Point(24, 245);
        RamButton.Margin = new Padding(4);
        RamButton.Name = "RamButton";
        RamButton.NormalBackground = Color.White;
        RamButton.NormalOutline = Color.White;
        RamButton.OutlineThickness = 0F;
        RamButton.PressedBackground = Color.FromArgb(241, 244, 254);
        RamButton.PressedForeColor = Color.FromArgb(140, 140, 244);
        RamButton.PressedImageTint = Color.FromArgb(140, 140, 244);
        RamButton.PressedOutline = Color.FromArgb(140, 140, 244);
        RamButton.RightToLeft = RightToLeft.No;
        RamButton.Rounding = new Padding(8);
        RamButton.Size = new Size(191, 56);
        RamButton.TabIndex = 25;
        RamButton.TextOffset = new Point(-20, 0);
        RamButton.Click += RamButton_Click;
        // 
        // DashboardButton
        // 
        DashboardButton.BackColor = Color.Transparent;
        DashboardButton.Checked = false;
        DashboardButton.CheckedBackground = Color.FromArgb(241, 244, 254);
        DashboardButton.CheckedForeColor = Color.FromArgb(140, 140, 244);
        DashboardButton.CheckedImageTint = Color.FromArgb(140, 140, 244);
        DashboardButton.CheckedOutline = Color.FromArgb(140, 140, 244);
        DashboardButton.Content = "Dashboard";
        DashboardButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        DashboardButton.ForeColor = Color.FromArgb(11, 35, 116);
        DashboardButton.Group = 0;
        DashboardButton.HoverBackground = Color.White;
        DashboardButton.HoveredImageTint = Color.White;
        DashboardButton.HoverForeColor = Color.FromArgb(140, 140, 244);
        DashboardButton.HoverOutline = Color.FromArgb(140, 140, 244);
        DashboardButton.Image = Resources.DashboardIcon;
        DashboardButton.ImageAutoCenter = true;
        DashboardButton.ImageExpand = new Point(0, 0);
        DashboardButton.ImageOffset = new Point(-24, 0);
        DashboardButton.Location = new Point(24, 117);
        DashboardButton.Margin = new Padding(4);
        DashboardButton.Name = "DashboardButton";
        DashboardButton.NormalBackground = Color.White;
        DashboardButton.NormalOutline = Color.White;
        DashboardButton.OutlineThickness = 0F;
        DashboardButton.PressedBackground = Color.FromArgb(241, 244, 254);
        DashboardButton.PressedForeColor = Color.FromArgb(140, 140, 244);
        DashboardButton.PressedImageTint = Color.FromArgb(140, 140, 244);
        DashboardButton.PressedOutline = Color.FromArgb(140, 140, 244);
        DashboardButton.RightToLeft = RightToLeft.No;
        DashboardButton.Rounding = new Padding(8);
        DashboardButton.Size = new Size(191, 56);
        DashboardButton.TabIndex = 24;
        DashboardButton.TextOffset = new Point(-20, 0);
        DashboardButton.Click += DashboardButton_Click_2;
        // 
        // ProcessButton
        // 
        ProcessButton.BackColor = Color.Transparent;
        ProcessButton.Checked = false;
        ProcessButton.CheckedBackground = Color.FromArgb(241, 244, 254);
        ProcessButton.CheckedForeColor = Color.FromArgb(140, 140, 244);
        ProcessButton.CheckedImageTint = Color.FromArgb(140, 140, 244);
        ProcessButton.CheckedOutline = Color.FromArgb(140, 140, 244);
        ProcessButton.Content = "Processes";
        ProcessButton.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        ProcessButton.ForeColor = Color.FromArgb(11, 35, 116);
        ProcessButton.Group = 0;
        ProcessButton.HoverBackground = Color.White;
        ProcessButton.HoveredImageTint = Color.White;
        ProcessButton.HoverForeColor = Color.FromArgb(140, 140, 244);
        ProcessButton.HoverOutline = Color.FromArgb(140, 140, 244);
        ProcessButton.Image = Resources.ProcessListIcon;
        ProcessButton.ImageAutoCenter = true;
        ProcessButton.ImageExpand = new Point(0, 0);
        ProcessButton.ImageOffset = new Point(-30, 0);
        ProcessButton.Location = new Point(24, 181);
        ProcessButton.Margin = new Padding(4);
        ProcessButton.Name = "ProcessButton";
        ProcessButton.NormalBackground = Color.White;
        ProcessButton.NormalOutline = Color.White;
        ProcessButton.OutlineThickness = 0F;
        ProcessButton.PressedBackground = Color.FromArgb(241, 244, 254);
        ProcessButton.PressedForeColor = Color.FromArgb(140, 140, 244);
        ProcessButton.PressedImageTint = Color.FromArgb(140, 140, 244);
        ProcessButton.PressedOutline = Color.FromArgb(140, 140, 244);
        ProcessButton.RightToLeft = RightToLeft.No;
        ProcessButton.Rounding = new Padding(8);
        ProcessButton.Size = new Size(191, 56);
        ProcessButton.TabIndex = 23;
        ProcessButton.TextOffset = new Point(-20, 0);
        ProcessButton.Click += ProcessButton_Click;
        // 
        // AppName
        // 
        AppName.BackColor = Color.Transparent;
        AppName.Content = "ordR";
        AppName.Font = new Font("Century Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        AppName.Location = new Point(79, 49);
        AppName.Margin = new Padding(4, 3, 4, 3);
        AppName.Name = "AppName";
        AppName.Size = new Size(63, 25);
        AppName.TabIndex = 20;
        // 
        // cuiButton1
        // 
        cuiButton1.CheckButton = false;
        cuiButton1.Checked = false;
        cuiButton1.CheckedBackground = Color.White;
        cuiButton1.CheckedForeColor = Color.White;
        cuiButton1.CheckedImageTint = Color.White;
        cuiButton1.CheckedOutline = Color.White;
        cuiButton1.Content = "";
        cuiButton1.DialogResult = DialogResult.None;
        cuiButton1.Font = new Font("Microsoft Sans Serif", 9.75F);
        cuiButton1.ForeColor = Color.White;
        cuiButton1.HoverBackground = Color.White;
        cuiButton1.HoveredImageTint = Color.White;
        cuiButton1.HoverForeColor = Color.White;
        cuiButton1.HoverOutline = Color.Empty;
        cuiButton1.Image = Resources.letter_v;
        cuiButton1.ImageAutoCenter = true;
        cuiButton1.ImageExpand = new Point(30, 30);
        cuiButton1.ImageOffset = new Point(0, 0);
        cuiButton1.Location = new Point(12, 6);
        cuiButton1.Name = "cuiButton1";
        cuiButton1.NormalBackground = Color.White;
        cuiButton1.NormalOutline = Color.Empty;
        cuiButton1.OutlineThickness = 1.6F;
        cuiButton1.PressedBackground = Color.White;
        cuiButton1.PressedForeColor = Color.White;
        cuiButton1.PressedImageTint = Color.White;
        cuiButton1.PressedOutline = Color.Empty;
        cuiButton1.Rounding = new Padding(8);
        cuiButton1.Size = new Size(97, 82);
        cuiButton1.TabIndex = 19;
        cuiButton1.TextOffset = new Point(0, 0);
        // 
        // tabPage1
        // 
        tabPage1.Location = new Point(4, 46);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(625, 65);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 46);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(625, 65);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        tabPage3.Location = new Point(4, 46);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(192, 50);
        tabPage3.TabIndex = 0;
        tabPage3.Text = "tabPage3";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // tabPage4
        // 
        tabPage4.Location = new Point(4, 46);
        tabPage4.Name = "tabPage4";
        tabPage4.Padding = new Padding(3);
        tabPage4.Size = new Size(192, 50);
        tabPage4.TabIndex = 1;
        tabPage4.Text = "tabPage4";
        tabPage4.UseVisualStyleBackColor = true;
        // 
        // panel1
        // 
        panel1.BackColor = Color.FromArgb(108, 124, 204);
        panel1.Controls.Add(MaximizeButton);
        panel1.Controls.Add(MainPannel);
        panel1.Controls.Add(MinimizeButton);
        panel1.Controls.Add(CloseButton);
        panel1.Dock = DockStyle.Top;
        panel1.Location = new Point(0, 0);
        panel1.Name = "panel1";
        panel1.Size = new Size(1500, 22);
        panel1.TabIndex = 1;
        panel1.Paint += panel1_Paint;
        panel1.MouseDown += panel1_MouseDown;
        // 
        // MaximizeButton
        // 
        MaximizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        MaximizeButton.BackColor = Color.FromArgb(108, 124, 204);
        MaximizeButton.Checked = false;
        MaximizeButton.CheckedBackground = Color.FromArgb(108, 124, 204);
        MaximizeButton.CheckedForeColor = Color.FromArgb(108, 124, 204);
        MaximizeButton.CheckedImageTint = Color.FromArgb(108, 124, 204);
        MaximizeButton.CheckedOutline = Color.FromArgb(108, 124, 204);
        MaximizeButton.Content = "";
        MaximizeButton.Font = new Font("Microsoft Sans Serif", 9.75F);
        MaximizeButton.ForeColor = Color.FromArgb(108, 124, 204);
        MaximizeButton.Group = 0;
        MaximizeButton.HoverBackground = Color.FromArgb(108, 124, 204);
        MaximizeButton.HoveredImageTint = Color.FromArgb(108, 124, 204);
        MaximizeButton.HoverForeColor = Color.FromArgb(108, 124, 204);
        MaximizeButton.HoverOutline = Color.Empty;
        MaximizeButton.Image = Resources.maximize;
        MaximizeButton.ImageAutoCenter = true;
        MaximizeButton.ImageExpand = new Point(3, 3);
        MaximizeButton.ImageOffset = new Point(0, 0);
        MaximizeButton.Location = new Point(1454, 0);
        MaximizeButton.Margin = new Padding(9);
        MaximizeButton.Name = "MaximizeButton";
        MaximizeButton.NormalBackground = Color.FromArgb(108, 124, 204);
        MaximizeButton.NormalOutline = Color.Empty;
        MaximizeButton.OutlineThickness = 1.6F;
        MaximizeButton.PressedBackground = Color.FromArgb(241, 244, 254);
        MaximizeButton.PressedForeColor = Color.FromArgb(241, 244, 254);
        MaximizeButton.PressedImageTint = Color.FromArgb(241, 244, 254);
        MaximizeButton.PressedOutline = Color.Empty;
        MaximizeButton.Rounding = new Padding(8);
        MaximizeButton.Size = new Size(24, 22);
        MaximizeButton.TabIndex = 24;
        MaximizeButton.TextOffset = new Point(0, 0);
        MaximizeButton.Click += MaximizeButton_Click;
        // 
        // MainPannel
        // 
        MainPannel.Location = new Point(200, 34);
        MainPannel.Name = "MainPannel";
        MainPannel.Size = new Size(945, 842);
        MainPannel.TabIndex = 3;
        // 
        // MinimizeButton
        // 
        MinimizeButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        MinimizeButton.BackColor = Color.FromArgb(108, 124, 204);
        MinimizeButton.Checked = false;
        MinimizeButton.CheckedBackground = Color.FromArgb(108, 124, 204);
        MinimizeButton.CheckedForeColor = Color.FromArgb(108, 124, 204);
        MinimizeButton.CheckedImageTint = Color.FromArgb(108, 124, 204);
        MinimizeButton.CheckedOutline = Color.FromArgb(108, 124, 204);
        MinimizeButton.Content = "";
        MinimizeButton.Font = new Font("Microsoft Sans Serif", 9.75F);
        MinimizeButton.ForeColor = Color.FromArgb(108, 124, 204);
        MinimizeButton.Group = 0;
        MinimizeButton.HoverBackground = Color.FromArgb(108, 124, 204);
        MinimizeButton.HoveredImageTint = Color.FromArgb(108, 124, 204);
        MinimizeButton.HoverForeColor = Color.FromArgb(108, 124, 204);
        MinimizeButton.HoverOutline = Color.Empty;
        MinimizeButton.Image = Resources.minus;
        MinimizeButton.ImageAutoCenter = true;
        MinimizeButton.ImageExpand = new Point(3, 3);
        MinimizeButton.ImageOffset = new Point(0, 0);
        MinimizeButton.Location = new Point(1430, 0);
        MinimizeButton.Margin = new Padding(9);
        MinimizeButton.Name = "MinimizeButton";
        MinimizeButton.NormalBackground = Color.FromArgb(108, 124, 204);
        MinimizeButton.NormalOutline = Color.Empty;
        MinimizeButton.OutlineThickness = 1.6F;
        MinimizeButton.PressedBackground = Color.FromArgb(241, 244, 254);
        MinimizeButton.PressedForeColor = Color.FromArgb(241, 244, 254);
        MinimizeButton.PressedImageTint = Color.FromArgb(241, 244, 254);
        MinimizeButton.PressedOutline = Color.Empty;
        MinimizeButton.Rounding = new Padding(8);
        MinimizeButton.Size = new Size(25, 22);
        MinimizeButton.TabIndex = 22;
        MinimizeButton.TextOffset = new Point(0, 0);
        MinimizeButton.Click += MinimizeButton_Click;
        // 
        // CloseButton
        // 
        CloseButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        CloseButton.BackColor = Color.FromArgb(108, 124, 204);
        CloseButton.Checked = false;
        CloseButton.CheckedBackground = Color.FromArgb(108, 124, 204);
        CloseButton.CheckedForeColor = Color.FromArgb(108, 124, 204);
        CloseButton.CheckedImageTint = Color.FromArgb(108, 124, 204);
        CloseButton.CheckedOutline = Color.FromArgb(108, 124, 204);
        CloseButton.Content = "";
        CloseButton.Font = new Font("Microsoft Sans Serif", 9.75F);
        CloseButton.ForeColor = Color.FromArgb(108, 124, 204);
        CloseButton.Group = 0;
        CloseButton.HoverBackground = Color.FromArgb(108, 124, 204);
        CloseButton.HoveredImageTint = Color.FromArgb(108, 124, 204);
        CloseButton.HoverForeColor = Color.FromArgb(108, 124, 204);
        CloseButton.HoverOutline = Color.Empty;
        CloseButton.Image = Resources.delete__1_;
        CloseButton.ImageAutoCenter = true;
        CloseButton.ImageExpand = new Point(3, 3);
        CloseButton.ImageOffset = new Point(0, 0);
        CloseButton.Location = new Point(1473, 0);
        CloseButton.Margin = new Padding(9);
        CloseButton.Name = "CloseButton";
        CloseButton.NormalBackground = Color.FromArgb(108, 124, 204);
        CloseButton.NormalOutline = Color.Empty;
        CloseButton.OutlineThickness = 1.6F;
        CloseButton.PressedBackground = Color.FromArgb(241, 244, 254);
        CloseButton.PressedForeColor = Color.FromArgb(241, 244, 254);
        CloseButton.PressedImageTint = Color.FromArgb(241, 244, 254);
        CloseButton.PressedOutline = Color.Empty;
        CloseButton.Rounding = new Padding(8);
        CloseButton.Size = new Size(27, 22);
        CloseButton.TabIndex = 21;
        CloseButton.TextOffset = new Point(0, 0);
        CloseButton.Click += CloseButton_Click;
        // 
        // MainPanel
        // 
        MainPanel.BackColor = Color.FromArgb(155, 164, 180);
        MainPanel.Location = new Point(203, 22);
        MainPanel.Name = "MainPanel";
        MainPanel.Size = new Size(1297, 774);
        MainPanel.TabIndex = 3;
        // 
        // CollectProcessesWorker
        // 
        CollectProcessesWorker.DoWork += CollectProcessesWorker_DoWork;
        // 
        // CollectHardwareWorker
        // 
        CollectHardwareWorker.DoWork += CollectHardwareWorker_DoWork;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        AutoSizeMode = AutoSizeMode.GrowAndShrink;
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(1500, 796);
        Controls.Add(MainPanel);
        Controls.Add(panel2);
        Controls.Add(panel1);
        Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Name = "MainForm";
        StartPosition = FormStartPosition.WindowsDefaultBounds;
        Text = "Form1";
        WindowState = FormWindowState.Maximized;
        Load += Form1_Load;
        panel2.ResumeLayout(false);
        panel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private Panel panel2;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private CuoreUI.Controls.cuiCalendarDatePicker cuiCalendarDatePicker1;
    private CuoreUI.Controls.cuiButton cuiButton1;
    private CuoreUI.Controls.cuiLabel AppName;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private Panel panel1;
    private CuoreUI.Controls.cuiButtonGroup ProcessButton;
    private CuoreUI.Controls.cuiButtonGroup BatteryButton;
    private CuoreUI.Controls.cuiButtonGroup DrivesButton;
    private CuoreUI.Controls.cuiButtonGroup NetworkButton;
    private CuoreUI.Controls.cuiButtonGroup GpuButton;
    private CuoreUI.Controls.cuiButtonGroup CpuButton;
    private CuoreUI.Controls.cuiButtonGroup RamButton;
    private CuoreUI.Controls.cuiButtonGroup DashboardButton;
    private CuoreUI.Controls.cuiButtonGroup CloseButton;
    private CuoreUI.Controls.cuiButtonGroup NotificationButton;
    private CuoreUI.Controls.cuiButtonGroup SettingsButton;
    private CuoreUI.Controls.cuiButtonGroup MinimizeButton;
    private Panel MainPannel;
    private Panel MainPanel;
    private CuoreUI.Controls.cuiButtonGroup MaximizeButton;
    private System.ComponentModel.BackgroundWorker CollectProcessesWorker;
    private System.ComponentModel.BackgroundWorker CollectHardwareWorker;
}
