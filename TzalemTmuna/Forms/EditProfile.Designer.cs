
namespace TzalemTmuna.Forms
{
    partial class EditProfile
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
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.txtBiography = new MetroFramework.Controls.MetroTextBox();
            this.lblChangeProfilePicture = new MetroFramework.Controls.MetroLabel();
            this.txtWebsite = new MetroFramework.Controls.MetroTextBox();
            this.chkPrivateAccount = new MetroFramework.Controls.MetroCheckBox();
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblWebsite = new MetroFramework.Controls.MetroLabel();
            this.lblBio = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.ProfilePicture = new TzalemTmuna.Forms.ProfilePicture();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.Location = new System.Drawing.Point(111, 544);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(332, 47);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtFullName
            // 
            // 
            // 
            // 
            this.txtFullName.CustomButton.Image = null;
            this.txtFullName.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtFullName.CustomButton.Name = "";
            this.txtFullName.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtFullName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFullName.CustomButton.TabIndex = 1;
            this.txtFullName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFullName.CustomButton.UseSelectable = true;
            this.txtFullName.CustomButton.Visible = false;
            this.txtFullName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtFullName.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtFullName.Lines = new string[0];
            this.txtFullName.Location = new System.Drawing.Point(111, 219);
            this.txtFullName.MaxLength = 0;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(332, 47);
            this.txtFullName.TabIndex = 2;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.UseStyleColors = true;
            this.txtFullName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFullName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtBiography
            // 
            // 
            // 
            // 
            this.txtBiography.CustomButton.Image = null;
            this.txtBiography.CustomButton.Location = new System.Drawing.Point(226, 1);
            this.txtBiography.CustomButton.Name = "";
            this.txtBiography.CustomButton.Size = new System.Drawing.Size(105, 105);
            this.txtBiography.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBiography.CustomButton.TabIndex = 1;
            this.txtBiography.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBiography.CustomButton.UseSelectable = true;
            this.txtBiography.CustomButton.Visible = false;
            this.txtBiography.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBiography.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtBiography.Lines = new string[0];
            this.txtBiography.Location = new System.Drawing.Point(111, 378);
            this.txtBiography.MaxLength = 255;
            this.txtBiography.Multiline = true;
            this.txtBiography.Name = "txtBiography";
            this.txtBiography.PasswordChar = '\0';
            this.txtBiography.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBiography.SelectedText = "";
            this.txtBiography.SelectionLength = 0;
            this.txtBiography.SelectionStart = 0;
            this.txtBiography.ShortcutsEnabled = true;
            this.txtBiography.Size = new System.Drawing.Size(332, 107);
            this.txtBiography.TabIndex = 5;
            this.txtBiography.UseSelectable = true;
            this.txtBiography.UseStyleColors = true;
            this.txtBiography.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBiography.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblChangeProfilePicture
            // 
            this.lblChangeProfilePicture.AutoSize = true;
            this.lblChangeProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.lblChangeProfilePicture.Enabled = false;
            this.lblChangeProfilePicture.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblChangeProfilePicture.Location = new System.Drawing.Point(207, 108);
            this.lblChangeProfilePicture.Name = "lblChangeProfilePicture";
            this.lblChangeProfilePicture.Size = new System.Drawing.Size(140, 19);
            this.lblChangeProfilePicture.TabIndex = 18;
            this.lblChangeProfilePicture.Text = "Change Profile Picture";
            this.lblChangeProfilePicture.UseCustomBackColor = true;
            this.lblChangeProfilePicture.UseCustomForeColor = true;
            this.lblChangeProfilePicture.Visible = false;
            // 
            // txtWebsite
            // 
            // 
            // 
            // 
            this.txtWebsite.CustomButton.Image = null;
            this.txtWebsite.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtWebsite.CustomButton.Name = "";
            this.txtWebsite.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtWebsite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtWebsite.CustomButton.TabIndex = 1;
            this.txtWebsite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtWebsite.CustomButton.UseSelectable = true;
            this.txtWebsite.CustomButton.Visible = false;
            this.txtWebsite.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtWebsite.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtWebsite.Lines = new string[0];
            this.txtWebsite.Location = new System.Drawing.Point(111, 325);
            this.txtWebsite.MaxLength = 0;
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.PasswordChar = '\0';
            this.txtWebsite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtWebsite.SelectedText = "";
            this.txtWebsite.SelectionLength = 0;
            this.txtWebsite.SelectionStart = 0;
            this.txtWebsite.ShortcutsEnabled = true;
            this.txtWebsite.Size = new System.Drawing.Size(332, 47);
            this.txtWebsite.TabIndex = 4;
            this.txtWebsite.UseSelectable = true;
            this.txtWebsite.UseStyleColors = true;
            this.txtWebsite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtWebsite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // chkPrivateAccount
            // 
            this.chkPrivateAccount.AutoSize = true;
            this.chkPrivateAccount.Checked = true;
            this.chkPrivateAccount.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPrivateAccount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.chkPrivateAccount.Location = new System.Drawing.Point(111, 198);
            this.chkPrivateAccount.Name = "chkPrivateAccount";
            this.chkPrivateAccount.Size = new System.Drawing.Size(107, 15);
            this.chkPrivateAccount.TabIndex = 1;
            this.chkPrivateAccount.Text = "Private Account";
            this.chkPrivateAccount.UseCustomBackColor = true;
            this.chkPrivateAccount.UseSelectable = true;
            this.chkPrivateAccount.UseStyleColors = true;
            // 
            // txtUsername
            // 
            // 
            // 
            // 
            this.txtUsername.CustomButton.Image = null;
            this.txtUsername.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtUsername.CustomButton.Name = "";
            this.txtUsername.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUsername.CustomButton.TabIndex = 1;
            this.txtUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUsername.CustomButton.UseSelectable = true;
            this.txtUsername.CustomButton.Visible = false;
            this.txtUsername.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtUsername.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtUsername.Lines = new string[0];
            this.txtUsername.Location = new System.Drawing.Point(111, 272);
            this.txtUsername.MaxLength = 12;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(332, 47);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.UseStyleColors = true;
            this.txtUsername.WaterMark = "can only contain english letters and underscores";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtEmail.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(111, 491);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(332, 47);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.UseStyleColors = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Enabled = false;
            this.lblName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblName.Location = new System.Drawing.Point(47, 229);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 25);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name";
            this.lblName.UseCustomBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Enabled = false;
            this.lblUsername.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUsername.Location = new System.Drawing.Point(16, 283);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(89, 25);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "Username";
            this.lblUsername.UseCustomBackColor = true;
            // 
            // lblWebsite
            // 
            this.lblWebsite.AutoSize = true;
            this.lblWebsite.BackColor = System.Drawing.Color.Transparent;
            this.lblWebsite.Enabled = false;
            this.lblWebsite.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblWebsite.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblWebsite.Location = new System.Drawing.Point(34, 336);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(71, 25);
            this.lblWebsite.TabIndex = 25;
            this.lblWebsite.Text = "Website";
            this.lblWebsite.UseCustomBackColor = true;
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.BackColor = System.Drawing.Color.Transparent;
            this.lblBio.Enabled = false;
            this.lblBio.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblBio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBio.Location = new System.Drawing.Point(69, 419);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(36, 25);
            this.lblBio.TabIndex = 26;
            this.lblBio.Text = "Bio";
            this.lblBio.UseCustomBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Enabled = false;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblEmail.Location = new System.Drawing.Point(52, 502);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 25);
            this.lblEmail.TabIndex = 27;
            this.lblEmail.Text = "Email";
            this.lblEmail.UseCustomBackColor = true;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ProfilePicture.Image = global::TzalemTmuna.Properties.Resources.emptyprofilepicture;
            this.ProfilePicture.Location = new System.Drawing.Point(202, 42);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(150, 150);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 14;
            this.ProfilePicture.TabStop = false;
            this.ProfilePicture.Click += new System.EventHandler(this.ProfilePicture_Click);
            this.ProfilePicture.MouseEnter += new System.EventHandler(this.ProfilePicture_MouseEnter);
            this.ProfilePicture.MouseLeave += new System.EventHandler(this.ProfilePicture_MouseLeave);
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 613);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblBio);
            this.Controls.Add(this.lblWebsite);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.chkPrivateAccount);
            this.Controls.Add(this.txtWebsite);
            this.Controls.Add(this.txtBiography);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblChangeProfilePicture);
            this.Controls.Add(this.ProfilePicture);
            this.MaximizeBox = false;
            this.Name = "EditProfile";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Edit Profile";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ProfilePicture ProfilePicture;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroTextBox txtFullName;
        private MetroFramework.Controls.MetroTextBox txtBiography;
        private MetroFramework.Controls.MetroLabel lblChangeProfilePicture;
        private MetroFramework.Controls.MetroTextBox txtWebsite;
        private MetroFramework.Controls.MetroCheckBox chkPrivateAccount;
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroLabel lblWebsite;
        private MetroFramework.Controls.MetroLabel lblBio;
        private MetroFramework.Controls.MetroLabel lblEmail;
    }
}