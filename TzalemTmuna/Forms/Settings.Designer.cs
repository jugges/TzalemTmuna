
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
            this.tpCustomize = new MetroFramework.Controls.MetroTabPage();
            this.lblDarkMode = new MetroFramework.Controls.MetroLabel();
            this.tDarkMode = new MetroFramework.Controls.MetroToggle();
            this.tpPassword = new MetroFramework.Controls.MetroTabPage();
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
            this.tpCustomize.SuspendLayout();
            this.tpReports.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMyReports)).BeginInit();
            this.cmOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tpCustomize);
            this.metroTabControl1.Controls.Add(this.tpPassword);
            this.metroTabControl1.Controls.Add(this.tpReports);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(795, 838);
            this.metroTabControl1.TabIndex = 19;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tpCustomize
            // 
            this.tpCustomize.Controls.Add(this.lblDarkMode);
            this.tpCustomize.Controls.Add(this.tDarkMode);
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
            // lblDarkMode
            // 
            this.lblDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDarkMode.AutoSize = true;
            this.lblDarkMode.Location = new System.Drawing.Point(3, 3);
            this.lblDarkMode.Margin = new System.Windows.Forms.Padding(3);
            this.lblDarkMode.Name = "lblDarkMode";
            this.lblDarkMode.Size = new System.Drawing.Size(78, 19);
            this.lblDarkMode.TabIndex = 21;
            this.lblDarkMode.Text = "Dark Mode:";
            // 
            // tDarkMode
            // 
            this.tDarkMode.AutoSize = true;
            this.tDarkMode.Checked = true;
            this.tDarkMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tDarkMode.Location = new System.Drawing.Point(87, 5);
            this.tDarkMode.Name = "tDarkMode";
            this.tDarkMode.Size = new System.Drawing.Size(80, 17);
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
            this.Load += new System.EventHandler(this.Settings_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tpCustomize.ResumeLayout(false);
            this.tpCustomize.PerformLayout();
            this.tpReports.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMyReports)).EndInit();
            this.cmOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tpPassword;
        private MetroFramework.Controls.MetroTabPage tpReports;
        private MetroFramework.Controls.MetroTabPage tpCustomize;
        private MetroFramework.Controls.MetroToggle tDarkMode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel lblMyReports;
        private MetroFramework.Controls.MetroButton btnReport;
        private MetroFramework.Controls.MetroLabel lblDarkMode;
        private MetroFramework.Controls.MetroGrid grdMyReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn post_id;
        private System.Windows.Forms.DataGridViewImageColumn post;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_text;
        private System.Windows.Forms.DataGridViewTextBoxColumn creation_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn closing_date;
        private MetroFramework.Controls.MetroContextMenu cmOptions;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}