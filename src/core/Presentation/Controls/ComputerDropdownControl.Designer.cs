namespace Presentation.Controls;

partial class ComputerDropdownControl
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
        WorkstationName = new CuoreUI.Controls.cuiButton();
        SuspendLayout();
        // 
        // WorkstationName
        // 
        WorkstationName.CheckButton = false;
        WorkstationName.CheckedBackground = Color.FromArgb(255, 106, 0);
        WorkstationName.CheckedForeColor = Color.White;
        WorkstationName.CheckedImageTint = Color.White;
        WorkstationName.CheckedOutline = Color.FromArgb(255, 106, 0);
        WorkstationName.Content = "Your text here!";
        WorkstationName.DialogResult = DialogResult.None;
        WorkstationName.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        WorkstationName.ForeColor = Color.FromArgb(108, 124, 204);
        WorkstationName.HoverBackground = Color.White;
        WorkstationName.HoveredImageTint = SystemColors.Window;
        WorkstationName.HoverForeColor = Color.FromArgb(108, 124, 204);
        WorkstationName.HoverOutline = Color.Transparent;
        WorkstationName.Image = null;
        WorkstationName.ImageAutoCenter = true;
        WorkstationName.ImageExpand = new Point(0, 0);
        WorkstationName.ImageOffset = new Point(0, 0);
        WorkstationName.ImageTint = Color.White;
        WorkstationName.Location = new Point(0, 0);
        WorkstationName.Margin = new Padding(0);
        WorkstationName.Name = "WorkstationName";
        WorkstationName.NormalBackground = Color.White;
        WorkstationName.NormalOutline = Color.White;
        WorkstationName.OutlineThickness = 1F;
        WorkstationName.PressedBackground = Color.White;
        WorkstationName.PressedForeColor = Color.FromArgb(32, 32, 32);
        WorkstationName.PressedImageTint = Color.White;
        WorkstationName.PressedOutline = Color.White;
        WorkstationName.Rounding = new Padding(0);
        WorkstationName.Size = new Size(178, 37);
        WorkstationName.TabIndex = 0;
        WorkstationName.TextOffset = new Point(0, 0);
        WorkstationName.Click += WorkstationName_Click;
        // 
        // ComputerDropdownControl
        // 
        AutoScaleDimensions = new SizeF(9F, 16F);
        AutoScaleMode = AutoScaleMode.Font;
        Controls.Add(WorkstationName);
        Font = new Font("Century", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        Margin = new Padding(4, 3, 4, 3);
        Name = "ComputerDropdownControl";
        Size = new Size(178, 38);
        ResumeLayout(false);
    }

    #endregion

    private CuoreUI.Controls.cuiButton WorkstationName;
}
