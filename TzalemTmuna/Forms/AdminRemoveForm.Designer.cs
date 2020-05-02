
namespace TzalemTmuna.Forms
{
    partial class AdminRemoveForm
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
            this.txtText = new MetroFramework.Controls.MetroTextBox();
            this.lblReason = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.Location = new System.Drawing.Point(23, 253);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(334, 47);
            this.btnSubmit.TabIndex = 30;
            this.btnSubmit.Text = "Submit";
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
            this.txtText.Location = new System.Drawing.Point(23, 85);
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
            // lblReason
            // 
            this.lblReason.AutoSize = true;
            this.lblReason.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblReason.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblReason.ForeColor = System.Drawing.Color.White;
            this.lblReason.Location = new System.Drawing.Point(23, 60);
            this.lblReason.Name = "lblReason";
            this.lblReason.Size = new System.Drawing.Size(189, 19);
            this.lblReason.TabIndex = 32;
            this.lblReason.Text = "How was the issue dealt with:";
            this.lblReason.UseCustomBackColor = true;
            // 
            // AdminRemoveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 323);
            this.Controls.Add(this.lblReason);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtText);
            this.Icon = global::TzalemTmuna.Properties.Resources.tico;
            this.MaximizeBox = false;
            this.Name = "AdminRemoveForm";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Close Report";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroTextBox txtText;
        private MetroFramework.Controls.MetroLabel lblReason;
    }
}