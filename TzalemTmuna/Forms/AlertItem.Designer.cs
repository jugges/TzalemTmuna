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
            this.pbMain = new TzalemTmuna.Forms.ProfilePicture();
            this.pbSecond = new TzalemTmuna.Forms.ProfilePicture();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAlertText
            // 
            this.lblAlertText.AutoSize = true;
            this.lblAlertText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAlertText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAlertText.ForeColor = System.Drawing.Color.White;
            this.lblAlertText.Location = new System.Drawing.Point(50, 14);
            this.lblAlertText.Name = "lblAlertText";
            this.lblAlertText.Size = new System.Drawing.Size(80, 19);
            this.lblAlertText.TabIndex = 1;
            this.lblAlertText.Text = "Hello World";
            this.lblAlertText.UseCustomBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRemove.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.btnRemove.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnRemove.Location = new System.Drawing.Point(259, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(38, 51);
            this.btnRemove.TabIndex = 36;
            this.btnRemove.Text = "❎";
            this.btnRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRemove.UseCustomBackColor = true;
            this.btnRemove.UseCustomForeColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // pbMain
            // 
            this.pbMain.Image = global::TzalemTmuna.Properties.Resources.emptyprofilepicture;
            this.pbMain.Location = new System.Drawing.Point(3, 3);
            this.pbMain.Name = "pbMain";
            this.pbMain.Size = new System.Drawing.Size(30, 30);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 38;
            this.pbMain.TabStop = false;
            // 
            // pbSecond
            // 
            this.pbSecond.Image = global::TzalemTmuna.Properties.Resources.emptyprofilepicture;
            this.pbSecond.Location = new System.Drawing.Point(14, 14);
            this.pbSecond.Name = "pbSecond";
            this.pbSecond.Size = new System.Drawing.Size(30, 30);
            this.pbSecond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbSecond.TabIndex = 39;
            this.pbSecond.TabStop = false;
            // 
            // AlertItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pbSecond);
            this.Controls.Add(this.pbMain);
            this.Controls.Add(this.lblAlertText);
            this.Controls.Add(this.btnRemove);
            this.MinimumSize = new System.Drawing.Size(297, 48);
            this.Name = "AlertItem";
            this.Size = new System.Drawing.Size(297, 51);
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSecond)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lblAlertText;
        private MetroFramework.Controls.MetroLabel btnRemove;
        private ProfilePicture pbMain;
        private ProfilePicture pbSecond;
    }
}
