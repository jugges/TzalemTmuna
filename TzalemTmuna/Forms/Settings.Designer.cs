
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tpCustomize = new MetroFramework.Controls.MetroTabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDarkMode = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cbAccentColor = new MetroFramework.Controls.MetroComboBox();
            this.tDarkMode = new MetroFramework.Controls.MetroToggle();
            this.tpPassword = new MetroFramework.Controls.MetroTabPage();
            this.tpMyReports = new MetroFramework.Controls.MetroTabPage();
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
            this.tpAdmin = new MetroFramework.Controls.MetroTabPage();
            this.metroTabControl1.SuspendLayout();
            this.tpCustomize.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpMyReports.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMyReports)).BeginInit();
            this.cmOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpCustomize);
            this.metroTabControl1.Controls.Add(this.tpPassword);
            this.metroTabControl1.Controls.Add(this.tpMyReports);
            this.metroTabControl1.Controls.Add(this.tpAdmin);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(795, 838);
            this.metroTabControl1.TabIndex = 19;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tpCustomize
            // 
            this.tpCustomize.Controls.Add(this.tableLayoutPanel2);
            this.tpCustomize.HorizontalScrollbarBarColor = true;
            this.tpCustomize.HorizontalScrollbarHighlightOnWheel = false;
            this.tpCustomize.HorizontalScrollbarSize = 10;
            this.tpCustomize.Location = new System.Drawing.Point(4, 38);
            this.tpCustomize.Name = "tpCustomize";
            this.tpCustomize.Size = new System.Drawing.Size(787, 796);
            this.tpCustomize.TabIndex = 2;
            this.tpCustomize.Text = "Customize";
            this.tpCustomize.VerticalScrollbarBarColor = true;
            this.tpCustomize.VerticalScrollbarHighlightOnWheel = false;
            this.tpCustomize.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.15863F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.84137F));
            this.tableLayoutPanel2.Controls.Add(this.lblDarkMode, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbAccentColor, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.tDarkMode, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(787, 796);
            this.tableLayoutPanel2.TabIndex = 24;
            // 
            // lblDarkMode
            // 
            this.lblDarkMode.AutoSize = true;
            this.lblDarkMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDarkMode.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.lblDarkMode.Location = new System.Drawing.Point(3, 3);
            this.lblDarkMode.Margin = new System.Windows.Forms.Padding(3);
            this.lblDarkMode.Name = "lblDarkMode";
            this.lblDarkMode.Size = new System.Drawing.Size(672, 36);
            this.lblDarkMode.TabIndex = 24;
            this.lblDarkMode.Text = "Dark mode";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.metroLabel2.Location = new System.Drawing.Point(3, 45);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(672, 36);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Accent color";
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
            this.cbAccentColor.Location = new System.Drawing.Point(681, 48);
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
            this.tDarkMode.Location = new System.Drawing.Point(681, 4);
            this.tDarkMode.Margin = new System.Windows.Forms.Padding(1, 4, 1, 6);
            this.tDarkMode.Name = "tDarkMode";
            this.tDarkMode.Size = new System.Drawing.Size(103, 32);
            this.tDarkMode.TabIndex = 2;
            this.tDarkMode.Text = "On";
            this.tDarkMode.UseSelectable = true;
            // 
            // tpPassword
            // 
            this.tpPassword.HorizontalScrollbarBarColor = true;
            this.tpPassword.HorizontalScrollbarHighlightOnWheel = false;
            this.tpPassword.HorizontalScrollbarSize = 10;
            this.tpPassword.Location = new System.Drawing.Point(4, 38);
            this.tpPassword.Name = "tpPassword";
            this.tpPassword.Size = new System.Drawing.Size(787, 796);
            this.tpPassword.TabIndex = 0;
            this.tpPassword.Text = "Change Password";
            this.tpPassword.VerticalScrollbarBarColor = true;
            this.tpPassword.VerticalScrollbarHighlightOnWheel = false;
            this.tpPassword.VerticalScrollbarSize = 10;
            // 
            // tpMyReports
            // 
            this.tpMyReports.Controls.Add(this.tableLayoutPanel1);
            this.tpMyReports.HorizontalScrollbarBarColor = true;
            this.tpMyReports.HorizontalScrollbarHighlightOnWheel = false;
            this.tpMyReports.HorizontalScrollbarSize = 10;
            this.tpMyReports.Location = new System.Drawing.Point(4, 38);
            this.tpMyReports.Name = "tpMyReports";
            this.tpMyReports.Size = new System.Drawing.Size(787, 796);
            this.tpMyReports.TabIndex = 1;
            this.tpMyReports.Text = "My Reports";
            this.tpMyReports.VerticalScrollbarBarColor = true;
            this.tpMyReports.VerticalScrollbarHighlightOnWheel = false;
            this.tpMyReports.VerticalScrollbarSize = 10;
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
            this.grdMyReports.Location = new System.Drawing.Point(3, 28);
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
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tpCustomize.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tpMyReports.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMyReports)).EndInit();
            this.cmOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tpPassword;
        private MetroFramework.Controls.MetroTabPage tpMyReports;
        private MetroFramework.Controls.MetroTabPage tpCustomize;
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
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cbAccentColor;
    }
}