
namespace TzalemTmuna.Forms
{
    partial class NewPost
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
            this.lblText = new MetroFramework.Controls.MetroLabel();
            this.lblSelectPhoto = new MetroFramework.Controls.MetroLabel();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.tCrop = new MetroFramework.Controls.MetroToggle();
            this.lblCrop = new MetroFramework.Controls.MetroLabel();
            this.txtText = new MetroFramework.Controls.MetroTextBox();
            this.tbCropX = new MetroFramework.Controls.MetroTrackBar();
            this.tbCropY = new MetroFramework.Controls.MetroTrackBar();
            this.tbCropZ = new MetroFramework.Controls.MetroTrackBar();
            this.tbPosY = new MetroFramework.Controls.MetroTrackBar();
            this.tbPosX = new MetroFramework.Controls.MetroTrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.Location = new System.Drawing.Point(108, 465);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(320, 47);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Save";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Enabled = false;
            this.lblText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblText.Location = new System.Drawing.Point(62, 424);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(40, 25);
            this.lblText.TabIndex = 26;
            this.lblText.Text = "Text";
            this.lblText.UseCustomBackColor = true;
            // 
            // lblSelectPhoto
            // 
            this.lblSelectPhoto.AutoSize = true;
            this.lblSelectPhoto.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectPhoto.Enabled = false;
            this.lblSelectPhoto.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblSelectPhoto.Location = new System.Drawing.Point(227, 237);
            this.lblSelectPhoto.Name = "lblSelectPhoto";
            this.lblSelectPhoto.Size = new System.Drawing.Size(82, 19);
            this.lblSelectPhoto.TabIndex = 18;
            this.lblSelectPhoto.Text = "Select Photo";
            this.lblSelectPhoto.UseCustomBackColor = true;
            this.lblSelectPhoto.UseCustomForeColor = true;
            this.lblSelectPhoto.Visible = false;
            // 
            // pbPhoto
            // 
            this.pbPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPhoto.Location = new System.Drawing.Point(108, 86);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(320, 320);
            this.pbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPhoto.TabIndex = 27;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.Click += new System.EventHandler(this.pbPhoto_Click);
            this.pbPhoto.MouseEnter += new System.EventHandler(this.pbPhoto_MouseEnter);
            this.pbPhoto.MouseLeave += new System.EventHandler(this.pbPhoto_MouseLeave);
            // 
            // tCrop
            // 
            this.tCrop.AutoSize = true;
            this.tCrop.Checked = true;
            this.tCrop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tCrop.Location = new System.Drawing.Point(108, 62);
            this.tCrop.Name = "tCrop";
            this.tCrop.Size = new System.Drawing.Size(80, 17);
            this.tCrop.TabIndex = 28;
            this.tCrop.Text = "On";
            this.tCrop.UseSelectable = true;
            this.tCrop.CheckedChanged += new System.EventHandler(this.cropToggle_CheckedChanged);
            // 
            // lblCrop
            // 
            this.lblCrop.AutoSize = true;
            this.lblCrop.BackColor = System.Drawing.Color.Transparent;
            this.lblCrop.Enabled = false;
            this.lblCrop.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCrop.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblCrop.Location = new System.Drawing.Point(53, 55);
            this.lblCrop.Name = "lblCrop";
            this.lblCrop.Size = new System.Drawing.Size(49, 25);
            this.lblCrop.TabIndex = 30;
            this.lblCrop.Text = "Crop";
            this.lblCrop.UseCustomBackColor = true;
            // 
            // txtText
            // 
            // 
            // 
            // 
            this.txtText.CustomButton.Image = null;
            this.txtText.CustomButton.Location = new System.Drawing.Point(274, 1);
            this.txtText.CustomButton.Name = "";
            this.txtText.CustomButton.Size = new System.Drawing.Size(45, 45);
            this.txtText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtText.CustomButton.TabIndex = 1;
            this.txtText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtText.CustomButton.UseSelectable = true;
            this.txtText.CustomButton.Visible = false;
            this.txtText.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtText.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtText.Lines = new string[0];
            this.txtText.Location = new System.Drawing.Point(108, 412);
            this.txtText.MaxLength = 0;
            this.txtText.Name = "txtText";
            this.txtText.PasswordChar = '\0';
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtText.SelectedText = "";
            this.txtText.SelectionLength = 0;
            this.txtText.SelectionStart = 0;
            this.txtText.ShortcutsEnabled = true;
            this.txtText.Size = new System.Drawing.Size(320, 47);
            this.txtText.TabIndex = 29;
            this.txtText.UseSelectable = true;
            this.txtText.UseStyleColors = true;
            this.txtText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbCropX
            // 
            this.tbCropX.BackColor = System.Drawing.Color.Transparent;
            this.tbCropX.Location = new System.Drawing.Point(191, 59);
            this.tbCropX.Name = "tbCropX";
            this.tbCropX.Size = new System.Drawing.Size(75, 23);
            this.tbCropX.TabIndex = 31;
            this.tbCropX.Text = "metroTrackBar1";
            this.tbCropX.Value = 0;
            this.tbCropX.ValueChanged += new System.EventHandler(this.tbCropX_ValueChanged);
            // 
            // tbCropY
            // 
            this.tbCropY.BackColor = System.Drawing.Color.Transparent;
            this.tbCropY.Location = new System.Drawing.Point(272, 59);
            this.tbCropY.Name = "tbCropY";
            this.tbCropY.Size = new System.Drawing.Size(75, 23);
            this.tbCropY.TabIndex = 32;
            this.tbCropY.Text = "metroTrackBar2";
            this.tbCropY.Value = 0;
            this.tbCropY.ValueChanged += new System.EventHandler(this.tbCropY_ValueChanged);
            // 
            // tbCropZ
            // 
            this.tbCropZ.BackColor = System.Drawing.Color.Transparent;
            this.tbCropZ.Location = new System.Drawing.Point(353, 59);
            this.tbCropZ.Minimum = 10;
            this.tbCropZ.Name = "tbCropZ";
            this.tbCropZ.Size = new System.Drawing.Size(75, 23);
            this.tbCropZ.TabIndex = 33;
            this.tbCropZ.Text = "metroTrackBar2";
            this.tbCropZ.Value = 100;
            this.tbCropZ.ValueChanged += new System.EventHandler(this.tbCropZ_ValueChanged);
            // 
            // tbPosY
            // 
            this.tbPosY.BackColor = System.Drawing.Color.Transparent;
            this.tbPosY.Location = new System.Drawing.Point(272, 30);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(75, 23);
            this.tbPosY.TabIndex = 34;
            this.tbPosY.Text = "metroTrackBar2";
            this.tbPosY.Value = 0;
            this.tbPosY.ValueChanged += new System.EventHandler(this.tbCropY2_ValueChanged);
            // 
            // tbPosX
            // 
            this.tbPosX.BackColor = System.Drawing.Color.Transparent;
            this.tbPosX.Location = new System.Drawing.Point(191, 30);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(75, 23);
            this.tbPosX.TabIndex = 35;
            this.tbPosX.Text = "metroTrackBar2";
            this.tbPosX.Value = 0;
            this.tbPosX.ValueChanged += new System.EventHandler(this.tbCropX2_ValueChanged);
            // 
            // NewPost
            // 
            this.Icon = Properties.Resources.tico;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 522);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.tbCropZ);
            this.Controls.Add(this.tbCropY);
            this.Controls.Add(this.tbCropX);
            this.Controls.Add(this.lblCrop);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.tCrop);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSelectPhoto);
            this.Controls.Add(this.pbPhoto);
            this.MaximizeBox = false;
            this.Name = "NewPost";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "New Post";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroLabel lblText;
        private MetroFramework.Controls.MetroLabel lblSelectPhoto;
        private System.Windows.Forms.PictureBox pbPhoto;
        private MetroFramework.Controls.MetroToggle tCrop;
        private MetroFramework.Controls.MetroLabel lblCrop;
        private MetroFramework.Controls.MetroTextBox txtText;
        private MetroFramework.Controls.MetroTrackBar tbCropX;
        private MetroFramework.Controls.MetroTrackBar tbCropY;
        private MetroFramework.Controls.MetroTrackBar tbCropZ;
        private MetroFramework.Controls.MetroTrackBar tbPosY;
        private MetroFramework.Controls.MetroTrackBar tbPosX;
    }
}