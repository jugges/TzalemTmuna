namespace TzalemTmuna.Forms
{
    partial class CommentControl
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
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblText = new MetroFramework.Controls.MetroLabel();
            this.btnMenu = new MetroFramework.Controls.MetroLabel();
            this.cmOptions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtText = new MetroFramework.Controls.MetroTextBox();
            this.btnEdit = new MetroFramework.Controls.MetroLabel();
            this.ProfilePicture = new TzalemTmuna.Forms.ProfilePicture();
            this.cmOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsername.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(48, 8);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(64, 15);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.UseCustomBackColor = true;
            this.lblUsername.Click += new System.EventHandler(this.OpenProfile);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblText.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblText.ForeColor = System.Drawing.Color.White;
            this.lblText.Location = new System.Drawing.Point(48, 23);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 15);
            this.lblText.TabIndex = 3;
            this.lblText.Text = "Text";
            this.lblText.UseCustomBackColor = true;
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.Transparent;
            this.btnMenu.ContextMenuStrip = this.cmOptions;
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMenu.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.btnMenu.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.btnMenu.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMenu.Location = new System.Drawing.Point(242, 0);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(38, 48);
            this.btnMenu.TabIndex = 32;
            this.btnMenu.Text = "☰";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMenu.UseCustomBackColor = true;
            this.btnMenu.UseCustomForeColor = true;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // cmOptions
            // 
            this.cmOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.removeToolStripMenuItem});
            this.cmOptions.Name = "cmOptions";
            this.cmOptions.Size = new System.Drawing.Size(118, 48);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // txtText
            // 
            // 
            // 
            // 
            this.txtText.CustomButton.Image = null;
            this.txtText.CustomButton.Location = new System.Drawing.Point(14, 1);
            this.txtText.CustomButton.Name = "";
            this.txtText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtText.CustomButton.TabIndex = 1;
            this.txtText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtText.CustomButton.UseSelectable = true;
            this.txtText.CustomButton.Visible = false;
            this.txtText.Lines = new string[] {
        "Text"};
            this.txtText.Location = new System.Drawing.Point(48, 23);
            this.txtText.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.txtText.MaxLength = 32767;
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '\0';
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtText.SelectedText = "";
            this.txtText.SelectionLength = 0;
            this.txtText.SelectionStart = 0;
            this.txtText.ShortcutsEnabled = true;
            this.txtText.Size = new System.Drawing.Size(36, 23);
            this.txtText.TabIndex = 34;
            this.txtText.Text = "Text";
            this.txtText.UseSelectable = true;
            this.txtText.Visible = false;
            this.txtText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEdit.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.btnEdit.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEdit.Location = new System.Drawing.Point(190, 0);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(52, 48);
            this.btnEdit.TabIndex = 35;
            this.btnEdit.Text = "✅";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.UseCustomBackColor = true;
            this.btnEdit.UseCustomForeColor = true;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePicture.Image = global::TzalemTmuna.Properties.Resources.emptyprofilepicture;
            this.ProfilePicture.Location = new System.Drawing.Point(10, 8);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(32, 32);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.OpenProfile);
            // 
            // CommentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.lblText);
            this.MinimumSize = new System.Drawing.Size(290, 48);
            this.Name = "CommentControl";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.Size = new System.Drawing.Size(290, 48);
            this.ParentChanged += new System.EventHandler(this.CommentControl_ParentChanged);
            this.cmOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProfilePicture ProfilePicture;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblText;
        private MetroFramework.Controls.MetroLabel btnMenu;
        private MetroFramework.Controls.MetroContextMenu cmOptions;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox txtText;
        private MetroFramework.Controls.MetroLabel btnEdit;
    }
}
