using CuoreUI.Controls;

namespace Presentation.Slices;

partial class Workstations
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
        tabPage2 = new TabPage();
        tabPage3 = new TabPage();
        WorkstationsGroup = new cuiGroupBox();
        WorkstationsFlow = new FlowLayoutPanel();
        cuiPanel1 = new cuiBorder();
        GenerateWorkstationidentifierButton = new cuiButton();
        NewWorkstationIdentifier = new cuiTextBox2();
        cuiLabel3 = new cuiLabel();
        cuiLabel2 = new cuiLabel();
        WorkstationNameTextbox = new cuiTextBox2();
        cuiLabel1 = new cuiLabel();
        WorkstationsGroup.SuspendLayout();
        cuiPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // tabPage2
        // 
        tabPage2.Location = new Point(4, 46);
        tabPage2.Name = "tabPage2";
        tabPage2.Padding = new Padding(3);
        tabPage2.Size = new Size(763, 295);
        tabPage2.TabIndex = 1;
        tabPage2.Text = "tabPage2";
        tabPage2.UseVisualStyleBackColor = true;
        // 
        // tabPage3
        // 
        tabPage3.Location = new Point(4, 46);
        tabPage3.Name = "tabPage3";
        tabPage3.Padding = new Padding(3);
        tabPage3.Size = new Size(805, 238);
        tabPage3.TabIndex = 1;
        tabPage3.Text = "tabPage3";
        tabPage3.UseVisualStyleBackColor = true;
        // 
        // WorkstationsGroup
        // 
        WorkstationsGroup.BorderColor = Color.Black;
        WorkstationsGroup.Content = "Workstations";
        WorkstationsGroup.Controls.Add(WorkstationsFlow);
        WorkstationsGroup.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
        WorkstationsGroup.Location = new Point(12, 22);
        WorkstationsGroup.Name = "WorkstationsGroup";
        WorkstationsGroup.Padding = new Padding(8, 32, 8, 8);
        WorkstationsGroup.Rounding = new Padding(8);
        WorkstationsGroup.Size = new Size(1226, 441);
        WorkstationsGroup.TabIndex = 0;
        // 
        // WorkstationsFlow
        // 
        WorkstationsFlow.AutoScroll = true;
        WorkstationsFlow.AutoSize = true;
        WorkstationsFlow.Dock = DockStyle.Fill;
        WorkstationsFlow.Location = new Point(8, 32);
        WorkstationsFlow.Name = "WorkstationsFlow";
        WorkstationsFlow.Size = new Size(1210, 401);
        WorkstationsFlow.TabIndex = 0;
        // 
        // cuiPanel1
        // 
        cuiPanel1.Controls.Add(GenerateWorkstationidentifierButton);
        cuiPanel1.Controls.Add(NewWorkstationIdentifier);
        cuiPanel1.Controls.Add(cuiLabel3);
        cuiPanel1.Controls.Add(cuiLabel2);
        cuiPanel1.Controls.Add(WorkstationNameTextbox);
        cuiPanel1.Controls.Add(cuiLabel1);
        cuiPanel1.Location = new Point(12, 469);
        cuiPanel1.Name = "cuiPanel1";
        cuiPanel1.OutlineThickness = 1F;
        cuiPanel1.PanelColor = Color.White;
        cuiPanel1.PanelOutlineColor = Color.White;
        cuiPanel1.Rounding = new Padding(8);
        cuiPanel1.Size = new Size(1226, 294);
        cuiPanel1.TabIndex = 1;
        // 
        // GenerateWorkstationidentifierButton
        // 
        GenerateWorkstationidentifierButton.BackColor = Color.Transparent;
        GenerateWorkstationidentifierButton.CheckButton = false;
        GenerateWorkstationidentifierButton.Checked = false;
        GenerateWorkstationidentifierButton.CheckedBackground = Color.FromArgb(108, 124, 204);
        GenerateWorkstationidentifierButton.CheckedForeColor = Color.White;
        GenerateWorkstationidentifierButton.CheckedImageTint = Color.FromArgb(108, 124, 204);
        GenerateWorkstationidentifierButton.CheckedOutline = Color.FromArgb(108, 124, 204);
        GenerateWorkstationidentifierButton.Content = "generate";
        GenerateWorkstationidentifierButton.DialogResult = DialogResult.None;
        GenerateWorkstationidentifierButton.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        GenerateWorkstationidentifierButton.ForeColor = Color.White;
        GenerateWorkstationidentifierButton.HoverBackground = Color.FromArgb(108, 124, 204);
        GenerateWorkstationidentifierButton.HoveredImageTint = Color.White;
        GenerateWorkstationidentifierButton.HoverForeColor = Color.White;
        GenerateWorkstationidentifierButton.HoverOutline = Color.FromArgb(108, 124, 204);
        GenerateWorkstationidentifierButton.Image = null;
        GenerateWorkstationidentifierButton.ImageAutoCenter = true;
        GenerateWorkstationidentifierButton.ImageExpand = new Point(0, 0);
        GenerateWorkstationidentifierButton.ImageOffset = new Point(0, 0);
        GenerateWorkstationidentifierButton.ImageTint = Color.White;
        GenerateWorkstationidentifierButton.Location = new Point(72, 164);
        GenerateWorkstationidentifierButton.Name = "GenerateWorkstationidentifierButton";
        GenerateWorkstationidentifierButton.NormalBackground = Color.FromArgb(108, 124, 204);
        GenerateWorkstationidentifierButton.NormalOutline = Color.FromArgb(108, 124, 204);
        GenerateWorkstationidentifierButton.OutlineThickness = 4F;
        GenerateWorkstationidentifierButton.PressedBackground = Color.FromArgb(11, 35, 116);
        GenerateWorkstationidentifierButton.PressedForeColor = Color.WhiteSmoke;
        GenerateWorkstationidentifierButton.PressedImageTint = Color.White;
        GenerateWorkstationidentifierButton.PressedOutline = Color.FromArgb(11, 35, 116);
        GenerateWorkstationidentifierButton.Rounding = new Padding(10);
        GenerateWorkstationidentifierButton.Size = new Size(227, 31);
        GenerateWorkstationidentifierButton.TabIndex = 36;
        GenerateWorkstationidentifierButton.TextOffset = new Point(0, 0);
        GenerateWorkstationidentifierButton.Click += GenerateWorkstationidentifierButton_Click_2;
        // 
        // NewWorkstationIdentifier
        // 
        NewWorkstationIdentifier.BackColor = Color.White;
        NewWorkstationIdentifier.BorderColor = Color.FromArgb(128, 128, 128, 128);
        NewWorkstationIdentifier.BorderFocusColor = Color.FromArgb(255, 106, 0);
        NewWorkstationIdentifier.BorderSize = 1;
        NewWorkstationIdentifier.Content = "";
        NewWorkstationIdentifier.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
        NewWorkstationIdentifier.ForeColor = Color.Gray;
        NewWorkstationIdentifier.Location = new Point(19, 202);
        NewWorkstationIdentifier.Margin = new Padding(4);
        NewWorkstationIdentifier.Multiline = false;
        NewWorkstationIdentifier.Name = "NewWorkstationIdentifier";
        NewWorkstationIdentifier.Padding = new Padding(15, 13, 15, 0);
        NewWorkstationIdentifier.PasswordChar = false;
        NewWorkstationIdentifier.PlaceholderColor = SystemColors.WindowText;
        NewWorkstationIdentifier.PlaceholderText = "";
        NewWorkstationIdentifier.Rounding = 8;
        NewWorkstationIdentifier.Size = new Size(1009, 40);
        NewWorkstationIdentifier.TabIndex = 5;
        NewWorkstationIdentifier.TextOffset = new Size(0, 0);
        NewWorkstationIdentifier.UnderlinedStyle = true;
        // 
        // cuiLabel3
        // 
        cuiLabel3.BackColor = Color.Transparent;
        cuiLabel3.Content = "2\\.\\ Generate\\ workstation\\ identifier";
        cuiLabel3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel3.HorizontalAlignment = cuiLabel.HorizontalAlignments.Left;
        cuiLabel3.Location = new Point(47, 132);
        cuiLabel3.Margin = new Padding(4, 3, 4, 3);
        cuiLabel3.Name = "cuiLabel3";
        cuiLabel3.Size = new Size(327, 26);
        cuiLabel3.TabIndex = 3;
        // 
        // cuiLabel2
        // 
        cuiLabel2.Anchor = AnchorStyles.Left;
        cuiLabel2.BackColor = Color.Transparent;
        cuiLabel2.Content = "1\\.\\ Insert\\ workstation\\ name";
        cuiLabel2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel2.HorizontalAlignment = cuiLabel.HorizontalAlignments.Left;
        cuiLabel2.Location = new Point(47, 39);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(284, 29);
        cuiLabel2.TabIndex = 2;
        // 
        // WorkstationNameTextbox
        // 
        WorkstationNameTextbox.BackColor = Color.White;
        WorkstationNameTextbox.BorderColor = Color.Black;
        WorkstationNameTextbox.BorderFocusColor = Color.FromArgb(255, 106, 0);
        WorkstationNameTextbox.BorderSize = 1;
        WorkstationNameTextbox.Content = "";
        WorkstationNameTextbox.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        WorkstationNameTextbox.ForeColor = Color.Gray;
        WorkstationNameTextbox.Location = new Point(47, 75);
        WorkstationNameTextbox.Margin = new Padding(4);
        WorkstationNameTextbox.Multiline = false;
        WorkstationNameTextbox.Name = "WorkstationNameTextbox";
        WorkstationNameTextbox.Padding = new Padding(20, 8, 20, 0);
        WorkstationNameTextbox.PasswordChar = false;
        WorkstationNameTextbox.PlaceholderColor = SystemColors.WindowText;
        WorkstationNameTextbox.PlaceholderText = "";
        WorkstationNameTextbox.Rounding = 8;
        WorkstationNameTextbox.Size = new Size(349, 37);
        WorkstationNameTextbox.TabIndex = 1;
        WorkstationNameTextbox.TextOffset = new Size(0, 0);
        WorkstationNameTextbox.UnderlinedStyle = true;
        // 
        // cuiLabel1
        // 
        cuiLabel1.BackColor = Color.Transparent;
        cuiLabel1.Content = "add\\ a\\ new\\ workstation\\ to\\ network:";
        cuiLabel1.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel1.HorizontalAlignment = cuiLabel.HorizontalAlignments.Left;
        cuiLabel1.Location = new Point(19, 13);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(390, 33);
        cuiLabel1.TabIndex = 0;
        // 
        // Workstations
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(1281, 833);
        Controls.Add(cuiPanel1);
        Controls.Add(WorkstationsGroup);
        Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Name = "Workstations";
        Text = "Workstations";
        WorkstationsGroup.ResumeLayout(false);
        WorkstationsGroup.PerformLayout();
        cuiPanel1.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion
    private TabPage tabPage2;
    private TabPage tabPage3;
    public GroupBox groupBox1;
    private FlowLayoutPanel flowLayoutPanel1;
    private CuoreUI.Controls.cuiGroupBox WorkstationsGroup;
    private FlowLayoutPanel WorkstationsFlow;
    private CuoreUI.Controls.cuiBorder cuiPanel1;
    private CuoreUI.Controls.cuiLabel cuiLabel1;
    private CuoreUI.Controls.cuiLabel cuiLabel2;
    private CuoreUI.Controls.cuiTextBox2 WorkstationNameTextbox;
    private CuoreUI.Controls.cuiLabel cuiLabel3;
    private CuoreUI.Controls.cuiTextBox2 NewWorkstationIdentifier;
    private cuiButton GenerateWorkstationidentifierButton;
}
