
namespace TzalemTmuna.Forms
{
    partial class ForgotPassword
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
            this.btnSendPRC = new MetroFramework.Controls.MetroButton();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPRC = new MetroFramework.Controls.MetroTextBox();
            this.txtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnChangePassword = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // btnSendPRC
            // 
            this.btnSendPRC.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSendPRC.Location = new System.Drawing.Point(12, 116);
            this.btnSendPRC.Name = "btnSendPRC";
            this.btnSendPRC.Size = new System.Drawing.Size(332, 47);
            this.btnSendPRC.TabIndex = 6;
            this.btnSendPRC.Text = "Send Password Recovery Code";
            this.btnSendPRC.UseSelectable = true;
            this.btnSendPRC.Click += new System.EventHandler(this.btnSubmit_Click);
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
            this.txtEmail.Location = new System.Drawing.Point(12, 63);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(332, 47);
            this.txtEmail.TabIndex = 2;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.UseStyleColors = true;
            this.txtEmail.WaterMark = "Email Address";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPRC
            // 
            // 
            // 
            // 
            this.txtPRC.CustomButton.Image = null;
            this.txtPRC.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtPRC.CustomButton.Name = "";
            this.txtPRC.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtPRC.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPRC.CustomButton.TabIndex = 1;
            this.txtPRC.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPRC.CustomButton.UseSelectable = true;
            this.txtPRC.CustomButton.Visible = false;
            this.txtPRC.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPRC.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtPRC.Lines = new string[0];
            this.txtPRC.Location = new System.Drawing.Point(12, 169);
            this.txtPRC.MaxLength = 32767;
            this.txtPRC.Name = "txtPRC";
            this.txtPRC.PasswordChar = '\0';
            this.txtPRC.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPRC.SelectedText = "";
            this.txtPRC.SelectionLength = 0;
            this.txtPRC.SelectionStart = 0;
            this.txtPRC.ShortcutsEnabled = true;
            this.txtPRC.Size = new System.Drawing.Size(332, 47);
            this.txtPRC.TabIndex = 7;
            this.txtPRC.UseSelectable = true;
            this.txtPRC.UseStyleColors = true;
            this.txtPRC.WaterMark = "Password Recovery Code";
            this.txtPRC.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPRC.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewPassword
            // 
            // 
            // 
            // 
            this.txtNewPassword.CustomButton.Image = null;
            this.txtNewPassword.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtNewPassword.CustomButton.Name = "";
            this.txtNewPassword.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPassword.CustomButton.TabIndex = 1;
            this.txtNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPassword.CustomButton.UseSelectable = true;
            this.txtNewPassword.CustomButton.Visible = false;
            this.txtNewPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtNewPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtNewPassword.Lines = new string[0];
            this.txtNewPassword.Location = new System.Drawing.Point(12, 222);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.Size = new System.Drawing.Size(332, 47);
            this.txtNewPassword.TabIndex = 9;
            this.txtNewPassword.UseSelectable = true;
            this.txtNewPassword.UseStyleColors = true;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.WaterMark = "New Password, minimum length must be 5 characters";
            this.txtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnChangePassword.Location = new System.Drawing.Point(12, 275);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(332, 47);
            this.btnChangePassword.TabIndex = 10;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // ForgotPassword
            // 
            this.AcceptButton = this.btnSendPRC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 330);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtPRC);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSendPRC);
            this.MaximizeBox = false;
            this.Name = "ForgotPassword";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Forgot Password";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSendPRC;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPRC;
        private MetroFramework.Controls.MetroTextBox txtNewPassword;
        private MetroFramework.Controls.MetroButton btnChangePassword;
    }
}