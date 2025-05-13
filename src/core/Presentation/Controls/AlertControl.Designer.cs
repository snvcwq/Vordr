namespace Presentation.Controls;

partial class AlertControl
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
        cuiBorder1 = new CuoreUI.Controls.cuiBorder();
        ValueTextBox = new CuoreUI.Controls.cuiTextBox2();
        EnabledAlert = new CuoreUI.Controls.cuiSwitch();
        cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
        SaveButton = new CuoreUI.Controls.cuiButton();
        AlertDescription = new CuoreUI.Controls.cuiLabel();
        AlertName = new CuoreUI.Controls.cuiLabel();
        cuiBorder1.SuspendLayout();
        SuspendLayout();
        // 
        // cuiBorder1
        // 
        cuiBorder1.Controls.Add(ValueTextBox);
        cuiBorder1.Controls.Add(EnabledAlert);
        cuiBorder1.Controls.Add(cuiSeparator1);
        cuiBorder1.Controls.Add(SaveButton);
        cuiBorder1.Controls.Add(AlertDescription);
        cuiBorder1.Controls.Add(AlertName);
        cuiBorder1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiBorder1.Location = new Point(0, 0);
        cuiBorder1.Name = "cuiBorder1";
        cuiBorder1.OutlineThickness = 1F;
        cuiBorder1.PanelColor = Color.White;
        cuiBorder1.PanelOutlineColor = Color.White;
        cuiBorder1.Rounding = new Padding(10);
        cuiBorder1.Size = new Size(856, 150);
        cuiBorder1.TabIndex = 0;
        // 
        // ValueTextBox
        // 
        ValueTextBox.BackColor = Color.FromArgb(241, 244, 254);
        ValueTextBox.BorderColor = Color.FromArgb(64, 64, 64);
        ValueTextBox.BorderFocusColor = Color.FromArgb(255, 106, 0);
        ValueTextBox.BorderSize = 1;
        ValueTextBox.Content = "";
        ValueTextBox.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ValueTextBox.ForeColor = Color.Gray;
        ValueTextBox.Location = new Point(459, 55);
        ValueTextBox.Margin = new Padding(4);
        ValueTextBox.Multiline = false;
        ValueTextBox.Name = "ValueTextBox";
        ValueTextBox.Padding = new Padding(15, 5, 15, 0);
        ValueTextBox.PasswordChar = false;
        ValueTextBox.PlaceholderColor = Color.DimGray;
        ValueTextBox.PlaceholderText = "";
        ValueTextBox.Rounding = 8;
        ValueTextBox.Size = new Size(67, 24);
        ValueTextBox.TabIndex = 37;
        ValueTextBox.TextOffset = new Size(0, 0);
        ValueTextBox.UnderlinedStyle = false;
        // 
        // EnabledAlert
        // 
        EnabledAlert.BackColor = Color.Transparent;
        EnabledAlert.CheckedBackground = Color.White;
        EnabledAlert.CheckedForeground = Color.FromArgb(9, 121, 105);
        EnabledAlert.CheckedOutlineColor = Color.FromArgb(9, 121, 105);
        EnabledAlert.ForeColor = Color.White;
        EnabledAlert.Location = new Point(771, 17);
        EnabledAlert.Name = "EnabledAlert";
        EnabledAlert.OutlineStyle = true;
        EnabledAlert.OutlineThickness = 1F;
        EnabledAlert.ShowSymbols = true;
        EnabledAlert.Size = new Size(66, 29);
        EnabledAlert.TabIndex = 36;
        EnabledAlert.ThumbSizeModifier = new Size(0, 0);
        EnabledAlert.UncheckedBackground = Color.White;
        EnabledAlert.UncheckedForeground = Color.FromArgb(194, 50, 50);
        EnabledAlert.UncheckedOutlineColor = Color.FromArgb(194, 50, 50);
        EnabledAlert.Click += EnabledAlert_Click;
        // 
        // cuiSeparator1
        // 
        cuiSeparator1.ForeColor = Color.FromArgb(20, 39, 78);
        cuiSeparator1.Location = new Point(0, 34);
        cuiSeparator1.Margin = new Padding(4);
        cuiSeparator1.Name = "cuiSeparator1";
        cuiSeparator1.SeparatorMargin = 8;
        cuiSeparator1.Size = new Size(732, 14);
        cuiSeparator1.TabIndex = 35;
        cuiSeparator1.Thickness = 1F;
        cuiSeparator1.Vertical = false;
        // 
        // SaveButton
        // 
        SaveButton.BackColor = Color.Transparent;
        SaveButton.CheckButton = false;
        SaveButton.CheckedBackground = Color.FromArgb(108, 124, 204);
        SaveButton.CheckedForeColor = Color.White;
        SaveButton.CheckedImageTint = Color.FromArgb(108, 124, 204);
        SaveButton.CheckedOutline = Color.FromArgb(108, 124, 204);
        SaveButton.Content = "Save";
        SaveButton.DialogResult = DialogResult.None;
        SaveButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        SaveButton.ForeColor = Color.White;
        SaveButton.HoverBackground = Color.FromArgb(108, 124, 204);
        SaveButton.HoveredImageTint = Color.White;
        SaveButton.HoverForeColor = Color.White;
        SaveButton.HoverOutline = Color.FromArgb(108, 124, 204);
        SaveButton.Image = null;
        SaveButton.ImageAutoCenter = true;
        SaveButton.ImageExpand = new Point(0, 0);
        SaveButton.ImageOffset = new Point(0, 0);
        SaveButton.ImageTint = Color.White;
        SaveButton.Location = new Point(733, 94);
        SaveButton.Name = "SaveButton";
        SaveButton.NormalBackground = Color.FromArgb(108, 124, 204);
        SaveButton.NormalOutline = Color.FromArgb(108, 124, 204);
        SaveButton.OutlineThickness = 4F;
        SaveButton.PressedBackground = Color.FromArgb(11, 35, 116);
        SaveButton.PressedForeColor = Color.WhiteSmoke;
        SaveButton.PressedImageTint = Color.White;
        SaveButton.PressedOutline = Color.FromArgb(11, 35, 116);
        SaveButton.Rounding = new Padding(10);
        SaveButton.Size = new Size(104, 40);
        SaveButton.TabIndex = 34;
        SaveButton.TextOffset = new Point(0, 0);
        SaveButton.Click += SaveButton_Click;
        // 
        // AlertDescription
        // 
        AlertDescription.Content = "Your\\ text\\ here!";
        AlertDescription.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        AlertDescription.Location = new Point(15, 55);
        AlertDescription.Margin = new Padding(4, 3, 4, 3);
        AlertDescription.Name = "AlertDescription";
        AlertDescription.Size = new Size(582, 79);
        AlertDescription.TabIndex = 1;
        // 
        // AlertName
        // 
        AlertName.Content = "Your\\ text\\ here!";
        AlertName.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        AlertName.Location = new Point(27, 7);
        AlertName.Margin = new Padding(4, 3, 4, 3);
        AlertName.Name = "AlertName";
        AlertName.Size = new Size(537, 32);
        AlertName.TabIndex = 0;
        // 
        // AlertControl
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.Transparent;
        Controls.Add(cuiBorder1);
        Name = "AlertControl";
        Size = new Size(859, 150);
        cuiBorder1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private CuoreUI.Controls.cuiBorder cuiBorder1;
    private CuoreUI.Controls.cuiLabel AlertDescription;
    private CuoreUI.Controls.cuiLabel AlertName;
    private CuoreUI.Controls.cuiButton SaveButton;
    private CuoreUI.Controls.cuiSeparator cuiSeparator1;
    private CuoreUI.Controls.cuiSwitch EnabledAlert;
    private CuoreUI.Controls.cuiTextBox2 ValueTextBox;
}
