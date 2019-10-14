
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
            this.btnProfilePicture = new MetroFramework.Controls.MetroLink();
            this.txtFullName = new MetroFramework.Controls.MetroTextBox();
            this.txtBiography = new MetroFramework.Controls.MetroTextBox();
            this.profilePicture1 = new TzalemTmuna.Forms.ProfilePicture();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.Location = new System.Drawing.Point(12, 426);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(332, 47);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnProfilePicture
            // 
            this.btnProfilePicture.Location = new System.Drawing.Point(99, 230);
            this.btnProfilePicture.Name = "btnProfilePicture";
            this.btnProfilePicture.Size = new System.Drawing.Size(150, 15);
            this.btnProfilePicture.TabIndex = 15;
            this.btnProfilePicture.TabStop = false;
            this.btnProfilePicture.Text = "Change Profile Picture";
            this.btnProfilePicture.UseCustomBackColor = true;
            this.btnProfilePicture.UseSelectable = true;
            this.btnProfilePicture.Click += new System.EventHandler(this.btnProfilePicture_Click);
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
            this.txtFullName.Location = new System.Drawing.Point(12, 260);
            this.txtFullName.MaxLength = 0;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PromptText = "Full Name";
            this.txtFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(332, 47);
            this.txtFullName.TabIndex = 16;
            this.txtFullName.UseSelectable = true;
            this.txtFullName.UseStyleColors = true;
            this.txtFullName.WaterMark = "Full Name";
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
            this.txtBiography.Location = new System.Drawing.Point(12, 313);
            this.txtBiography.MaxLength = 255;
            this.txtBiography.Multiline = true;
            this.txtBiography.Name = "txtBiography";
            this.txtBiography.PasswordChar = '\0';
            this.txtBiography.PromptText = "Biography";
            this.txtBiography.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBiography.SelectedText = "";
            this.txtBiography.SelectionLength = 0;
            this.txtBiography.SelectionStart = 0;
            this.txtBiography.ShortcutsEnabled = true;
            this.txtBiography.Size = new System.Drawing.Size(332, 107);
            this.txtBiography.TabIndex = 17;
            this.txtBiography.UseSelectable = true;
            this.txtBiography.UseStyleColors = true;
            this.txtBiography.WaterMark = "Biography";
            this.txtBiography.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBiography.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // profilePicture1
            // 
            this.profilePicture1.Image = global::TzalemTmuna.Properties.Resources.emptyprofilepicture;
            this.profilePicture1.Location = new System.Drawing.Point(99, 63);
            this.profilePicture1.Name = "profilePicture1";
            this.profilePicture1.Size = new System.Drawing.Size(150, 150);
            this.profilePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture1.TabIndex = 14;
            this.profilePicture1.TabStop = false;
            // 
            // EditProfile
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 490);
            this.Controls.Add(this.txtBiography);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.btnProfilePicture);
            this.Controls.Add(this.profilePicture1);
            this.Controls.Add(this.btnSubmit);
            this.MaximizeBox = false;
            this.Name = "EditProfile";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Edit Profile";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProfilePicture profilePicture1;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroLink btnProfilePicture;
        private MetroFramework.Controls.MetroTextBox txtFullName;
        private MetroFramework.Controls.MetroTextBox txtBiography;
    }
}