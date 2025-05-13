using CuoreUI.Controls;

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
        MonitoreEnabledSwitch = new cuiSwitch();
        cuiPanel1 = new cuiBorder();
        StateValue = new cuiLabel();
        cuiLabel2 = new cuiLabel();
        cuiSeparator1 = new cuiSeparator();
        WorkstationName = new cuiLabel();
        DeleteWorkstationButton = new cuiButton();
        cuiLabel1 = new cuiLabel();
        cuiPanel2 = new cuiBorder();
        cuiPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // MonitoreEnabledSwitch
        // 
        MonitoreEnabledSwitch.CheckedBackground = Color.White;
        MonitoreEnabledSwitch.CheckedForeground = Color.FromArgb(9, 121, 105);
        MonitoreEnabledSwitch.CheckedOutlineColor = Color.FromArgb(9, 121, 105);
        MonitoreEnabledSwitch.ForeColor = Color.FromArgb(171, 171, 171);
        MonitoreEnabledSwitch.Location = new Point(175, 58);
        MonitoreEnabledSwitch.Name = "MonitoreEnabledSwitch";
        MonitoreEnabledSwitch.OutlineStyle = true;
        MonitoreEnabledSwitch.OutlineThickness = 1F;
        MonitoreEnabledSwitch.ShowSymbols = true;
        MonitoreEnabledSwitch.Size = new Size(62, 28);
        MonitoreEnabledSwitch.TabIndex = 0;
        MonitoreEnabledSwitch.ThumbSizeModifier = new Size(0, 0);
        MonitoreEnabledSwitch.UncheckedBackground = Color.White;
        MonitoreEnabledSwitch.UncheckedForeground = Color.FromArgb(194, 50, 50);
        MonitoreEnabledSwitch.UncheckedOutlineColor = Color.FromArgb(194, 50, 50);
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
        StateValue.HorizontalAlignment = cuiLabel.HorizontalAlignments.Center;
        StateValue.Location = new Point(84, 85);
        StateValue.Margin = new Padding(4, 3, 4, 3);
        StateValue.Name = "StateValue";
        StateValue.Size = new Size(153, 22);
        StateValue.TabIndex = 6;
        // 
        // cuiLabel2
        // 
        cuiLabel2.Content = "state";
        cuiLabel2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel2.HorizontalAlignment = cuiLabel.HorizontalAlignments.Center;
        cuiLabel2.Location = new Point(13, 85);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(84, 22);
        cuiLabel2.TabIndex = 5;
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
        WorkstationName.HorizontalAlignment = cuiLabel.HorizontalAlignments.Center;
        WorkstationName.Location = new Point(71, 13);
        WorkstationName.Margin = new Padding(4, 3, 4, 3);
        WorkstationName.Name = "WorkstationName";
        WorkstationName.Size = new Size(175, 32);
        WorkstationName.TabIndex = 3;
        // 
        // DeleteWorkstationButton
        // 
        DeleteWorkstationButton.CheckButton = false;
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
        DeleteWorkstationButton.ImageTint = Color.White;
        DeleteWorkstationButton.Location = new Point(71, 113);
        DeleteWorkstationButton.Name = "DeleteWorkstationButton";
        DeleteWorkstationButton.NormalBackground = Color.White;
        DeleteWorkstationButton.NormalOutline = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.OutlineThickness = 1F;
        DeleteWorkstationButton.PressedBackground = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.PressedForeColor = Color.White;
        DeleteWorkstationButton.PressedImageTint = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.PressedOutline = Color.FromArgb(169, 86, 81);
        DeleteWorkstationButton.Rounding = new Padding(8);
        DeleteWorkstationButton.Size = new Size(116, 31);
        DeleteWorkstationButton.TabIndex = 2;
        DeleteWorkstationButton.TextOffset = new Point(0, 0);
        DeleteWorkstationButton.Click += DeleteWorkstationButton_Click;
        // 
        // cuiLabel1
        // 
        cuiLabel1.Content = "monitore";
        cuiLabel1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel1.HorizontalAlignment = cuiLabel.HorizontalAlignments.Center;
        cuiLabel1.Location = new Point(13, 64);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(114, 22);
        cuiLabel1.TabIndex = 1;
        // 
        // cuiPanel2
        // 
        cuiPanel2.BackgroundImage = Resources.workstation__1_;
        cuiPanel2.BackgroundImageLayout = ImageLayout.Stretch;
        cuiPanel2.Location = new Point(13, 10);
        cuiPanel2.Name = "cuiPanel2";
        cuiPanel2.OutlineThickness = 1F;
        cuiPanel2.PanelColor = Color.Transparent;
        cuiPanel2.PanelOutlineColor = Color.Transparent;
        cuiPanel2.Rounding = new Padding(8);
        cuiPanel2.Size = new Size(51, 35);
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
    private CuoreUI.Controls.cuiBorder cuiPanel2;
    private CuoreUI.Controls.cuiButton DeleteWorkstationButton;
    private CuoreUI.Controls.cuiLabel cuiLabel1;
    public CuoreUI.Controls.cuiBorder cuiPanel1;
    private CuoreUI.Controls.cuiLabel WorkstationName;
    private CuoreUI.Controls.cuiSeparator cuiSeparator1;
    private CuoreUI.Controls.cuiLabel StateValue;
    private CuoreUI.Controls.cuiLabel cuiLabel2;
}
