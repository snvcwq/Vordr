namespace Presentation.Controls;

partial class WorkstationControl
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        MonitoreEnabledSwitch = new CuoreUI.Controls.cuiSwitch();
        cuiPanel1 = new CuoreUI.Controls.cuiPanel();
        StateValue = new CuoreUI.Controls.cuiLabel();
        cuiLabel2 = new CuoreUI.Controls.cuiLabel();
        cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
        WorkstationName = new CuoreUI.Controls.cuiLabel();
        DeleteWorkstationButton = new CuoreUI.Controls.cuiButton();
        cuiLabel1 = new CuoreUI.Controls.cuiLabel();
        cuiPanel2 = new CuoreUI.Controls.cuiPanel();
        cuiPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // MonitoreEnabledSwitch
        // 
        MonitoreEnabledSwitch.CheckedBackground = Color.White;
        MonitoreEnabledSwitch.CheckedForeground = Color.FromArgb(43, 152, 121);
        MonitoreEnabledSwitch.CheckedOutlineColor = Color.FromArgb(43, 152, 121);
        MonitoreEnabledSwitch.CheckedSymbolColor = Color.White;
        MonitoreEnabledSwitch.ForeColor = Color.FromArgb(171, 171, 171);
        MonitoreEnabledSwitch.Location = new Point(175, 58);
        MonitoreEnabledSwitch.Name = "MonitoreEnabledSwitch";
        MonitoreEnabledSwitch.OutlineThickness = 1F;
        MonitoreEnabledSwitch.ShowSymbols = true;
        MonitoreEnabledSwitch.Size = new Size(62, 28);
        MonitoreEnabledSwitch.TabIndex = 0;
        MonitoreEnabledSwitch.ThumbSizeModifier = new Size(0, 0);
        MonitoreEnabledSwitch.UncheckedBackground = Color.White;
        MonitoreEnabledSwitch.UncheckedForeground = Color.FromArgb(169, 86, 81);
        MonitoreEnabledSwitch.UncheckedOutlineColor = Color.FromArgb(169, 86, 81);
        MonitoreEnabledSwitch.UncheckedSymbolColor = Color.White;
        MonitoreEnabledSwitch.CheckedChanged += MonitoreEnabledSwitch_CheckedChanged;
        // 
        // cuiPanel1
        // 
        cuiPanel1.AccessibleRole = AccessibleRole.MenuItem;
        cuiPanel1.AllowDrop = true;
        cuiPanel1.AutoScroll = true;
        cuiPanel1.AutoSize = true;
        cuiPanel1.Controls.Add(StateValue);
        cuiPanel1.Controls.Add(cuiLabel2);
        cuiPanel1.Controls.Add(cuiSeparator1);
        cuiPanel1.Controls.Add(WorkstationName);
        cuiPanel1.Controls.Add(DeleteWorkstationButton);
        cuiPanel1.Controls.Add(cuiLabel1);
        cuiPanel1.Controls.Add(MonitoreEnabledSwitch);
        cuiPanel1.Controls.Add(cuiPanel2);
        cuiPanel1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiPanel1.ImeMode = ImeMode.On;
        cuiPanel1.Location = new Point(0, 3);
        cuiPanel1.Name = "cuiPanel1";
        cuiPanel1.OutlineThickness = 1F;
        cuiPanel1.PanelColor = Color.White;
        cuiPanel1.PanelOutlineColor = Color.White;
        cuiPanel1.Rounding = new Padding(10);
        cuiPanel1.Size = new Size(253, 147);
        cuiPanel1.TabIndex = 2;
        // 
        // StateValue
        // 
        StateValue.Content = "";
        StateValue.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        StateValue.HorizontalAlignment = StringAlignment.Center;
        StateValue.Location = new Point(84, 85);
        StateValue.Margin = new Padding(4, 3, 4, 3);
        StateValue.Name = "StateValue";
        StateValue.Size = new Size(153, 22);
        StateValue.TabIndex = 6;
        StateValue.VerticalAlignment = StringAlignment.Near;
        // 
        // cuiLabel2
        // 
        cuiLabel2.Content = "state";
        cuiLabel2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel2.HorizontalAlignment = StringAlignment.Center;
        cuiLabel2.Location = new Point(13, 85);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(84, 22);
        cuiLabel2.TabIndex = 5;
        cuiLabel2.VerticalAlignment = StringAlignment.Near;
        // 
        // cuiSeparator1
        // 
        cuiSeparator1.ForeColor = Color.FromArgb(128, 128, 128, 128);
        cuiSeparator1.Location = new Point(1, 48);
        cuiSeparator1.Margin = new Padding(4, 3, 4, 3);
        cuiSeparator1.Name = "cuiSeparator1";
        cuiSeparator1.SeparatorMargin = 8;
        cuiSeparator1.Size = new Size(245, 10);
        cuiSeparator1.TabIndex = 4;
        cuiSeparator1.Thickness = 0.5F;
        cuiSeparator1.Vertical = false;
        // 
        // WorkstationName
        // 
        WorkstationName.Content = "";
        WorkstationName.HorizontalAlignment = StringAlignment.Center;
        WorkstationName.Location = new Point(71, 13);
        WorkstationName.Margin = new Padding(4, 3, 4, 3);
        WorkstationName.Name = "WorkstationName";
        WorkstationName.Size = new Size(175, 32);
        WorkstationName.TabIndex = 3;
        WorkstationName.VerticalAlignment = StringAlignment.Near;
        // 
        // DeleteWorkstationButton
        // 
        DeleteWorkstationButton.CheckButton = false;
        DeleteWorkstationButton.Checked = false;
        DeleteWorkstationButton.CheckedBackground = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.CheckedForeColor = Color.White;
        DeleteWorkstationButton.CheckedImageTint = Color.White;
        DeleteWorkstationButton.CheckedOutline = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.Content = "Remove";
        DeleteWorkstationButton.DialogResult = DialogResult.None;
        DeleteWorkstationButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        DeleteWorkstationButton.ForeColor = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.HoverBackground = Color.White;
        DeleteWorkstationButton.HoveredImageTint = Color.White;
        DeleteWorkstationButton.HoverForeColor = Color.Maroon;
        DeleteWorkstationButton.HoverOutline = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.Image = null;
        DeleteWorkstationButton.ImageAutoCenter = true;
        DeleteWorkstationButton.ImageExpand = new Point(0, 0);
        DeleteWorkstationButton.ImageOffset = new Point(0, 0);
        DeleteWorkstationButton.Location = new Point(71, 113);
        DeleteWorkstationButton.Name = "DeleteWorkstationButton";
        DeleteWorkstationButton.NormalBackground = Color.White;
        DeleteWorkstationButton.NormalForeColor = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.NormalImageTint = Color.White;
        DeleteWorkstationButton.NormalOutline = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.OutlineThickness = 1F;
        DeleteWorkstationButton.PressedBackground = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.PressedForeColor = Color.White;
        DeleteWorkstationButton.PressedImageTint = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.PressedOutline = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.Rounding = new Padding(8);
        DeleteWorkstationButton.Size = new Size(116, 31);
        DeleteWorkstationButton.TabIndex = 2;
        DeleteWorkstationButton.TextAlignment = StringAlignment.Center;
        DeleteWorkstationButton.TextOffset = new Point(0, 0);
        DeleteWorkstationButton.Click += DeleteWorkstationButton_Click;
        // 
        // cuiLabel1
        // 
        cuiLabel1.Content = "monitore";
        cuiLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel1.HorizontalAlignment = StringAlignment.Center;
        cuiLabel1.Location = new Point(13, 64);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(114, 22);
        cuiLabel1.TabIndex = 1;
        cuiLabel1.VerticalAlignment = StringAlignment.Near;
        // 
        // cuiPanel2
        // 
        cuiPanel2.BackgroundImage = Resources.workstation;
        cuiPanel2.BackgroundImageLayout = ImageLayout.Stretch;
        cuiPanel2.Location = new Point(13, 13);
        cuiPanel2.Name = "cuiPanel2";
        cuiPanel2.OutlineThickness = 1F;
        cuiPanel2.PanelColor = Color.Transparent;
        cuiPanel2.PanelOutlineColor = Color.Transparent;
        cuiPanel2.Rounding = new Padding(8);
        cuiPanel2.Size = new Size(51, 32);
        cuiPanel2.TabIndex = 0;
        // 
        // WorkstationControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Transparent;
        Controls.Add(cuiPanel1);
        Margin = new Padding(10);
        Name = "WorkstationControl";
        Size = new Size(275, 150);
        cuiPanel1.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private CuoreUI.Controls.cuiSwitch MonitoreEnabledSwitch;
    private CuoreUI.Controls.cuiPanel cuiPanel2;
    private CuoreUI.Controls.cuiButton DeleteWorkstationButton;
    private CuoreUI.Controls.cuiLabel cuiLabel1;
    public CuoreUI.Controls.cuiPanel cuiPanel1;
    private CuoreUI.Controls.cuiLabel WorkstationName;
    private CuoreUI.Controls.cuiSeparator cuiSeparator1;
    private CuoreUI.Controls.cuiLabel StateValue;
    private CuoreUI.Controls.cuiLabel cuiLabel2;
}
