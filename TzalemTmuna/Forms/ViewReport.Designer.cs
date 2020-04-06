
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
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.btnAction = new MetroFramework.Controls.MetroButton();
            this.txtText = new MetroFramework.Controls.MetroTextBox();
            this.lblClosingDate = new MetroFramework.Controls.MetroLabel();
            this.lblOpeningDate = new MetroFramework.Controls.MetroLabel();
            this.lblOpened = new MetroFramework.Controls.MetroLabel();
            this.lblClosed = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(23, 49);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username";
            this.lblUsername.UseCustomBackColor = true;
            this.lblUsername.Click += new System.EventHandler(this.OpenProfile);
            // 
            // btnAction
            // 
            this.btnAction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAction.Location = new System.Drawing.Point(23, 253);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(334, 47);
            this.btnAction.TabIndex = 30;
            this.btnAction.Text = "Close";
            this.btnAction.UseSelectable = true;
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
            this.txtText.Location = new System.Drawing.Point(23, 85);
            this.txtText.MaxLength = 32767;
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '\0';
            this.txtText.ReadOnly = true;
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
            // lblClosingDate
            // 
            this.lblClosingDate.AutoSize = true;
            this.lblClosingDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblClosingDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblClosingDate.ForeColor = System.Drawing.Color.White;
            this.lblClosingDate.Location = new System.Drawing.Point(82, 30);
            this.lblClosingDate.Name = "lblClosingDate";
            this.lblClosingDate.Size = new System.Drawing.Size(141, 19);
            this.lblClosingDate.TabIndex = 32;
            this.lblClosingDate.Text = "01/05/2020 16:23:50";
            this.lblClosingDate.UseCustomBackColor = true;
            // 
            // lblOpeningDate
            // 
            this.lblOpeningDate.AutoSize = true;
            this.lblOpeningDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOpeningDate.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblOpeningDate.ForeColor = System.Drawing.Color.White;
            this.lblOpeningDate.Location = new System.Drawing.Point(82, 11);
            this.lblOpeningDate.Name = "lblOpeningDate";
            this.lblOpeningDate.Size = new System.Drawing.Size(141, 19);
            this.lblOpeningDate.TabIndex = 33;
            this.lblOpeningDate.Text = "01/05/2020 16:23:50";
            this.lblOpeningDate.UseCustomBackColor = true;
            // 
            // lblOpened
            // 
            this.lblOpened.AutoSize = true;
            this.lblOpened.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblOpened.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblOpened.ForeColor = System.Drawing.Color.White;
            this.lblOpened.Location = new System.Drawing.Point(23, 11);
            this.lblOpened.Name = "lblOpened";
            this.lblOpened.Size = new System.Drawing.Size(61, 19);
            this.lblOpened.TabIndex = 34;
            this.lblOpened.Text = "Opened:";
            this.lblOpened.UseCustomBackColor = true;
            // 
            // lblClosed
            // 
            this.lblClosed.AutoSize = true;
            this.lblClosed.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblClosed.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblClosed.ForeColor = System.Drawing.Color.White;
            this.lblClosed.Location = new System.Drawing.Point(23, 30);
            this.lblClosed.Name = "lblClosed";
            this.lblClosed.Size = new System.Drawing.Size(53, 19);
            this.lblClosed.TabIndex = 35;
            this.lblClosed.Text = "Closed:";
            this.lblClosed.UseCustomBackColor = true;
            // 
            // ViewReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 323);
            this.Controls.Add(this.lblClosed);
            this.Controls.Add(this.lblOpened);
            this.Controls.Add(this.lblOpeningDate);
            this.Controls.Add(this.lblClosingDate);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtText);
            this.DisplayHeader = false;
            this.Icon = global::TzalemTmuna.Properties.Resources.tico;
            this.MaximizeBox = false;
            this.Name = "ViewReport";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "View Report";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroButton btnAction;
        private MetroFramework.Controls.MetroTextBox txtText;
        private MetroFramework.Controls.MetroLabel lblClosingDate;
        private MetroFramework.Controls.MetroLabel lblOpeningDate;
        private MetroFramework.Controls.MetroLabel lblOpened;
        private MetroFramework.Controls.MetroLabel lblClosed;
    }
}