namespace Presentation.Slices;

partial class Processes
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
        cuiLabel13 = new CuoreUI.Controls.cuiLabel();
        ProcessesGrid2 = new CuoreUI.Controls.cuiDataGridView();
        SuspendLayout();
        // 
        // cuiLabel13
        // 
        cuiLabel13.Content = "View\\ active\\ processes\\ on\\ workstation";
        cuiLabel13.Font = new Font("Century Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        cuiLabel13.ForeColor = Color.FromArgb(11, 35, 116);
        cuiLabel13.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel13.Location = new Point(2, 26);
        cuiLabel13.Margin = new Padding(4, 3, 4, 3);
        cuiLabel13.Name = "cuiLabel13";
        cuiLabel13.Size = new Size(368, 79);
        cuiLabel13.TabIndex = 15;
        // 
        // ProcessesGrid2
        // 
        ProcessesGrid2.Cell = Color.White;
        ProcessesGrid2.Cell2 = Color.FromArgb(224, 224, 224);
        ProcessesGrid2.CellBorder = Color.Black;
        ProcessesGrid2.CellHover = Color.Transparent;
        ProcessesGrid2.CellSelect = Color.Transparent;
        ProcessesGrid2.DataSource = null;
        ProcessesGrid2.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        ProcessesGrid2.HeaderColor = Color.FromArgb(152, 148, 244);
        ProcessesGrid2.Location = new Point(22, 127);
        ProcessesGrid2.Name = "ProcessesGrid2";
        ProcessesGrid2.Rounding = 8;
        ProcessesGrid2.Size = new Size(1090, 553);
        ProcessesGrid2.TabIndex = 17;
        ProcessesGrid2.Text = "Processes2";
        // 
        // Processes
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(1227, 692);
        Controls.Add(ProcessesGrid2);
        Controls.Add(cuiLabel13);
        Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "Processes";
        Text = "Processes";
        ResumeLayout(false);
    }

    #endregion

    private CuoreUI.Controls.cuiLabel cuiLabel13;
    private CuoreUI.Controls.cuiDataGridView ProcessesGrid2;
}
