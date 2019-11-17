
namespace TzalemTmuna.Forms
{
    partial class ViewPost
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
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.lblText = new MetroFramework.Controls.MetroLabel();
            this.profilePicture = new TzalemTmuna.Forms.ProfilePicture();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(640, 640);
            this.pbPhoto.TabIndex = 27;
            this.pbPhoto.TabStop = false;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Enabled = false;
            this.lblText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblText.Location = new System.Drawing.Point(700, 40);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(40, 25);
            this.lblText.TabIndex = 26;
            this.lblText.Text = "Text";
            this.lblText.UseCustomBackColor = true;
            // 
            // profilePicture
            // 
            this.profilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePicture.Image = global::TzalemTmuna.Properties.Resources.emptyprofilepicture;
            this.profilePicture.Location = new System.Drawing.Point(646, 17);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(48, 48);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 28;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.profilePicture_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(700, 21);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username";
            this.lblUsername.UseCustomBackColor = true;
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // ViewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 640);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.pbPhoto);
            this.MaximizeBox = false;
            this.Name = "ViewPost";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPhoto;
        private MetroFramework.Controls.MetroLabel lblText;
        private ProfilePicture profilePicture;
        private MetroFramework.Controls.MetroLabel lblUsername;
    }
}