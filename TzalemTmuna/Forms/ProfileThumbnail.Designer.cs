namespace TzalemTmuna.Forms
{
    partial class ProfileThumbnail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileThumbnail));
            this.pbComment = new System.Windows.Forms.PictureBox();
            this.pbLike = new System.Windows.Forms.PictureBox();
            this.pb = new System.Windows.Forms.PictureBox();
            this.lblLikes = new MetroFramework.Controls.MetroLabel();
            this.lblComments = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb)).BeginInit();
            this.SuspendLayout();
            // 
            // pbComment
            // 
            this.pbComment.BackColor = System.Drawing.Color.Transparent;
            this.pbComment.Image = ((System.Drawing.Image)(resources.GetObject("pbComment.Image")));
            this.pbComment.Location = new System.Drawing.Point(124, 107);
            this.pbComment.Name = "pbComment";
            this.pbComment.Size = new System.Drawing.Size(24, 24);
            this.pbComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComment.TabIndex = 2;
            this.pbComment.TabStop = false;
            this.pbComment.Visible = false;
            // 
            // pbLike
            // 
            this.pbLike.BackColor = System.Drawing.Color.Transparent;
            this.pbLike.Image = global::TzalemTmuna.Properties.Resources.darkLike;
            this.pbLike.Location = new System.Drawing.Point(59, 107);
            this.pbLike.Name = "pbLike";
            this.pbLike.Size = new System.Drawing.Size(24, 24);
            this.pbLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
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
            // lblLikes
            // 
            this.lblLikes.AutoSize = true;
            this.lblLikes.BackColor = System.Drawing.Color.Transparent;
            this.lblLikes.Enabled = false;
            this.lblLikes.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLikes.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLikes.ForeColor = System.Drawing.Color.White;
            this.lblLikes.Location = new System.Drawing.Point(89, 106);
            this.lblLikes.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(32, 25);
            this.lblLikes.TabIndex = 26;
            this.lblLikes.Text = "15";
            this.lblLikes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLikes.UseCustomBackColor = true;
            this.lblLikes.UseCustomForeColor = true;
            this.lblLikes.Visible = false;
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.BackColor = System.Drawing.Color.Transparent;
            this.lblComments.Enabled = false;
            this.lblComments.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblComments.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblComments.ForeColor = System.Drawing.Color.White;
            this.lblComments.Location = new System.Drawing.Point(154, 107);
            this.lblComments.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(32, 25);
            this.lblComments.TabIndex = 27;
            this.lblComments.Text = "15";
            this.lblComments.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblComments.UseCustomBackColor = true;
            this.lblComments.UseCustomForeColor = true;
            this.lblComments.Visible = false;
            // 
            // ProfileThumbnail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblLikes);
            this.Controls.Add(this.pbComment);
            this.Controls.Add(this.pbLike);
            this.Controls.Add(this.pb);
            this.Name = "ProfileThumbnail";
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
        private MetroFramework.Controls.MetroLabel lblLikes;
        private MetroFramework.Controls.MetroLabel lblComments;
    }
}
