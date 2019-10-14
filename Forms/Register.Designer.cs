
namespace TzalemTmuna.Forms
{
    partial class Register
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
            this.txtUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.chkRememberMe = new MetroFramework.Controls.MetroCheckBox();
            this.txtPasswordValidate = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
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
            this.txtUsername.Location = new System.Drawing.Point(12, 63);
            this.txtUsername.MaxLength = 12;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PromptText = "Username, can only contain english letters and underscores";
            this.txtUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Size = new System.Drawing.Size(332, 47);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.UseSelectable = true;
            this.txtUsername.UseStyleColors = true;
            this.txtUsername.WaterMark = "Username, can only contain english letters and underscores";
            this.txtUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPassword
            // 
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPassword.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(12, 169);
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PromptText = "Password, minimum length must be 5 characters";
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(332, 47);
            this.txtPassword.TabIndex = 10;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.UseStyleColors = true;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.WaterMark = "Password, minimum length must be 5 characters";
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtEmail.Location = new System.Drawing.Point(12, 116);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PromptText = "Email Address";
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(332, 47);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.UseSelectable = true;
            this.txtEmail.UseStyleColors = true;
            this.txtEmail.WaterMark = "Email Address";
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.Location = new System.Drawing.Point(12, 275);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(332, 47);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Create Account";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // chkRememberMe
            // 
            this.chkRememberMe.AutoSize = true;
            this.chkRememberMe.Checked = true;
            this.chkRememberMe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRememberMe.Location = new System.Drawing.Point(12, 328);
            this.chkRememberMe.Name = "chkRememberMe";
            this.chkRememberMe.Size = new System.Drawing.Size(101, 15);
            this.chkRememberMe.TabIndex = 13;
            this.chkRememberMe.Text = "Remember Me";
            this.chkRememberMe.UseCustomBackColor = true;
            this.chkRememberMe.UseSelectable = true;
            this.chkRememberMe.UseStyleColors = true;
            // 
            // txtPasswordValidate
            // 
            // 
            // 
            // 
            this.txtPasswordValidate.CustomButton.Image = null;
            this.txtPasswordValidate.CustomButton.Location = new System.Drawing.Point(286, 1);
            this.txtPasswordValidate.CustomButton.Name = "";
            this.txtPasswordValidate.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtPasswordValidate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPasswordValidate.CustomButton.TabIndex = 1;
            this.txtPasswordValidate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPasswordValidate.CustomButton.UseSelectable = true;
            this.txtPasswordValidate.CustomButton.Visible = false;
            this.txtPasswordValidate.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtPasswordValidate.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtPasswordValidate.Lines = new string[0];
            this.txtPasswordValidate.Location = new System.Drawing.Point(12, 222);
            this.txtPasswordValidate.MaxLength = 32767;
            this.txtPasswordValidate.Name = "txtPasswordValidate";
            this.txtPasswordValidate.PasswordChar = '●';
            this.txtPasswordValidate.PromptText = "Type Password again";
            this.txtPasswordValidate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordValidate.SelectedText = "";
            this.txtPasswordValidate.SelectionLength = 0;
            this.txtPasswordValidate.SelectionStart = 0;
            this.txtPasswordValidate.ShortcutsEnabled = true;
            this.txtPasswordValidate.Size = new System.Drawing.Size(332, 47);
            this.txtPasswordValidate.TabIndex = 11;
            this.txtPasswordValidate.UseSelectable = true;
            this.txtPasswordValidate.UseStyleColors = true;
            this.txtPasswordValidate.UseSystemPasswordChar = true;
            this.txtPasswordValidate.WaterMark = "Type Password again";
            this.txtPasswordValidate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordValidate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Register
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 354);
            this.Controls.Add(this.txtPasswordValidate);
            this.Controls.Add(this.chkRememberMe);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtUsername);
            this.MaximizeBox = false;
            this.Name = "Register";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Register";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtUsername;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroCheckBox chkRememberMe;
        private MetroFramework.Controls.MetroTextBox txtPasswordValidate;
    }
}