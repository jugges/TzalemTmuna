
namespace TzalemTmuna.Forms
{
    partial class ChangePassword
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
            this.txtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.btnChangePassword = new MetroFramework.Controls.MetroButton();
            this.txtPasswordValidate = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
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
            this.txtNewPassword.Location = new System.Drawing.Point(12, 63);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.Size = new System.Drawing.Size(332, 47);
            this.txtNewPassword.TabIndex = 0;
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
            this.btnChangePassword.Location = new System.Drawing.Point(12, 169);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(332, 47);
            this.btnChangePassword.TabIndex = 2;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
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
            this.txtPasswordValidate.Location = new System.Drawing.Point(12, 116);
            this.txtPasswordValidate.MaxLength = 32767;
            this.txtPasswordValidate.Name = "txtPasswordValidate";
            this.txtPasswordValidate.PasswordChar = '●';
            this.txtPasswordValidate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPasswordValidate.SelectedText = "";
            this.txtPasswordValidate.SelectionLength = 0;
            this.txtPasswordValidate.SelectionStart = 0;
            this.txtPasswordValidate.ShortcutsEnabled = true;
            this.txtPasswordValidate.Size = new System.Drawing.Size(332, 47);
            this.txtPasswordValidate.TabIndex = 1;
            this.txtPasswordValidate.UseSelectable = true;
            this.txtPasswordValidate.UseStyleColors = true;
            this.txtPasswordValidate.UseSystemPasswordChar = true;
            this.txtPasswordValidate.WaterMark = "Type Password again";
            this.txtPasswordValidate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPasswordValidate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ChangePassword
            // 
            this.Icon = Properties.Resources.tico;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 224);
            this.Controls.Add(this.txtPasswordValidate);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.txtNewPassword);
            this.MaximizeBox = false;
            this.Name = "ChangePassword";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Change Password";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox txtNewPassword;
        private MetroFramework.Controls.MetroButton btnChangePassword;
        private MetroFramework.Controls.MetroTextBox txtPasswordValidate;
    }
}