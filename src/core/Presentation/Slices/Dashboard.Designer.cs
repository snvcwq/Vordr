namespace Presentation.Slices;

partial class Dashboard
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
        cuiCircleKnob3 = new CuoreUI.Controls.cuiCircleKnob();
        cuiLabel4 = new CuoreUI.Controls.cuiLabel();
        cuiBorder4 = new CuoreUI.Controls.cuiBorder();
        cuiBorder4.SuspendLayout();
        SuspendLayout();
        // 
        // cuiCircleKnob3
        // 
        cuiCircleKnob3.BackColor = Color.Transparent;
        cuiCircleKnob3.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiCircleKnob3.ForeColor = Color.Black;
        cuiCircleKnob3.KnobStyle = CuoreUI.Controls.cuiCircleKnob.KnobStyles.Arc;
        cuiCircleKnob3.Location = new Point(114, 41);
        cuiCircleKnob3.Margin = new Padding(8, 6, 8, 6);
        cuiCircleKnob3.MaxValue = 100F;
        cuiCircleKnob3.MinValue = 0F;
        cuiCircleKnob3.Name = "cuiCircleKnob3";
        cuiCircleKnob3.RightToLeft = RightToLeft.No;
        cuiCircleKnob3.ShowValueText = true;
        cuiCircleKnob3.Size = new Size(162, 162);
        cuiCircleKnob3.TabIndex = 0;
        cuiCircleKnob3.ThumbColor = Color.FromArgb(108, 124, 204);
        cuiCircleKnob3.TrackColor = Color.White;
        cuiCircleKnob3.TrackThickness = 10;
        cuiCircleKnob3.Value = 60F;
        // 
        // cuiLabel4
        // 
        cuiLabel4.BackColor = Color.Transparent;
        cuiLabel4.Content = "CPU\\ Usage:";
        cuiLabel4.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel4.Location = new Point(0, 6);
        cuiLabel4.Margin = new Padding(4, 3, 4, 3);
        cuiLabel4.Name = "cuiLabel4";
        cuiLabel4.Size = new Size(153, 47);
        cuiLabel4.TabIndex = 1;
        // 
        // cuiBorder4
        // 
        cuiBorder4.Controls.Add(cuiLabel4);
        cuiBorder4.Controls.Add(cuiCircleKnob3);
        cuiBorder4.Location = new Point(12, 12);
        cuiBorder4.Name = "cuiBorder4";
        cuiBorder4.OutlineThickness = 0F;
        cuiBorder4.PanelColor = Color.White;
        cuiBorder4.PanelOutlineColor = Color.FromArgb(241, 244, 254);
        cuiBorder4.Rounding = new Padding(8);
        cuiBorder4.Size = new Size(880, 601);
        cuiBorder4.TabIndex = 3;
        // 
        // Dashboard
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(913, 625);
        Controls.Add(cuiBorder4);
        Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "Dashboard";
        Text = "Dashboard";
        cuiBorder4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private CuoreUI.Controls.cuiCircleKnob cuiCircleKnob3;
    private CuoreUI.Controls.cuiLabel cuiLabel4;
    private CuoreUI.Controls.cuiBorder cuiBorder4;
}