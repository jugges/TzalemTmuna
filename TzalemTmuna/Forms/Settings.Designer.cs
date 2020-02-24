
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.tpAdmin = new MetroFramework.Controls.MetroTabPage();
            this.tpReports = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnReport = new MetroFramework.Controls.MetroButton();
            this.lblMyReports = new MetroFramework.Controls.MetroLabel();
            this.grdMyReports = new MetroFramework.Controls.MetroGrid();
            this.report_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.post = new System.Windows.Forms.DataGridViewImageColumn();
            this.report_text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creation_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.closing_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmOptions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1.SuspendLayout();
            this.tpMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpReports.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMyReports)).BeginInit();
            this.cmOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpMain);
            this.metroTabControl1.Controls.Add(this.tpAdmin);
            this.metroTabControl1.Controls.Add(this.tpReports);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
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
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(787, 796);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // lblChangePassword
            // 
            this.lblChangePassword.AutoSize = true;
            this.lblChangePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChangePassword.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.lblChangePassword.Location = new System.Drawing.Point(3, 213);
            this.lblChangePassword.Margin = new System.Windows.Forms.Padding(3);
            this.lblChangePassword.Name = "lblChangePassword";
            this.lblChangePassword.Size = new System.Drawing.Size(672, 580);
            this.lblChangePassword.TabIndex = 29;
            this.lblChangePassword.Text = "Change Password";
            // 
            // lblAccount
            // 
            this.lblAccount.AutoSize = true;
            this.lblAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAccount.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.lblAccount.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAccount.Location = new System.Drawing.Point(3, 171);
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
            this.btnChangePassword.Location = new System.Drawing.Point(681, 213);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(103, 36);
            this.btnChangePassword.TabIndex = 30;
            this.btnChangePassword.Text = "Change";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // tpAdmin
            // 
            this.tpAdmin.HorizontalScrollbarBarColor = true;
            this.tpAdmin.HorizontalScrollbarHighlightOnWheel = false;
            this.tpAdmin.HorizontalScrollbarSize = 10;
            this.tpAdmin.Location = new System.Drawing.Point(4, 38);
            this.tpAdmin.Name = "tpAdmin";
            this.tpAdmin.Size = new System.Drawing.Size(787, 796);
            this.tpAdmin.TabIndex = 3;
            this.tpAdmin.Text = "Admin";
            this.tpAdmin.VerticalScrollbarBarColor = true;
            this.tpAdmin.VerticalScrollbarHighlightOnWheel = false;
            this.tpAdmin.VerticalScrollbarSize = 10;
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
            this.tableLayoutPanel1.Controls.Add(this.lblMyReports, 0, 0);
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
            // lblMyReports
            // 
            this.lblMyReports.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMyReports.AutoSize = true;
            this.lblMyReports.Location = new System.Drawing.Point(3, 3);
            this.lblMyReports.Margin = new System.Windows.Forms.Padding(3);
            this.lblMyReports.Name = "lblMyReports";
            this.lblMyReports.Size = new System.Drawing.Size(80, 19);
            this.lblMyReports.TabIndex = 21;
            this.lblMyReports.Text = "My Reports:";
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMyReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdMyReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMyReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.report_id,
            this.post_id,
            this.post,
            this.report_text,
            this.creation_date,
            this.closing_date});
            this.grdMyReports.ContextMenuStrip = this.cmOptions;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMyReports.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdMyReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdMyReports.EnableHeadersVisualStyles = false;
            this.grdMyReports.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grdMyReports.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grdMyReports.Location = new System.Drawing.Point(3, 28);
            this.grdMyReports.MultiSelect = false;
            this.grdMyReports.Name = "grdMyReports";
            this.grdMyReports.ReadOnly = true;
            this.grdMyReports.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMyReports.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdMyReports.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grdMyReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdMyReports.Size = new System.Drawing.Size(781, 712);
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
            this.report_text.Width = 86;
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
            // Settings
            // 
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
            this.tpReports.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMyReports)).EndInit();
            this.cmOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tpReports;
        private MetroFramework.Controls.MetroTabPage tpMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel lblMyReports;
        private MetroFramework.Controls.MetroButton btnReport;
        private MetroFramework.Controls.MetroGrid grdMyReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn post_id;
        private System.Windows.Forms.DataGridViewImageColumn post;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn creation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn closing_date;
        private MetroFramework.Controls.MetroContextMenu cmOptions;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private MetroFramework.Controls.MetroTabPage tpAdmin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroToggle tDarkMode;
        private MetroFramework.Controls.MetroLabel lblDarkMode;
        private MetroFramework.Controls.MetroComboBox cbAccentColor;
        private MetroFramework.Controls.MetroLabel lblAccentColor;
        private MetroFramework.Controls.MetroLabel lblCustomize;
        private MetroFramework.Controls.MetroLabel lblChangePassword;
        private MetroFramework.Controls.MetroLabel lblAccount;
        private MetroFramework.Controls.MetroButton btnChangePassword;
    }
}