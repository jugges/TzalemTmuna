namespace TzalemTmuna.Forms
{
    partial class FeedThumbnail
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pb = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblComments = new MetroFramework.Controls.MetroLabel();
            this.lblLatestComment = new MetroFramework.Controls.MetroLabel();
            this.lblText = new MetroFramework.Controls.MetroLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbLike = new System.Windows.Forms.PictureBox();
            this.pbComment = new System.Windows.Forms.PictureBox();
            this.lblLikes = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMenu = new MetroFramework.Controls.MetroLabel();
            this.cmOptions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.profilePicture = new TzalemTmuna.Forms.ProfilePicture();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComment)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 520F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(520, 746);
            this.tableLayoutPanel1.TabIndex = 28;
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Image = global::TzalemTmuna.Properties.Resources.tzalemtmuna;
            this.pb.Location = new System.Drawing.Point(0, 54);
            this.pb.Margin = new System.Windows.Forms.Padding(0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(520, 520);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 3;
            this.pb.TabStop = false;
            this.pb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.pb_MouseDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblComments);
            this.panel2.Controls.Add(this.lblLatestComment);
            this.panel2.Controls.Add(this.lblText);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.lblLikes);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 577);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel2.Size = new System.Drawing.Size(514, 166);
            this.panel2.TabIndex = 5;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.BackColor = System.Drawing.Color.Transparent;
            this.lblComments.Enabled = false;
            this.lblComments.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblComments.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblComments.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblComments.Location = new System.Drawing.Point(10, 47);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(83, 15);
            this.lblComments.TabIndex = 32;
            this.lblComments.Text = "15 comments";
            this.lblComments.UseCustomBackColor = true;
            this.lblComments.UseCustomForeColor = true;
            // 
            // lblLatestComment
            // 
            this.lblLatestComment.AutoSize = true;
            this.lblLatestComment.BackColor = System.Drawing.Color.Transparent;
            this.lblLatestComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLatestComment.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblLatestComment.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblLatestComment.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLatestComment.Location = new System.Drawing.Point(34, 87);
            this.lblLatestComment.Name = "lblLatestComment";
            this.lblLatestComment.Size = new System.Drawing.Size(90, 15);
            this.lblLatestComment.TabIndex = 31;
            this.lblLatestComment.Text = "User: Comment";
            this.lblLatestComment.UseCustomBackColor = true;
            this.lblLatestComment.UseCustomForeColor = true;
            this.lblLatestComment.Click += new System.EventHandler(this.lblLatestComment_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Enabled = false;
            this.lblText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblText.Location = new System.Drawing.Point(15, 62);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(78, 19);
            this.lblText.TabIndex = 30;
            this.lblText.Text = "Description";
            this.lblText.UseCustomBackColor = true;
            this.lblText.UseCustomForeColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.pbLike);
            this.panel3.Controls.Add(this.pbComment);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel3.Size = new System.Drawing.Size(514, 24);
            this.panel3.TabIndex = 28;
            // 
            // pbLike
            // 
            this.pbLike.BackColor = System.Drawing.Color.Transparent;
            this.pbLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLike.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLike.Location = new System.Drawing.Point(44, 0);
            this.pbLike.Name = "pbLike";
            this.pbLike.Size = new System.Drawing.Size(24, 24);
            this.pbLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLike.TabIndex = 31;
            this.pbLike.TabStop = false;
            // 
            // pbComment
            // 
            this.pbComment.BackColor = System.Drawing.Color.Transparent;
            this.pbComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbComment.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbComment.Location = new System.Drawing.Point(10, 0);
            this.pbComment.Name = "pbComment";
            this.pbComment.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pbComment.Size = new System.Drawing.Size(34, 24);
            this.pbComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComment.TabIndex = 30;
            this.pbComment.TabStop = false;
            this.pbComment.Click += new System.EventHandler(this.pbComment_Click);
            // 
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.BackColor = System.Drawing.Color.Transparent;
            this.lblLikes.Enabled = false;
            this.lblLikes.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblLikes.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLikes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLikes.Location = new System.Drawing.Point(10, 32);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(49, 15);
            this.lblLikes.TabIndex = 29;
            this.lblLikes.Text = "15 likes";
            this.lblLikes.UseCustomBackColor = true;
            this.lblLikes.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMenu);
            this.panel1.Controls.Add(this.lblUsername);
            this.panel1.Controls.Add(this.profilePicture);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 48);
            this.panel1.TabIndex = 4;
            // 
            // btnMenu
            // 
            this.btnMenu.AutoSize = true;
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.ContextMenuStrip = this.cmOptions;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.btnMenu.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenu.Location = new System.Drawing.Point(473, 6);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 36);
            this.btnMenu.TabIndex = 31;
            this.btnMenu.Text = "☰";
            this.btnMenu.UseCustomBackColor = true;
            this.btnMenu.UseCustomForeColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // cmOptions
            // 
            this.cmOptions.BackColor = System.Drawing.SystemColors.Control;
            this.cmOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem});
            this.cmOptions.Name = "cmOptions";
            this.cmOptions.Size = new System.Drawing.Size(110, 26);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblUsername.AutoSize = true;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(57, 12);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.TabIndex = 30;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsername.UseCustomBackColor = true;
            this.lblUsername.UseCustomForeColor = true;
            this.lblUsername.Click += new System.EventHandler(this.OpenProfile);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.profilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePicture.Image = global::TzalemTmuna.Properties.Resources.emptyprofilepicture;
            this.profilePicture.Location = new System.Drawing.Point(3, 0);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(48, 48);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 0;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.OpenProfile);
            // 
            // FeedThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FeedThumbnail";
            this.Size = new System.Drawing.Size(520, 746);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.Panel panel1;
        private ProfilePicture profilePicture;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbComment;
        private MetroFramework.Controls.MetroLabel lblLikes;
        private MetroFramework.Controls.MetroLabel lblText;
        private MetroFramework.Controls.MetroLabel btnMenu;
        private MetroFramework.Controls.MetroLabel lblLatestComment;
        private MetroFramework.Controls.MetroContextMenu cmOptions;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblComments;
        private System.Windows.Forms.PictureBox pbLike;
    }
}
