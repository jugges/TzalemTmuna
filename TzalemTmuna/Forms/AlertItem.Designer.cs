namespace TzalemTmuna.Forms
{
    partial class AlertItem
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
            this.lblAlertText = new MetroFramework.Controls.MetroLabel();
            this.btnRemove = new MetroFramework.Controls.MetroLabel();
            this.pbIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlertText
            // 
            this.lblAlertText.AutoSize = true;
            this.lblAlertText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlertText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAlertText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAlertText.ForeColor = System.Drawing.Color.White;
            this.lblAlertText.Location = new System.Drawing.Point(57, 15);
            this.lblAlertText.Name = "lblAlertText";
            this.lblAlertText.Size = new System.Drawing.Size(106, 25);
            this.lblAlertText.TabIndex = 1;
            this.lblAlertText.Text = "Hello World";
            this.lblAlertText.UseCustomBackColor = true;
            this.lblAlertText.Click += new System.EventHandler(this.lblUsername_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.btnRemove.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.btnRemove.ForeColor = System.Drawing.Color.Red;
            this.btnRemove.Location = new System.Drawing.Point(249, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(52, 54);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.Text = "❎";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseCustomBackColor = true;
            this.btnRemove.UseCustomForeColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pbIcon
            // 
            this.pbIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbIcon.Image = global::TzalemTmuna.Properties.Resources.baseline_notifications_white_36dp;
            this.pbIcon.Location = new System.Drawing.Point(3, 3);
            this.pbIcon.Name = "pbIcon";
            this.pbIcon.Size = new System.Drawing.Size(48, 48);
            this.pbIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIcon.TabIndex = 37;
            this.pbIcon.TabStop = false;
            // 
            // AlertItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.pbIcon);
            this.Controls.Add(this.lblAlertText);
            this.Controls.Add(this.btnRemove);
            this.Name = "AlertItem";
            this.Size = new System.Drawing.Size(304, 54);
            this.Load += new System.EventHandler(this.AlertItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblAlertText;
        private MetroFramework.Controls.MetroLabel btnRemove;
        private System.Windows.Forms.PictureBox pbIcon;
    }
}
