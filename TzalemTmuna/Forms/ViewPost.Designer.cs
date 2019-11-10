
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
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(320, 320);
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
            this.lblText.Location = new System.Drawing.Point(326, 60);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(40, 25);
            this.lblText.TabIndex = 26;
            this.lblText.Text = "Text";
            this.lblText.UseCustomBackColor = true;
            // 
            // ViewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 320);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPhoto;
        private MetroFramework.Controls.MetroLabel lblText;
    }
}