
namespace TzalemTmuna.Forms
{
    partial class ViewReport
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
            this.lblText = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.txtText = new MetroFramework.Controls.MetroTextBox();
            this.SuspendLayout();
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Enabled = false;
            this.lblText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblText.Location = new System.Drawing.Point(23, 82);
            this.lblText.Margin = new System.Windows.Forms.Padding(3);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(40, 25);
            this.lblText.TabIndex = 26;
            this.lblText.Text = "Text";
            this.lblText.UseCustomBackColor = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(23, 60);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username";
            this.lblUsername.UseCustomBackColor = true;
            this.lblUsername.Click += new System.EventHandler(this.OpenProfile);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.Location = new System.Drawing.Point(23, 253);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(334, 47);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.UseSelectable = true;
            // 
            // txtText
            // 
            // 
            // 
            // 
            this.txtText.CustomButton.Image = null;
            this.txtText.CustomButton.Location = new System.Drawing.Point(174, 2);
            this.txtText.CustomButton.Name = "";
            this.txtText.CustomButton.Size = new System.Drawing.Size(157, 157);
            this.txtText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtText.CustomButton.TabIndex = 1;
            this.txtText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtText.CustomButton.UseSelectable = true;
            this.txtText.CustomButton.Visible = false;
            this.txtText.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtText.Lines = new string[0];
            this.txtText.Location = new System.Drawing.Point(23, 82);
            this.txtText.MaxLength = 32767;
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '\0';
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtText.SelectedText = "";
            this.txtText.SelectionLength = 0;
            this.txtText.SelectionStart = 0;
            this.txtText.ShortcutsEnabled = true;
            this.txtText.Size = new System.Drawing.Size(334, 162);
            this.txtText.TabIndex = 31;
            this.txtText.UseSelectable = true;
            this.txtText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 323);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtText);
            this.MaximizeBox = false;
            this.Name = "ViewReport";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblText;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroTextBox txtText;
    }
}