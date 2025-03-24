namespace Presentation.Slices;

partial class Monitoring
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
        cuiBorder1 = new CuoreUI.Controls.cuiBorder();
        cuiLabel2 = new CuoreUI.Controls.cuiLabel();
        cuiSwitch1 = new CuoreUI.Controls.cuiSwitch();
        cuiLabel1 = new CuoreUI.Controls.cuiLabel();
        tabPage1 = new TabPage();
        tabPage2 = new TabPage();
        cuiBorder2 = new CuoreUI.Controls.cuiBorder();
        cuiLabel3 = new CuoreUI.Controls.cuiLabel();
        cuiSwitch2 = new CuoreUI.Controls.cuiSwitch();
        cuiLabel4 = new CuoreUI.Controls.cuiLabel();
        cuiBorder3 = new CuoreUI.Controls.cuiBorder();
        cuiLabel5 = new CuoreUI.Controls.cuiLabel();
        cuiSwitch3 = new CuoreUI.Controls.cuiSwitch();
        cuiLabel6 = new CuoreUI.Controls.cuiLabel();
        cuiBorder4 = new CuoreUI.Controls.cuiBorder();
        cuiLabel7 = new CuoreUI.Controls.cuiLabel();
        cuiSwitch4 = new CuoreUI.Controls.cuiSwitch();
        cuiLabel8 = new CuoreUI.Controls.cuiLabel();
        cuiBorder5 = new CuoreUI.Controls.cuiBorder();
        cuiLabel9 = new CuoreUI.Controls.cuiLabel();
        cuiSwitch5 = new CuoreUI.Controls.cuiSwitch();
        cuiLabel10 = new CuoreUI.Controls.cuiLabel();
        cuiBorder6 = new CuoreUI.Controls.cuiBorder();
        cuiLabel11 = new CuoreUI.Controls.cuiLabel();
        cuiSwitch6 = new CuoreUI.Controls.cuiSwitch();
        cuiLabel12 = new CuoreUI.Controls.cuiLabel();
        cuiLabel13 = new CuoreUI.Controls.cuiLabel();
        cuiBorder1.SuspendLayout();
        cuiBorder2.SuspendLayout();
        cuiBorder3.SuspendLayout();
        cuiBorder4.SuspendLayout();
        cuiBorder5.SuspendLayout();
        cuiBorder6.SuspendLayout();
        SuspendLayout();
        // 
        // cuiBorder1
        // 
        cuiBorder1.Controls.Add(cuiLabel2);
        cuiBorder1.Controls.Add(cuiSwitch1);
        cuiBorder1.Controls.Add(cuiLabel1);
        cuiBorder1.Location = new Point(65, 148);
        cuiBorder1.Name = "cuiBorder1";
        cuiBorder1.OutlineThickness = 1F;
        cuiBorder1.PanelColor = Color.White;
        cuiBorder1.PanelOutlineColor = Color.White;
        cuiBorder1.Rounding = new Padding(12);
        cuiBorder1.Size = new Size(395, 147);
        cuiBorder1.TabIndex = 0;
        // 
        // cuiLabel2
        // 
        cuiLabel2.BackColor = Color.Transparent;
        cuiLabel2.Content = "Collect\\ real-time\\ imformation\\ about\\ load\\ on\\ Cpu\\ in\\ percentage\\ and\\ temperature\\ of\\ it\\ in\\ Celsius";
        cuiLabel2.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel2.Location = new Point(19, 65);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(292, 79);
        cuiLabel2.TabIndex = 10;
        cuiLabel2.Load += cuiLabel2_Load;
        // 
        // cuiSwitch1
        // 
        cuiSwitch1.BackColor = Color.Transparent;
        cuiSwitch1.Checked = false;
        cuiSwitch1.CheckedBackground = Color.White;
        cuiSwitch1.CheckedForeground = Color.FromArgb(20, 52, 69);
        cuiSwitch1.CheckedOutlineColor = Color.FromArgb(20, 52, 59);
        cuiSwitch1.ForeColor = Color.White;
        cuiSwitch1.Location = new Point(324, 18);
        cuiSwitch1.Name = "cuiSwitch1";
        cuiSwitch1.OutlineStyle = true;
        cuiSwitch1.OutlineThickness = 1F;
        cuiSwitch1.ShowSymbols = true;
        cuiSwitch1.Size = new Size(48, 27);
        cuiSwitch1.TabIndex = 9;
        cuiSwitch1.ThumbSizeModifier = new Size(0, 0);
        cuiSwitch1.UncheckedBackground = Color.White;
        cuiSwitch1.UncheckedForeground = Color.FromArgb(194, 50, 50);
        cuiSwitch1.UncheckedOutlineColor = Color.FromArgb(194, 50, 50);
        cuiSwitch1.Click += cuiSwitch1_Click;
        // 
        // cuiLabel1
        // 
        cuiLabel1.BackColor = Color.Transparent;
        cuiLabel1.Content = "\\ CPU";
        cuiLabel1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel1.Location = new Point(0, 18);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(189, 27);
        cuiLabel1.TabIndex = 0;
        // 
        // tabPage1
        // 
        tabPage1.Location = new Point(4, 46);
        tabPage1.Name = "tabPage1";
        tabPage1.Padding = new Padding(3);
        tabPage1.Size = new Size(192, 50);
        tabPage1.TabIndex = 0;
        tabPage1.Text = "tabPage1";
        tabPage1.UseVisualStyleBackColor = true;
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 46);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(192, 50);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // cuiBorder2
        // 
        cuiBorder2.Controls.Add(cuiLabel3);
        cuiBorder2.Controls.Add(cuiSwitch2);
        cuiBorder2.Controls.Add(cuiLabel4);
        cuiBorder2.Location = new Point(65, 331);
        cuiBorder2.Name = "cuiBorder2";
        cuiBorder2.OutlineThickness = 1F;
        cuiBorder2.PanelColor = Color.White;
        cuiBorder2.PanelOutlineColor = Color.White;
        cuiBorder2.Rounding = new Padding(12);
        cuiBorder2.Size = new Size(395, 147);
        cuiBorder2.TabIndex = 11;
        // 
        // cuiLabel3
        // 
        cuiLabel3.BackColor = Color.Transparent;
        cuiLabel3.Content = "Collect\\ real-time\\ imformation\\ about\\ load\\ on\\ Gpu\\ in\\ percentage,\\ temperature\\ of\\ it\\ in\\ Celsius\\ and\\ clock\\ speed";
        cuiLabel3.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel3.Location = new Point(19, 65);
        cuiLabel3.Margin = new Padding(4, 3, 4, 3);
        cuiLabel3.Name = "cuiLabel3";
        cuiLabel3.Size = new Size(292, 79);
        cuiLabel3.TabIndex = 10;
        // 
        // cuiSwitch2
        // 
        cuiSwitch2.BackColor = Color.Transparent;
        cuiSwitch2.Checked = false;
        cuiSwitch2.CheckedBackground = Color.White;
        cuiSwitch2.CheckedForeground = Color.FromArgb(20, 52, 59);
        cuiSwitch2.CheckedOutlineColor = Color.FromArgb(20, 52, 59);
        cuiSwitch2.ForeColor = Color.White;
        cuiSwitch2.Location = new Point(324, 18);
        cuiSwitch2.Name = "cuiSwitch2";
        cuiSwitch2.OutlineStyle = true;
        cuiSwitch2.OutlineThickness = 1F;
        cuiSwitch2.ShowSymbols = true;
        cuiSwitch2.Size = new Size(48, 27);
        cuiSwitch2.TabIndex = 9;
        cuiSwitch2.ThumbSizeModifier = new Size(0, 0);
        cuiSwitch2.UncheckedBackground = Color.White;
        cuiSwitch2.UncheckedForeground = Color.FromArgb(194, 50, 50);
        cuiSwitch2.UncheckedOutlineColor = Color.FromArgb(194, 50, 50);
        // 
        // cuiLabel4
        // 
        cuiLabel4.BackColor = Color.Transparent;
        cuiLabel4.Content = "\\ GPU";
        cuiLabel4.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel4.Location = new Point(0, 18);
        cuiLabel4.Margin = new Padding(4, 3, 4, 3);
        cuiLabel4.Name = "cuiLabel4";
        cuiLabel4.Size = new Size(189, 27);
        cuiLabel4.TabIndex = 0;
        cuiLabel4.Load += cuiLabel4_Load;
        // 
        // cuiBorder3
        // 
        cuiBorder3.Controls.Add(cuiLabel5);
        cuiBorder3.Controls.Add(cuiSwitch3);
        cuiBorder3.Controls.Add(cuiLabel6);
        cuiBorder3.Location = new Point(65, 510);
        cuiBorder3.Name = "cuiBorder3";
        cuiBorder3.OutlineThickness = 1F;
        cuiBorder3.PanelColor = Color.White;
        cuiBorder3.PanelOutlineColor = Color.White;
        cuiBorder3.Rounding = new Padding(12);
        cuiBorder3.Size = new Size(395, 147);
        cuiBorder3.TabIndex = 12;
        // 
        // cuiLabel5
        // 
        cuiLabel5.BackColor = Color.Transparent;
        cuiLabel5.Content = "Collect\\ real-time\\ imformation\\ about\\ power\\ supply\\ of\\ the\\ workstation,\\ battery\\ level\\ and\\ degradation\\ level\\ in\\ percentage";
        cuiLabel5.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel5.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel5.Location = new Point(19, 65);
        cuiLabel5.Margin = new Padding(4, 3, 4, 3);
        cuiLabel5.Name = "cuiLabel5";
        cuiLabel5.Size = new Size(292, 79);
        cuiLabel5.TabIndex = 10;
        // 
        // cuiSwitch3
        // 
        cuiSwitch3.BackColor = Color.Transparent;
        cuiSwitch3.Checked = false;
        cuiSwitch3.CheckedBackground = Color.White;
        cuiSwitch3.CheckedForeground = Color.FromArgb(20, 52, 59);
        cuiSwitch3.CheckedOutlineColor = Color.FromArgb(20, 52, 59);
        cuiSwitch3.ForeColor = Color.White;
        cuiSwitch3.Location = new Point(324, 18);
        cuiSwitch3.Name = "cuiSwitch3";
        cuiSwitch3.OutlineStyle = true;
        cuiSwitch3.OutlineThickness = 1F;
        cuiSwitch3.ShowSymbols = true;
        cuiSwitch3.Size = new Size(48, 27);
        cuiSwitch3.TabIndex = 9;
        cuiSwitch3.ThumbSizeModifier = new Size(0, 0);
        cuiSwitch3.UncheckedBackground = Color.White;
        cuiSwitch3.UncheckedForeground = Color.FromArgb(194, 50, 50);
        cuiSwitch3.UncheckedOutlineColor = Color.FromArgb(194, 50, 50);
        // 
        // cuiLabel6
        // 
        cuiLabel6.BackColor = Color.Transparent;
        cuiLabel6.Content = "Battery";
        cuiLabel6.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel6.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel6.Location = new Point(0, 18);
        cuiLabel6.Margin = new Padding(4, 3, 4, 3);
        cuiLabel6.Name = "cuiLabel6";
        cuiLabel6.Size = new Size(216, 41);
        cuiLabel6.TabIndex = 0;
        // 
        // cuiBorder4
        // 
        cuiBorder4.Controls.Add(cuiLabel7);
        cuiBorder4.Controls.Add(cuiSwitch4);
        cuiBorder4.Controls.Add(cuiLabel8);
        cuiBorder4.Location = new Point(527, 148);
        cuiBorder4.Name = "cuiBorder4";
        cuiBorder4.OutlineThickness = 1F;
        cuiBorder4.PanelColor = Color.White;
        cuiBorder4.PanelOutlineColor = Color.White;
        cuiBorder4.Rounding = new Padding(12);
        cuiBorder4.Size = new Size(360, 147);
        cuiBorder4.TabIndex = 13;
        // 
        // cuiLabel7
        // 
        cuiLabel7.BackColor = Color.Transparent;
        cuiLabel7.Content = "Collect\\ real-time\\ imformation\\ about\\ load\\ on\\ random\\ access\\ memory";
        cuiLabel7.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel7.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel7.Location = new Point(19, 65);
        cuiLabel7.Margin = new Padding(4, 3, 4, 3);
        cuiLabel7.Name = "cuiLabel7";
        cuiLabel7.Size = new Size(292, 79);
        cuiLabel7.TabIndex = 10;
        // 
        // cuiSwitch4
        // 
        cuiSwitch4.BackColor = Color.Transparent;
        cuiSwitch4.Checked = false;
        cuiSwitch4.CheckedBackground = Color.White;
        cuiSwitch4.CheckedForeground = Color.FromArgb(20, 52, 59);
        cuiSwitch4.CheckedOutlineColor = Color.FromArgb(20, 52, 59);
        cuiSwitch4.ForeColor = Color.White;
        cuiSwitch4.Location = new Point(298, 18);
        cuiSwitch4.Name = "cuiSwitch4";
        cuiSwitch4.OutlineStyle = true;
        cuiSwitch4.OutlineThickness = 1F;
        cuiSwitch4.ShowSymbols = true;
        cuiSwitch4.Size = new Size(48, 27);
        cuiSwitch4.TabIndex = 9;
        cuiSwitch4.ThumbSizeModifier = new Size(0, 0);
        cuiSwitch4.UncheckedBackground = Color.White;
        cuiSwitch4.UncheckedForeground = Color.FromArgb(194, 50, 50);
        cuiSwitch4.UncheckedOutlineColor = Color.FromArgb(194, 50, 50);
        // 
        // cuiLabel8
        // 
        cuiLabel8.BackColor = Color.Transparent;
        cuiLabel8.Content = "RAM";
        cuiLabel8.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel8.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel8.Location = new Point(0, 18);
        cuiLabel8.Margin = new Padding(4, 3, 4, 3);
        cuiLabel8.Name = "cuiLabel8";
        cuiLabel8.Size = new Size(216, 41);
        cuiLabel8.TabIndex = 0;
        // 
        // cuiBorder5
        // 
        cuiBorder5.Controls.Add(cuiLabel9);
        cuiBorder5.Controls.Add(cuiSwitch5);
        cuiBorder5.Controls.Add(cuiLabel10);
        cuiBorder5.Location = new Point(527, 331);
        cuiBorder5.Name = "cuiBorder5";
        cuiBorder5.OutlineThickness = 1F;
        cuiBorder5.PanelColor = Color.White;
        cuiBorder5.PanelOutlineColor = Color.White;
        cuiBorder5.Rounding = new Padding(12);
        cuiBorder5.Size = new Size(360, 147);
        cuiBorder5.TabIndex = 13;
        // 
        // cuiLabel9
        // 
        cuiLabel9.BackColor = Color.Transparent;
        cuiLabel9.Content = "Collect\\ real-time\\ imformation\\ about\\ data\\ storage\\ ";
        cuiLabel9.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel9.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel9.Location = new Point(19, 65);
        cuiLabel9.Margin = new Padding(4, 3, 4, 3);
        cuiLabel9.Name = "cuiLabel9";
        cuiLabel9.Size = new Size(327, 79);
        cuiLabel9.TabIndex = 10;
        // 
        // cuiSwitch5
        // 
        cuiSwitch5.BackColor = Color.Transparent;
        cuiSwitch5.Checked = false;
        cuiSwitch5.CheckedBackground = Color.White;
        cuiSwitch5.CheckedForeground = Color.FromArgb(20, 52, 59);
        cuiSwitch5.CheckedOutlineColor = Color.FromArgb(20, 52, 59);
        cuiSwitch5.ForeColor = Color.White;
        cuiSwitch5.Location = new Point(298, 18);
        cuiSwitch5.Name = "cuiSwitch5";
        cuiSwitch5.OutlineStyle = true;
        cuiSwitch5.OutlineThickness = 1F;
        cuiSwitch5.ShowSymbols = true;
        cuiSwitch5.Size = new Size(48, 27);
        cuiSwitch5.TabIndex = 9;
        cuiSwitch5.ThumbSizeModifier = new Size(0, 0);
        cuiSwitch5.UncheckedBackground = Color.White;
        cuiSwitch5.UncheckedForeground = Color.FromArgb(194, 50, 50);
        cuiSwitch5.UncheckedOutlineColor = Color.FromArgb(194, 50, 50);
        // 
        // cuiLabel10
        // 
        cuiLabel10.BackColor = Color.Transparent;
        cuiLabel10.Content = "\\ Drives";
        cuiLabel10.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel10.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel10.Location = new Point(0, 18);
        cuiLabel10.Margin = new Padding(4, 3, 4, 3);
        cuiLabel10.Name = "cuiLabel10";
        cuiLabel10.Size = new Size(216, 41);
        cuiLabel10.TabIndex = 0;
        // 
        // cuiBorder6
        // 
        cuiBorder6.Controls.Add(cuiLabel11);
        cuiBorder6.Controls.Add(cuiSwitch6);
        cuiBorder6.Controls.Add(cuiLabel12);
        cuiBorder6.Location = new Point(527, 510);
        cuiBorder6.Name = "cuiBorder6";
        cuiBorder6.OutlineThickness = 1F;
        cuiBorder6.PanelColor = Color.White;
        cuiBorder6.PanelOutlineColor = Color.White;
        cuiBorder6.Rounding = new Padding(12);
        cuiBorder6.Size = new Size(360, 147);
        cuiBorder6.TabIndex = 13;
        // 
        // cuiLabel11
        // 
        cuiLabel11.BackColor = Color.Transparent;
        cuiLabel11.Content = "Collect\\ real-time\\ imformation\\ about\\ all\\ active\\ processes\\ on\\ workstation";
        cuiLabel11.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel11.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel11.Location = new Point(19, 65);
        cuiLabel11.Margin = new Padding(4, 3, 4, 3);
        cuiLabel11.Name = "cuiLabel11";
        cuiLabel11.Size = new Size(327, 79);
        cuiLabel11.TabIndex = 10;
        // 
        // cuiSwitch6
        // 
        cuiSwitch6.BackColor = Color.Transparent;
        cuiSwitch6.Checked = false;
        cuiSwitch6.CheckedBackground = Color.White;
        cuiSwitch6.CheckedForeground = Color.FromArgb(20, 52, 59);
        cuiSwitch6.CheckedOutlineColor = Color.FromArgb(20, 52, 59);
        cuiSwitch6.ForeColor = Color.White;
        cuiSwitch6.Location = new Point(298, 18);
        cuiSwitch6.Name = "cuiSwitch6";
        cuiSwitch6.OutlineStyle = true;
        cuiSwitch6.OutlineThickness = 1F;
        cuiSwitch6.ShowSymbols = true;
        cuiSwitch6.Size = new Size(48, 27);
        cuiSwitch6.TabIndex = 9;
        cuiSwitch6.ThumbSizeModifier = new Size(0, 0);
        cuiSwitch6.UncheckedBackground = Color.White;
        cuiSwitch6.UncheckedForeground = Color.FromArgb(194, 50, 50);
        cuiSwitch6.UncheckedOutlineColor = Color.FromArgb(194, 50, 50);
        // 
        // cuiLabel12
        // 
        cuiLabel12.BackColor = Color.Transparent;
        cuiLabel12.Content = "\\ Processes";
        cuiLabel12.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel12.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel12.Location = new Point(0, 18);
        cuiLabel12.Margin = new Padding(4, 3, 4, 3);
        cuiLabel12.Name = "cuiLabel12";
        cuiLabel12.Size = new Size(268, 41);
        cuiLabel12.TabIndex = 0;
        cuiLabel12.Load += cuiLabel12_Load;
        // 
        // cuiLabel13
        // 
        cuiLabel13.Content = "Configure\\ monitoring\\ settings";
        cuiLabel13.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel13.ForeColor = Color.FromArgb(11, 35, 116);
        cuiLabel13.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel13.Location = new Point(8, 28);
        cuiLabel13.Margin = new Padding(4, 3, 4, 3);
        cuiLabel13.Name = "cuiLabel13";
        cuiLabel13.Size = new Size(368, 79);
        cuiLabel13.TabIndex = 14;
        // 
        // Monitoring
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(1227, 692);
        Controls.Add(cuiLabel13);
        Controls.Add(cuiBorder6);
        Controls.Add(cuiBorder5);
        Controls.Add(cuiBorder4);
        Controls.Add(cuiBorder3);
        Controls.Add(cuiBorder2);
        Controls.Add(cuiBorder1);
        Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "Monitoring";
        Text = "Monitoring";
        Load += Monitoring_Load;
        cuiBorder1.ResumeLayout(false);
        cuiBorder2.ResumeLayout(false);
        cuiBorder3.ResumeLayout(false);
        cuiBorder4.ResumeLayout(false);
        cuiBorder5.ResumeLayout(false);
        cuiBorder6.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private CuoreUI.Controls.cuiBorder cuiBorder1;
    private CuoreUI.Controls.cuiLabel cuiLabel1;
    private CuoreUI.Controls.cuiSwitch cuiSwitch1;
    private TabPage tabPage1;
    private TabPage tabPage2;
    private CuoreUI.Controls.cuiLabel cuiLabel2;
    private CuoreUI.Controls.cuiBorder cuiBorder2;
    private CuoreUI.Controls.cuiLabel cuiLabel3;
    private CuoreUI.Controls.cuiSwitch cuiSwitch2;
    private CuoreUI.Controls.cuiLabel cuiLabel4;
    private CuoreUI.Controls.cuiBorder cuiBorder3;
    private CuoreUI.Controls.cuiLabel cuiLabel5;
    private CuoreUI.Controls.cuiSwitch cuiSwitch3;
    private CuoreUI.Controls.cuiLabel cuiLabel6;
    private CuoreUI.Controls.cuiBorder cuiBorder4;
    private CuoreUI.Controls.cuiLabel cuiLabel7;
    private CuoreUI.Controls.cuiSwitch cuiSwitch4;
    private CuoreUI.Controls.cuiLabel cuiLabel8;
    private CuoreUI.Controls.cuiBorder cuiBorder5;
    private CuoreUI.Controls.cuiLabel cuiLabel9;
    private CuoreUI.Controls.cuiSwitch cuiSwitch5;
    private CuoreUI.Controls.cuiLabel cuiLabel10;
    private CuoreUI.Controls.cuiBorder cuiBorder6;
    private CuoreUI.Controls.cuiLabel cuiLabel11;
    private CuoreUI.Controls.cuiSwitch cuiSwitch6;
    private CuoreUI.Controls.cuiLabel cuiLabel12;
    private CuoreUI.Controls.cuiLabel cuiLabel13;
}