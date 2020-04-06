
namespace TzalemTmuna.Forms
{
    partial class Settings
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tpMain = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblChangePassword = new MetroFramework.Controls.MetroLabel();
            this.lblAccount = new MetroFramework.Controls.MetroLabel();
            this.lblAccentColor = new MetroFramework.Controls.MetroLabel();
            this.lblCustomize = new MetroFramework.Controls.MetroLabel();
            this.lblDarkMode = new MetroFramework.Controls.MetroLabel();
            this.cbAccentColor = new MetroFramework.Controls.MetroComboBox();
            this.tDarkMode = new MetroFramework.Controls.MetroToggle();
            this.btnChangePassword = new MetroFramework.Controls.MetroButton();
            this.tpAdminReports = new MetroFramework.Controls.MetroTabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grdReports = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmOptions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tpReports = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReport = new MetroFramework.Controls.MetroButton();
            this.grdMyReports = new MetroFramework.Controls.MetroGrid();
            this.report_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewImageColumn();
            this.report_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closing_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpAdminPosts = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpAdminReports.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).BeginInit();
            this.cmOptions.SuspendLayout();
            this.tpReports.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMyReports)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpMain);
            this.metroTabControl1.Controls.Add(this.tpAdminReports);
            this.metroTabControl1.Controls.Add(this.tpReports);
            this.metroTabControl1.Controls.Add(this.tpAdminPosts);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(795, 838);
            this.metroTabControl1.TabIndex = 19;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tpMain
            // 
            this.tpMain.Controls.Add(this.tableLayoutPanel2);
            this.tpMain.HorizontalScrollbarBarColor = true;
            this.tpMain.HorizontalScrollbarHighlightOnWheel = false;
            this.tpMain.HorizontalScrollbarSize = 10;
            this.tpMain.Location = new System.Drawing.Point(4, 38);
            this.tpMain.Name = "tpMain";
            this.tpMain.Size = new System.Drawing.Size(787, 796);
            this.tpMain.TabIndex = 2;
            this.tpMain.Text = "Main";
            this.tpMain.VerticalScrollbarBarColor = true;
            this.tpMain.VerticalScrollbarHighlightOnWheel = false;
            this.tpMain.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.15863F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.84137F));
            this.tableLayoutPanel2.Controls.Add(this.lblChangePassword, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.lblAccount, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lblAccentColor, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblCustomize, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDarkMode, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbAccentColor, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.tDarkMode, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnChangePassword, 2, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(787, 796);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChangePassword.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.lblChangePassword.Location = new System.Drawing.Point(3, 192);
            this.lblChangePassword.Margin = new System.Windows.Forms.Padding(3);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(672, 601);
            this.lblChangePassword.TabIndex = 29;
            this.lblChangePassword.Text = "Change Password";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccount.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.lblAccount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAccount.Location = new System.Drawing.Point(3, 150);
            this.lblAccount.Margin = new System.Windows.Forms.Padding(3);
            this.lblAccount.Name = "lblAccount";
            this.lblAccount.Size = new System.Drawing.Size(672, 36);
            this.lblAccount.TabIndex = 28;
            this.lblAccount.Text = "Account";
            this.lblAccount.UseStyleColors = true;
            // 
            // lblAccentColor
            // 
            this.lblAccentColor.AutoSize = true;
            this.lblAccentColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccentColor.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.lblAccentColor.Location = new System.Drawing.Point(3, 87);
            this.lblAccentColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblAccentColor.Name = "lblAccentColor";
            this.lblAccentColor.Size = new System.Drawing.Size(672, 36);
            this.lblAccentColor.TabIndex = 26;
            this.lblAccentColor.Text = "Accent color";
            // 
            // lblCustomize
            // 
            this.lblCustomize.AutoSize = true;
            this.lblCustomize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomize.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.lblCustomize.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblCustomize.Location = new System.Drawing.Point(3, 3);
            this.lblCustomize.Margin = new System.Windows.Forms.Padding(3);
            this.lblCustomize.Name = "lblCustomize";
            this.lblCustomize.Size = new System.Drawing.Size(672, 36);
            this.lblCustomize.TabIndex = 24;
            this.lblCustomize.Text = "Customize";
            this.lblCustomize.UseStyleColors = true;
            // 
            // lblDarkMode
            // 
            this.lblDarkMode.AutoSize = true;
            this.lblDarkMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDarkMode.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.lblDarkMode.Location = new System.Drawing.Point(3, 45);
            this.lblDarkMode.Margin = new System.Windows.Forms.Padding(3);
            this.lblDarkMode.Name = "lblDarkMode";
            this.lblDarkMode.Size = new System.Drawing.Size(672, 36);
            this.lblDarkMode.TabIndex = 22;
            this.lblDarkMode.Text = "Dark mode";
            // 
            // cbAccentColor
            // 
            this.cbAccentColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAccentColor.ForeColor = System.Drawing.Color.White;
            this.cbAccentColor.FormattingEnabled = true;
            this.cbAccentColor.IntegralHeight = false;
            this.cbAccentColor.ItemHeight = 23;
            this.cbAccentColor.Items.AddRange(new object[] {
            "Blue",
            "Lime",
            "Magenta",
            "Teal",
            "Yellow"});
            this.cbAccentColor.Location = new System.Drawing.Point(681, 90);
            this.cbAccentColor.Name = "cbAccentColor";
            this.cbAccentColor.Size = new System.Drawing.Size(103, 29);
            this.cbAccentColor.TabIndex = 25;
            this.cbAccentColor.UseCustomBackColor = true;
            this.cbAccentColor.UseCustomForeColor = true;
            this.cbAccentColor.UseSelectable = true;
            this.cbAccentColor.SelectedIndexChanged += new System.EventHandler(this.cbAccentColor_SelectedIndexChanged);
            // 
            // tDarkMode
            // 
            this.tDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tDarkMode.Checked = true;
            this.tDarkMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tDarkMode.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.tDarkMode.Location = new System.Drawing.Point(681, 46);
            this.tDarkMode.Margin = new System.Windows.Forms.Padding(1, 4, 1, 6);
            this.tDarkMode.Name = "tDarkMode";
            this.tDarkMode.Size = new System.Drawing.Size(103, 32);
            this.tDarkMode.TabIndex = 2;
            this.tDarkMode.Text = "On";
            this.tDarkMode.UseSelectable = true;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChangePassword.Location = new System.Drawing.Point(681, 192);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(103, 36);
            this.btnChangePassword.TabIndex = 30;
            this.btnChangePassword.Text = "Change";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tpAdminReports
            // 
            this.tpAdminReports.Controls.Add(this.flowLayoutPanel1);
            this.tpAdminReports.HorizontalScrollbarBarColor = true;
            this.tpAdminReports.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAdminReports.HorizontalScrollbarSize = 10;
            this.tpAdminReports.Location = new System.Drawing.Point(4, 38);
            this.tpAdminReports.Name = "tpAdminReports";
            this.tpAdminReports.Size = new System.Drawing.Size(787, 796);
            this.tpAdminReports.TabIndex = 3;
            this.tpAdminReports.Text = "Reports";
            this.tpAdminReports.VerticalScrollbarBarColor = true;
            this.tpAdminReports.VerticalScrollbarHighlightOnWheel = false;
            this.tpAdminReports.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.metroLabel4);
            this.flowLayoutPanel1.Controls.Add(this.chart1);
            this.flowLayoutPanel1.Controls.Add(this.grdReports);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(787, 796);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(3, 3);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(109, 36);
            this.metroLabel4.TabIndex = 25;
            this.metroLabel4.Text = "Reports";
            this.metroLabel4.UseStyleColors = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(3, 45);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series1.BorderWidth = 4;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "Reports Opened";
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValuesPerPoint = 6;
            series2.BorderWidth = 4;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.LegendText = "Reports Closed";
            series2.Name = "Series2";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series2.YValuesPerPoint = 6;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(784, 300);
            this.chart1.TabIndex = 26;
            this.chart1.Text = "chart1";
            // 
            // grdReports
            // 
            this.grdReports.AllowUserToAddRows = false;
            this.grdReports.AllowUserToDeleteRows = false;
            this.grdReports.AllowUserToResizeRows = false;
            this.grdReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewImageColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.grdReports.ContextMenuStrip = this.cmOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdReports.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdReports.EnableHeadersVisualStyles = false;
            this.grdReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdReports.Location = new System.Drawing.Point(3, 351);
            this.grdReports.MultiSelect = false;
            this.grdReports.Name = "grdReports";
            this.grdReports.ReadOnly = true;
            this.grdReports.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdReports.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdReports.Size = new System.Drawing.Size(784, 442);
            this.grdReports.TabIndex = 27;
            this.grdReports.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdMyReports_CellMouseDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ReportId";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "PostId";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            this.dataGridViewTextBoxColumn2.Width = 62;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Post Reported";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Width = 75;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Report Body";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 85;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Creation Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 93;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Closing Date";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 88;
            // 
            // cmOptions
            // 
            this.cmOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.cmOptions.Name = "cmOptions";
            this.cmOptions.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // tpReports
            // 
            this.tpReports.Controls.Add(this.tableLayoutPanel1);
            this.tpReports.HorizontalScrollbarBarColor = true;
            this.tpReports.HorizontalScrollbarHighlightOnWheel = false;
            this.tpReports.HorizontalScrollbarSize = 10;
            this.tpReports.Location = new System.Drawing.Point(4, 38);
            this.tpReports.Name = "tpReports";
            this.tpReports.Size = new System.Drawing.Size(787, 796);
            this.tpReports.TabIndex = 1;
            this.tpReports.Text = "Reports";
            this.tpReports.VerticalScrollbarBarColor = true;
            this.tpReports.VerticalScrollbarHighlightOnWheel = false;
            this.tpReports.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnReport, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.grdMyReports, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(787, 796);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // btnReport
            // 
            this.btnReport.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnReport.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnReport.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.btnReport.Location = new System.Drawing.Point(3, 746);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(781, 47);
            this.btnReport.TabIndex = 20;
            this.btnReport.Text = "Report an Issue";
            this.btnReport.UseSelectable = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // grdMyReports
            // 
            this.grdMyReports.AllowUserToAddRows = false;
            this.grdMyReports.AllowUserToDeleteRows = false;
            this.grdMyReports.AllowUserToResizeRows = false;
            this.grdMyReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdMyReports.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grdMyReports.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMyReports.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdMyReports.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grdMyReports.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMyReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdMyReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMyReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.report_id,
            this.post_id,
            this.post,
            this.report_text,
            this.creation_date,
            this.closing_date});
            this.grdMyReports.ContextMenuStrip = this.cmOptions;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMyReports.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdMyReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMyReports.EnableHeadersVisualStyles = false;
            this.grdMyReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdMyReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMyReports.Location = new System.Drawing.Point(3, 3);
            this.grdMyReports.MultiSelect = false;
            this.grdMyReports.Name = "grdMyReports";
            this.grdMyReports.ReadOnly = true;
            this.grdMyReports.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMyReports.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdMyReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdMyReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMyReports.Size = new System.Drawing.Size(781, 737);
            this.grdMyReports.TabIndex = 22;
            this.grdMyReports.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdMyReports_CellMouseDoubleClick);
            // 
            // report_id
            // 
            this.report_id.HeaderText = "ReportId";
            this.report_id.Name = "report_id";
            this.report_id.ReadOnly = true;
            this.report_id.Visible = false;
            this.report_id.Width = 75;
            // 
            // post_id
            // 
            this.post_id.HeaderText = "PostId";
            this.post_id.Name = "post_id";
            this.post_id.ReadOnly = true;
            this.post_id.Visible = false;
            this.post_id.Width = 62;
            // 
            // post
            // 
            this.post.HeaderText = "Post Reported";
            this.post.Name = "post";
            this.post.ReadOnly = true;
            this.post.Width = 75;
            // 
            // report_text
            // 
            this.report_text.HeaderText = "Report Body";
            this.report_text.Name = "report_text";
            this.report_text.ReadOnly = true;
            this.report_text.Width = 85;
            // 
            // creation_date
            // 
            this.creation_date.HeaderText = "Creation Date";
            this.creation_date.Name = "creation_date";
            this.creation_date.ReadOnly = true;
            this.creation_date.Width = 93;
            // 
            // closing_date
            // 
            this.closing_date.HeaderText = "Closing Date";
            this.closing_date.Name = "closing_date";
            this.closing_date.ReadOnly = true;
            this.closing_date.Width = 88;
            // 
            // tpAdminPosts
            // 
            this.tpAdminPosts.HorizontalScrollbarBarColor = true;
            this.tpAdminPosts.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAdminPosts.HorizontalScrollbarSize = 10;
            this.tpAdminPosts.Location = new System.Drawing.Point(4, 38);
            this.tpAdminPosts.Name = "tpAdminPosts";
            this.tpAdminPosts.Size = new System.Drawing.Size(787, 796);
            this.tpAdminPosts.TabIndex = 4;
            this.tpAdminPosts.Text = "Posts";
            this.tpAdminPosts.VerticalScrollbarBarColor = true;
            this.tpAdminPosts.VerticalScrollbarHighlightOnWheel = false;
            this.tpAdminPosts.VerticalScrollbarSize = 10;
            // 
            // Settings
            // 
            this.Icon = Properties.Resources.tico;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 918);
            this.Controls.Add(this.metroTabControl1);
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Settings";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Settings_FormClosed);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tpMain.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpAdminReports.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdReports)).EndInit();
            this.cmOptions.ResumeLayout(false);
            this.tpReports.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMyReports)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tpReports;
        private MetroFramework.Controls.MetroTabPage tpMain;
        private MetroFramework.Controls.MetroContextMenu cmOptions;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MetroFramework.Controls.MetroTabPage tpAdminReports;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroToggle tDarkMode;
        private MetroFramework.Controls.MetroLabel lblDarkMode;
        private MetroFramework.Controls.MetroComboBox cbAccentColor;
        private MetroFramework.Controls.MetroLabel lblAccentColor;
        private MetroFramework.Controls.MetroLabel lblCustomize;
        private MetroFramework.Controls.MetroLabel lblAccount;
        private MetroFramework.Controls.MetroLabel lblChangePassword;
        private MetroFramework.Controls.MetroButton btnChangePassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroButton btnReport;
        private MetroFramework.Controls.MetroGrid grdMyReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn post_id;
        private System.Windows.Forms.DataGridViewImageColumn post;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn creation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn closing_date;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroGrid grdReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private MetroFramework.Controls.MetroTabPage tpAdminPosts;
    }
}