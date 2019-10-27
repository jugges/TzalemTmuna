namespace TzalemTmuna.Forms
{
    partial class Request
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
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.btnDecline = new MetroFramework.Controls.MetroButton();
            this.lblFullName = new MetroFramework.Controls.MetroLabel();
            this.btnAccept = new MetroFramework.Controls.MetroButton();
            this.ProfilePicture = new TzalemTmuna.Forms.ProfilePicture();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(60, 3);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            this.lblUsername.UseCustomBackColor = true;
            this.lblUsername.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.Location = new System.Drawing.Point(192, 11);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(46, 32);
            this.btnDecline.TabIndex = 2;
            this.btnDecline.TabStop = false;
            this.btnDecline.Text = "Decline";
            this.btnDecline.UseSelectable = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFullName.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(60, 28);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(38, 15);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Name";
            this.lblFullName.UseCustomBackColor = true;
            this.lblFullName.Click += new System.EventHandler(this.lblFullName_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(244, 11);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(46, 32);
            this.btnAccept.TabIndex = 5;
            this.btnAccept.TabStop = false;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseSelectable = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ProfilePicture.Image = global::TzalemTmuna.Properties.Resources.emptyprofilepicture;
            this.ProfilePicture.Location = new System.Drawing.Point(3, 3);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(51, 48);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 0;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            // 
            // Request
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnDecline);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.btnAccept);
            this.Name = "Request";
            this.Size = new System.Drawing.Size(301, 54);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ProfilePicture ProfilePicture;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroButton btnDecline;
        private MetroFramework.Controls.MetroLabel lblFullName;
        private MetroFramework.Controls.MetroButton btnAccept;
    }
}
