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
        components = new System.ComponentModel.Container();
        var dataGridViewCellStyle1 = new DataGridViewCellStyle();
        var dataGridViewCellStyle2 = new DataGridViewCellStyle();
        var dataGridViewCellStyle3 = new DataGridViewCellStyle();
        processModelBindingSource = new BindingSource(components);
        cuiBorder6 = new CuoreUI.Controls.cuiBorder();
        cuiLabel4 = new CuoreUI.Controls.cuiLabel();
        cuiSeparator1 = new CuoreUI.Controls.cuiSeparator();
        cuiLabel13 = new CuoreUI.Controls.cuiLabel();
        cuiBorder2 = new CuoreUI.Controls.cuiBorder();
        NonSystemProcessSwitch = new CuoreUI.Controls.cuiSwitch();
        SystemProcessSwitch = new CuoreUI.Controls.cuiSwitch();
        cuiLabel3 = new CuoreUI.Controls.cuiLabel();
        cuiLabel1 = new CuoreUI.Controls.cuiLabel();
        cuiSeparator2 = new CuoreUI.Controls.cuiSeparator();
        cuiLabel2 = new CuoreUI.Controls.cuiLabel();
        cuiBorder1 = new CuoreUI.Controls.cuiBorder();
        ProcessesTable = new DataGridView();
        pidDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        iconDataGridViewImageColumn1 = new DataGridViewImageColumn();
        nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        startTimeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        pathDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        priorityDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        manufacturerDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        versionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        architectureDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
        cpuDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        ramDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        threadsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        handlesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
        systemDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
        processModelBindingSource1 = new BindingSource(components);
        ((System.ComponentModel.ISupportInitialize)processModelBindingSource).BeginInit();
        cuiBorder6.SuspendLayout();
        cuiBorder2.SuspendLayout();
        cuiBorder1.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)ProcessesTable).BeginInit();
        ((System.ComponentModel.ISupportInitialize)processModelBindingSource1).BeginInit();
        SuspendLayout();
        // 
        // processModelBindingSource
        // 
        processModelBindingSource.DataSource = typeof(Models.ProcessModel);
        // 
        // cuiBorder6
        // 
        cuiBorder6.BackColor = Color.Transparent;
        cuiBorder6.Controls.Add(cuiLabel4);
        cuiBorder6.Controls.Add(cuiSeparator1);
        cuiBorder6.Controls.Add(cuiLabel13);
        cuiBorder6.ForeColor = Color.FromArgb(40, 53, 147);
        cuiBorder6.Location = new Point(12, 12);
        cuiBorder6.Name = "cuiBorder6";
        cuiBorder6.OutlineThickness = 1F;
        cuiBorder6.PanelColor = Color.White;
        cuiBorder6.PanelOutlineColor = Color.White;
        cuiBorder6.Rounding = new Padding(11);
        cuiBorder6.Size = new Size(543, 162);
        cuiBorder6.TabIndex = 25;
        // 
        // cuiLabel4
        // 
        cuiLabel4.BackColor = Color.Transparent;
        cuiLabel4.Content = "Get\\ a\\ real-time\\ overview\\ of\\ all\\ active\\ processes\\ on\\ your\\ computer\\.\\ Analyze\\ resource\\ consumption\\ and\\ identify\\ potential\\ performance\\ issues\\.";
        cuiLabel4.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        cuiLabel4.ForeColor = Color.FromArgb(154, 154, 154);
        cuiLabel4.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel4.Location = new Point(0, 85);
        cuiLabel4.Margin = new Padding(4, 3, 4, 3);
        cuiLabel4.Name = "cuiLabel4";
        cuiLabel4.Size = new Size(526, 64);
        cuiLabel4.TabIndex = 22;
        // 
        // cuiSeparator1
        // 
        cuiSeparator1.ForeColor = Color.FromArgb(20, 39, 78);
        cuiSeparator1.Location = new Point(0, 48);
        cuiSeparator1.Margin = new Padding(4, 3, 4, 3);
        cuiSeparator1.Name = "cuiSeparator1";
        cuiSeparator1.SeparatorMargin = 8;
        cuiSeparator1.Size = new Size(526, 16);
        cuiSeparator1.TabIndex = 23;
        cuiSeparator1.Thickness = 1F;
        cuiSeparator1.Vertical = false;
        // 
        // cuiLabel13
        // 
        cuiLabel13.BackColor = Color.White;
        cuiLabel13.Content = "Current\\ processes";
        cuiLabel13.Font = new Font("Verdana", 21.75F, FontStyle.Bold);
        cuiLabel13.ForeColor = Color.Black;
        cuiLabel13.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel13.Location = new Point(4, 3);
        cuiLabel13.Margin = new Padding(4, 3, 4, 3);
        cuiLabel13.Name = "cuiLabel13";
        cuiLabel13.Size = new Size(350, 39);
        cuiLabel13.TabIndex = 16;
        // 
        // cuiBorder2
        // 
        cuiBorder2.BackColor = Color.Transparent;
        cuiBorder2.Controls.Add(NonSystemProcessSwitch);
        cuiBorder2.Controls.Add(SystemProcessSwitch);
        cuiBorder2.Controls.Add(cuiLabel3);
        cuiBorder2.Controls.Add(cuiLabel1);
        cuiBorder2.Controls.Add(cuiSeparator2);
        cuiBorder2.Controls.Add(cuiLabel2);
        cuiBorder2.ForeColor = Color.FromArgb(40, 53, 147);
        cuiBorder2.Location = new Point(561, 12);
        cuiBorder2.Name = "cuiBorder2";
        cuiBorder2.OutlineThickness = 1F;
        cuiBorder2.PanelColor = Color.White;
        cuiBorder2.PanelOutlineColor = Color.White;
        cuiBorder2.Rounding = new Padding(11);
        cuiBorder2.Size = new Size(682, 162);
        cuiBorder2.TabIndex = 26;
        // 
        // NonSystemProcessSwitch
        // 
        NonSystemProcessSwitch.BackColor = Color.Transparent;
        NonSystemProcessSwitch.Checked = true;
        NonSystemProcessSwitch.CheckedBackground = Color.White;
        NonSystemProcessSwitch.CheckedForeground = Color.FromArgb(9, 121, 105);
        NonSystemProcessSwitch.CheckedOutlineColor = Color.FromArgb(9, 121, 105);
        NonSystemProcessSwitch.ForeColor = Color.White;
        NonSystemProcessSwitch.Location = new Point(224, 122);
        NonSystemProcessSwitch.Name = "NonSystemProcessSwitch";
        NonSystemProcessSwitch.OutlineStyle = true;
        NonSystemProcessSwitch.OutlineThickness = 1F;
        NonSystemProcessSwitch.ShowSymbols = true;
        NonSystemProcessSwitch.Size = new Size(48, 27);
        NonSystemProcessSwitch.TabIndex = 27;
        NonSystemProcessSwitch.ThumbSizeModifier = new Size(0, 0);
        NonSystemProcessSwitch.UncheckedBackground = Color.White;
        NonSystemProcessSwitch.UncheckedForeground = Color.FromArgb(194, 50, 50);
        NonSystemProcessSwitch.UncheckedOutlineColor = Color.FromArgb(194, 50, 50);
        // 
        // SystemProcessSwitch
        // 
        SystemProcessSwitch.BackColor = Color.Transparent;
        SystemProcessSwitch.Checked = false;
        SystemProcessSwitch.CheckedBackground = Color.White;
        SystemProcessSwitch.CheckedForeground = Color.FromArgb(9, 121, 105);
        SystemProcessSwitch.CheckedOutlineColor = Color.FromArgb(9, 121, 105);
        SystemProcessSwitch.ForeColor = Color.White;
        SystemProcessSwitch.Location = new Point(224, 82);
        SystemProcessSwitch.Name = "SystemProcessSwitch";
        SystemProcessSwitch.OutlineStyle = true;
        SystemProcessSwitch.OutlineThickness = 1F;
        SystemProcessSwitch.ShowSymbols = true;
        SystemProcessSwitch.Size = new Size(48, 27);
        SystemProcessSwitch.TabIndex = 26;
        SystemProcessSwitch.ThumbSizeModifier = new Size(0, 0);
        SystemProcessSwitch.UncheckedBackground = Color.White;
        SystemProcessSwitch.UncheckedForeground = Color.FromArgb(194, 50, 50);
        SystemProcessSwitch.UncheckedOutlineColor = Color.FromArgb(194, 50, 50);
        // 
        // cuiLabel3
        // 
        cuiLabel3.BackColor = Color.Transparent;
        cuiLabel3.Content = "Non-System\\ processes";
        cuiLabel3.Font = new Font("Verdana", 12F);
        cuiLabel3.ForeColor = Color.Black;
        cuiLabel3.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel3.Location = new Point(4, 125);
        cuiLabel3.Margin = new Padding(4, 3, 4, 3);
        cuiLabel3.Name = "cuiLabel3";
        cuiLabel3.Size = new Size(220, 24);
        cuiLabel3.TabIndex = 25;
        // 
        // cuiLabel1
        // 
        cuiLabel1.BackColor = Color.Transparent;
        cuiLabel1.Content = "System\\ processes";
        cuiLabel1.Font = new Font("Verdana", 12F);
        cuiLabel1.ForeColor = Color.Black;
        cuiLabel1.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel1.Location = new Point(4, 85);
        cuiLabel1.Margin = new Padding(4, 3, 4, 3);
        cuiLabel1.Name = "cuiLabel1";
        cuiLabel1.Size = new Size(194, 24);
        cuiLabel1.TabIndex = 22;
        // 
        // cuiSeparator2
        // 
        cuiSeparator2.ForeColor = Color.FromArgb(20, 39, 78);
        cuiSeparator2.Location = new Point(0, 45);
        cuiSeparator2.Margin = new Padding(4, 3, 4, 3);
        cuiSeparator2.Name = "cuiSeparator2";
        cuiSeparator2.SeparatorMargin = 8;
        cuiSeparator2.Size = new Size(678, 19);
        cuiSeparator2.TabIndex = 23;
        cuiSeparator2.Thickness = 1F;
        cuiSeparator2.Vertical = false;
        // 
        // cuiLabel2
        // 
        cuiLabel2.BackColor = Color.White;
        cuiLabel2.Content = "settings";
        cuiLabel2.Font = new Font("Verdana", 21.75F, FontStyle.Bold);
        cuiLabel2.ForeColor = Color.Black;
        cuiLabel2.HorizontalAlignment = CuoreUI.Controls.cuiLabel.HorizontalAlignments.Center;
        cuiLabel2.Location = new Point(4, 3);
        cuiLabel2.Margin = new Padding(4, 3, 4, 3);
        cuiLabel2.Name = "cuiLabel2";
        cuiLabel2.Size = new Size(175, 39);
        cuiLabel2.TabIndex = 16;
        // 
        // cuiBorder1
        // 
        cuiBorder1.BackColor = Color.Transparent;
        cuiBorder1.Controls.Add(ProcessesTable);
        cuiBorder1.ForeColor = Color.FromArgb(40, 53, 147);
        cuiBorder1.Location = new Point(12, 180);
        cuiBorder1.Name = "cuiBorder1";
        cuiBorder1.OutlineThickness = 1F;
        cuiBorder1.PanelColor = Color.White;
        cuiBorder1.PanelOutlineColor = Color.White;
        cuiBorder1.Rounding = new Padding(10);
        cuiBorder1.Size = new Size(1234, 507);
        cuiBorder1.TabIndex = 26;
        // 
        // ProcessesTable
        // 
        ProcessesTable.AllowUserToAddRows = false;
        ProcessesTable.AllowUserToDeleteRows = false;
        ProcessesTable.AllowUserToOrderColumns = true;
        ProcessesTable.AutoGenerateColumns = false;
        ProcessesTable.BackgroundColor = Color.White;
        ProcessesTable.BorderStyle = BorderStyle.None;
        ProcessesTable.CellBorderStyle = DataGridViewCellBorderStyle.Sunken;
        dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle1.BackColor = Color.IndianRed;
        dataGridViewCellStyle1.Font = new Font("Verdana", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
        dataGridViewCellStyle1.ForeColor = SystemColors.WindowFrame;
        dataGridViewCellStyle1.SelectionBackColor = Color.Black;
        dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDarkDark;
        dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
        ProcessesTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
        ProcessesTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        ProcessesTable.Columns.AddRange(new DataGridViewColumn[] { pidDataGridViewTextBoxColumn1, iconDataGridViewImageColumn1, nameDataGridViewTextBoxColumn1, startTimeDataGridViewTextBoxColumn1, pathDataGridViewTextBoxColumn1, priorityDataGridViewTextBoxColumn1, manufacturerDataGridViewTextBoxColumn1, versionDataGridViewTextBoxColumn1, architectureDataGridViewTextBoxColumn1, cpuDataGridViewTextBoxColumn, ramDataGridViewTextBoxColumn, threadsDataGridViewTextBoxColumn, handlesDataGridViewTextBoxColumn, systemDataGridViewCheckBoxColumn });
        ProcessesTable.DataSource = processModelBindingSource1;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.White;
        dataGridViewCellStyle2.Font = new Font("Verdana", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle2.ForeColor = Color.FromArgb(40, 53, 147);
        dataGridViewCellStyle2.SelectionBackColor = Color.Gainsboro;
        dataGridViewCellStyle2.SelectionForeColor = Color.Black;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
        ProcessesTable.DefaultCellStyle = dataGridViewCellStyle2;
        ProcessesTable.EditMode = DataGridViewEditMode.EditOnKeystroke;
        ProcessesTable.GridColor = Color.White;
        ProcessesTable.Location = new Point(4, 6);
        ProcessesTable.Name = "ProcessesTable";
        ProcessesTable.ReadOnly = true;
        dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle3.BackColor = Color.White;
        dataGridViewCellStyle3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
        ProcessesTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
        ProcessesTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        ProcessesTable.ShowCellErrors = false;
        ProcessesTable.ShowEditingIcon = false;
        ProcessesTable.ShowRowErrors = false;
        ProcessesTable.Size = new Size(1227, 501);
        ProcessesTable.TabIndex = 22;
        // 
        // pidDataGridViewTextBoxColumn1
        // 
        pidDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        pidDataGridViewTextBoxColumn1.DataPropertyName = "Pid";
        pidDataGridViewTextBoxColumn1.FillWeight = 50F;
        pidDataGridViewTextBoxColumn1.HeaderText = "Pid";
        pidDataGridViewTextBoxColumn1.Name = "pidDataGridViewTextBoxColumn1";
        pidDataGridViewTextBoxColumn1.ReadOnly = true;
        pidDataGridViewTextBoxColumn1.Width = 54;
        // 
        // iconDataGridViewImageColumn1
        // 
        iconDataGridViewImageColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        iconDataGridViewImageColumn1.DataPropertyName = "Icon";
        iconDataGridViewImageColumn1.FillWeight = 50F;
        iconDataGridViewImageColumn1.HeaderText = "Icon";
        iconDataGridViewImageColumn1.MinimumWidth = 50;
        iconDataGridViewImageColumn1.Name = "iconDataGridViewImageColumn1";
        iconDataGridViewImageColumn1.ReadOnly = true;
        iconDataGridViewImageColumn1.Width = 50;
        // 
        // nameDataGridViewTextBoxColumn1
        // 
        nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
        nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
        nameDataGridViewTextBoxColumn1.FillWeight = 150F;
        nameDataGridViewTextBoxColumn1.HeaderText = "Name";
        nameDataGridViewTextBoxColumn1.MinimumWidth = 50;
        nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
        nameDataGridViewTextBoxColumn1.ReadOnly = true;
        nameDataGridViewTextBoxColumn1.Width = 150;
        // 
        // startTimeDataGridViewTextBoxColumn1
        // 
        startTimeDataGridViewTextBoxColumn1.DataPropertyName = "StartTime";
        startTimeDataGridViewTextBoxColumn1.FillWeight = 125F;
        startTimeDataGridViewTextBoxColumn1.HeaderText = "StartTime";
        startTimeDataGridViewTextBoxColumn1.Name = "startTimeDataGridViewTextBoxColumn1";
        startTimeDataGridViewTextBoxColumn1.ReadOnly = true;
        startTimeDataGridViewTextBoxColumn1.Width = 125;
        // 
        // pathDataGridViewTextBoxColumn1
        // 
        pathDataGridViewTextBoxColumn1.DataPropertyName = "Path";
        pathDataGridViewTextBoxColumn1.FillWeight = 150F;
        pathDataGridViewTextBoxColumn1.HeaderText = "Path";
        pathDataGridViewTextBoxColumn1.Name = "pathDataGridViewTextBoxColumn1";
        pathDataGridViewTextBoxColumn1.ReadOnly = true;
        pathDataGridViewTextBoxColumn1.Width = 150;
        // 
        // priorityDataGridViewTextBoxColumn1
        // 
        priorityDataGridViewTextBoxColumn1.DataPropertyName = "Priority";
        priorityDataGridViewTextBoxColumn1.FillWeight = 60F;
        priorityDataGridViewTextBoxColumn1.HeaderText = "Priority";
        priorityDataGridViewTextBoxColumn1.MinimumWidth = 60;
        priorityDataGridViewTextBoxColumn1.Name = "priorityDataGridViewTextBoxColumn1";
        priorityDataGridViewTextBoxColumn1.ReadOnly = true;
        priorityDataGridViewTextBoxColumn1.Width = 60;
        // 
        // manufacturerDataGridViewTextBoxColumn1
        // 
        manufacturerDataGridViewTextBoxColumn1.DataPropertyName = "Manufacturer";
        manufacturerDataGridViewTextBoxColumn1.FillWeight = 130F;
        manufacturerDataGridViewTextBoxColumn1.HeaderText = "Manufacturer";
        manufacturerDataGridViewTextBoxColumn1.Name = "manufacturerDataGridViewTextBoxColumn1";
        manufacturerDataGridViewTextBoxColumn1.ReadOnly = true;
        manufacturerDataGridViewTextBoxColumn1.Width = 130;
        // 
        // versionDataGridViewTextBoxColumn1
        // 
        versionDataGridViewTextBoxColumn1.DataPropertyName = "Version";
        versionDataGridViewTextBoxColumn1.FillWeight = 70F;
        versionDataGridViewTextBoxColumn1.HeaderText = "Version";
        versionDataGridViewTextBoxColumn1.Name = "versionDataGridViewTextBoxColumn1";
        versionDataGridViewTextBoxColumn1.ReadOnly = true;
        versionDataGridViewTextBoxColumn1.Width = 70;
        // 
        // architectureDataGridViewTextBoxColumn1
        // 
        architectureDataGridViewTextBoxColumn1.DataPropertyName = "Architecture";
        architectureDataGridViewTextBoxColumn1.FillWeight = 60F;
        architectureDataGridViewTextBoxColumn1.HeaderText = "Architecture";
        architectureDataGridViewTextBoxColumn1.Name = "architectureDataGridViewTextBoxColumn1";
        architectureDataGridViewTextBoxColumn1.ReadOnly = true;
        architectureDataGridViewTextBoxColumn1.Width = 60;
        // 
        // cpuDataGridViewTextBoxColumn
        // 
        cpuDataGridViewTextBoxColumn.DataPropertyName = "Cpu";
        cpuDataGridViewTextBoxColumn.FillWeight = 65F;
        cpuDataGridViewTextBoxColumn.HeaderText = "Cpu(%)";
        cpuDataGridViewTextBoxColumn.Name = "cpuDataGridViewTextBoxColumn";
        cpuDataGridViewTextBoxColumn.ReadOnly = true;
        cpuDataGridViewTextBoxColumn.Width = 65;
        // 
        // ramDataGridViewTextBoxColumn
        // 
        ramDataGridViewTextBoxColumn.DataPropertyName = "Ram";
        ramDataGridViewTextBoxColumn.FillWeight = 65F;
        ramDataGridViewTextBoxColumn.HeaderText = "Ram(Mb)";
        ramDataGridViewTextBoxColumn.Name = "ramDataGridViewTextBoxColumn";
        ramDataGridViewTextBoxColumn.ReadOnly = true;
        ramDataGridViewTextBoxColumn.Width = 65;
        // 
        // threadsDataGridViewTextBoxColumn
        // 
        threadsDataGridViewTextBoxColumn.DataPropertyName = "Threads";
        threadsDataGridViewTextBoxColumn.FillWeight = 65F;
        threadsDataGridViewTextBoxColumn.HeaderText = "Threads";
        threadsDataGridViewTextBoxColumn.Name = "threadsDataGridViewTextBoxColumn";
        threadsDataGridViewTextBoxColumn.ReadOnly = true;
        threadsDataGridViewTextBoxColumn.Width = 65;
        // 
        // handlesDataGridViewTextBoxColumn
        // 
        handlesDataGridViewTextBoxColumn.DataPropertyName = "Handles";
        handlesDataGridViewTextBoxColumn.FillWeight = 65F;
        handlesDataGridViewTextBoxColumn.HeaderText = "Handles";
        handlesDataGridViewTextBoxColumn.Name = "handlesDataGridViewTextBoxColumn";
        handlesDataGridViewTextBoxColumn.ReadOnly = true;
        handlesDataGridViewTextBoxColumn.Width = 65;
        // 
        // systemDataGridViewCheckBoxColumn
        // 
        systemDataGridViewCheckBoxColumn.DataPropertyName = "System";
        systemDataGridViewCheckBoxColumn.FillWeight = 60F;
        systemDataGridViewCheckBoxColumn.HeaderText = "System";
        systemDataGridViewCheckBoxColumn.Name = "systemDataGridViewCheckBoxColumn";
        systemDataGridViewCheckBoxColumn.ReadOnly = true;
        systemDataGridViewCheckBoxColumn.Width = 60;
        // 
        // processModelBindingSource1
        // 
        processModelBindingSource1.DataSource = typeof(Models.ProcessModel);
        // 
        // Processes
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(241, 244, 254);
        ClientSize = new Size(1258, 692);
        Controls.Add(cuiBorder2);
        Controls.Add(cuiBorder1);
        Controls.Add(cuiBorder6);
        Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
        FormBorderStyle = FormBorderStyle.None;
        Margin = new Padding(4);
        Name = "Processes";
        Text = "Processes";
        Load += Processes_Load;
        ((System.ComponentModel.ISupportInitialize)processModelBindingSource).EndInit();
        cuiBorder6.ResumeLayout(false);
        cuiBorder2.ResumeLayout(false);
        cuiBorder1.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)ProcessesTable).EndInit();
        ((System.ComponentModel.ISupportInitialize)processModelBindingSource1).EndInit();
        ResumeLayout(false);
    }

    #endregion
    private DataGridViewTextBoxColumn cpuUsageDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ramUsageDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn threadCountDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn handleCountDataGridViewTextBoxColumn;
    private BindingSource processModelBindingSource;
    private CuoreUI.Controls.cuiBorder cuiBorder6;
    private CuoreUI.Controls.cuiLabel cuiLabel4;
    private CuoreUI.Controls.cuiSeparator cuiSeparator1;
    private CuoreUI.Controls.cuiLabel cuiLabel13;
    private CuoreUI.Controls.cuiBorder cuiBorder1;
    private CuoreUI.Controls.cuiBorder cuiBorder2;
    private CuoreUI.Controls.cuiLabel cuiLabel1;
    private CuoreUI.Controls.cuiSeparator cuiSeparator2;
    private CuoreUI.Controls.cuiLabel cuiLabel2;
    private CuoreUI.Controls.cuiLabel cuiLabel3;
    private CuoreUI.Controls.cuiSwitch NonSystemProcessSwitch;
    private CuoreUI.Controls.cuiSwitch SystemProcessSwitch;
    private BindingSource processModelBindingSource1;
    private DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn1;
    private DataGridViewImageColumn iconDataGridViewImageColumn1;
    private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn pathDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn priorityDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn architectureDataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn cpuDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn ramDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn threadsDataGridViewTextBoxColumn;
    private DataGridViewTextBoxColumn handlesDataGridViewTextBoxColumn;
    private DataGridViewCheckBoxColumn systemDataGridViewCheckBoxColumn;
    private DataGridView ProcessesTable;
}
