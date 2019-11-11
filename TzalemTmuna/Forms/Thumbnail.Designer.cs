namespace TzalemTmuna.Forms
{
    partial class Thumbnail
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
            this.pbComment = new System.Windows.Forms.PictureBox();
            this.pbLike = new System.Windows.Forms.PictureBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.lblLike = new MetroFramework.Controls.MetroLabel();
            this.lblComment = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComment
            // 
            this.pbComment.BackColor = System.Drawing.Color.Transparent;
            this.pbComment.Image = global::TzalemTmuna.Properties.Resources.chat;
            this.pbComment.Location = new System.Drawing.Point(124, 107);
            this.pbComment.Name = "pbComment";
            this.pbComment.Size = new System.Drawing.Size(24, 24);
            this.pbComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbComment.TabIndex = 2;
            this.pbComment.TabStop = false;
            this.pbComment.Visible = false;
            // 
            // pbLike
            // 
            this.pbLike.BackColor = System.Drawing.Color.Transparent;
            this.pbLike.Image = global::TzalemTmuna.Properties.Resources.likewhite;
            this.pbLike.Location = new System.Drawing.Point(59, 107);
            this.pbLike.Name = "pbLike";
            this.pbLike.Size = new System.Drawing.Size(24, 24);
            this.pbLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLike.TabIndex = 1;
            this.pbLike.TabStop = false;
            this.pbLike.Visible = false;
            // 
            // pb
            // 
            this.pb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pb.Location = new System.Drawing.Point(0, 0);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(250, 250);
            this.pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb.TabIndex = 0;
            this.pb.TabStop = false;
            this.pb.Click += new System.EventHandler(this.pb_Click);
            this.pb.MouseEnter += new System.EventHandler(this.pb_MouseEnter);
            this.pb.MouseLeave += new System.EventHandler(this.pb_MouseLeave);
            // 
            // lblLike
            // 
            this.lblLike.AutoSize = true;
            this.lblLike.BackColor = System.Drawing.Color.Transparent;
            this.lblLike.Enabled = false;
            this.lblLike.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLike.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLike.ForeColor = System.Drawing.Color.White;
            this.lblLike.Location = new System.Drawing.Point(89, 106);
            this.lblLike.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblLike.Name = "lblLike";
            this.lblLike.Size = new System.Drawing.Size(32, 25);
            this.lblLike.TabIndex = 26;
            this.lblLike.Text = "15";
            this.lblLike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLike.UseCustomBackColor = true;
            this.lblLike.UseCustomForeColor = true;
            this.lblLike.Visible = false;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.BackColor = System.Drawing.Color.Transparent;
            this.lblComment.Enabled = false;
            this.lblComment.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblComment.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblComment.ForeColor = System.Drawing.Color.White;
            this.lblComment.Location = new System.Drawing.Point(154, 107);
            this.lblComment.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblComment.Name = "lblComment";
            this.lblComment.Size = new System.Drawing.Size(32, 25);
            this.lblComment.TabIndex = 27;
            this.lblComment.Text = "15";
            this.lblComment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblComment.UseCustomBackColor = true;
            this.lblComment.UseCustomForeColor = true;
            this.lblComment.Visible = false;
            // 
            // Thumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblComment);
            this.Controls.Add(this.lblLike);
            this.Controls.Add(this.pbComment);
            this.Controls.Add(this.pbLike);
            this.Controls.Add(this.pb);
            this.Name = "Thumbnail";
            this.Size = new System.Drawing.Size(250, 250);
            ((System.ComponentModel.ISupportInitialize)(this.pbComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb;
        private System.Windows.Forms.PictureBox pbLike;
        private System.Windows.Forms.PictureBox pbComment;
        private MetroFramework.Controls.MetroLabel lblLike;
        private MetroFramework.Controls.MetroLabel lblComment;
    }
}
