
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.txtCommentText = new MetroFramework.Controls.MetroTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbOption = new System.Windows.Forms.PictureBox();
            this.pbComment = new System.Windows.Forms.PictureBox();
            this.pbLike = new System.Windows.Forms.PictureBox();
            this.lblLikes = new MetroFramework.Controls.MetroLabel();
            this.lblText = new MetroFramework.Controls.MetroLabel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.lblComments = new MetroFramework.Controls.MetroLabel();
            this.profilePicture = new TzalemTmuna.Forms.ProfilePicture();
            this.pbPhoto = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(640, 98);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 542);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnSubmit, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtCommentText, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 427);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(296, 102);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSubmit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSubmit.Location = new System.Drawing.Point(233, 3);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(50, 96);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtCommentText
            // 
            // 
            // 
            // 
            this.txtCommentText.CustomButton.Image = null;
            this.txtCommentText.CustomButton.Location = new System.Drawing.Point(120, 2);
            this.txtCommentText.CustomButton.Name = "";
            this.txtCommentText.CustomButton.Size = new System.Drawing.Size(91, 91);
            this.txtCommentText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCommentText.CustomButton.TabIndex = 1;
            this.txtCommentText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCommentText.CustomButton.UseSelectable = true;
            this.txtCommentText.CustomButton.Visible = false;
            this.txtCommentText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCommentText.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtCommentText.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtCommentText.Lines = new string[0];
            this.txtCommentText.Location = new System.Drawing.Point(13, 3);
            this.txtCommentText.MaxLength = 255;
            this.txtCommentText.Multiline = true;
            this.txtCommentText.Name = "txtCommentText";
            this.txtCommentText.PasswordChar = '\0';
            this.txtCommentText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCommentText.SelectedText = "";
            this.txtCommentText.SelectionLength = 0;
            this.txtCommentText.SelectionStart = 0;
            this.txtCommentText.ShortcutsEnabled = true;
            this.txtCommentText.Size = new System.Drawing.Size(214, 96);
            this.txtCommentText.TabIndex = 3;
            this.txtCommentText.UseSelectable = true;
            this.txtCommentText.UseStyleColors = true;
            this.txtCommentText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCommentText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 387);
            this.flowLayoutPanel1.TabIndex = 3;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.flowLayoutPanel1_MouseWheel);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.pbOption);
            this.flowLayoutPanel2.Controls.Add(this.pbComment);
            this.flowLayoutPanel2.Controls.Add(this.pbLike);
            this.flowLayoutPanel2.Controls.Add(this.lblLikes);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 393);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(296, 31);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // pbOption
            // 
            this.pbOption.BackColor = System.Drawing.Color.Transparent;
            this.pbOption.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbOption.Location = new System.Drawing.Point(13, 3);
            this.pbOption.Name = "pbOption";
            this.pbOption.Padding = new System.Windows.Forms.Padding(3);
            this.pbOption.Size = new System.Drawing.Size(24, 24);
            this.pbOption.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbOption.TabIndex = 39;
            this.pbOption.TabStop = false;
            // 
            // pbComment
            // 
            this.pbComment.BackColor = System.Drawing.Color.Transparent;
            this.pbComment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbComment.Location = new System.Drawing.Point(43, 3);
            this.pbComment.Name = "pbComment";
            this.pbComment.Padding = new System.Windows.Forms.Padding(3);
            this.pbComment.Size = new System.Drawing.Size(24, 24);
            this.pbComment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComment.TabIndex = 38;
            this.pbComment.TabStop = false;
            this.pbComment.Click += new System.EventHandler(this.pbComment_Click);
            // 
            // pbLike
            // 
            this.pbLike.BackColor = System.Drawing.Color.Transparent;
            this.pbLike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbLike.Location = new System.Drawing.Point(73, 3);
            this.pbLike.Name = "pbLike";
            this.pbLike.Padding = new System.Windows.Forms.Padding(3);
            this.pbLike.Size = new System.Drawing.Size(24, 24);
            this.pbLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLike.TabIndex = 37;
            this.pbLike.TabStop = false;
            this.pbLike.Click += new System.EventHandler(this.Like);
            // 
            // lblLikes
            // 
            this.lblLikes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLikes.AutoSize = true;
            this.lblLikes.BackColor = System.Drawing.Color.Transparent;
            this.lblLikes.Enabled = false;
            this.lblLikes.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLikes.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblLikes.Location = new System.Drawing.Point(103, 5);
            this.lblLikes.Name = "lblLikes";
            this.lblLikes.Size = new System.Drawing.Size(59, 19);
            this.lblLikes.TabIndex = 36;
            this.lblLikes.Text = "15 likes";
            this.lblLikes.UseCustomBackColor = true;
            this.lblLikes.UseCustomForeColor = true;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.BackColor = System.Drawing.Color.Transparent;
            this.lblText.Enabled = false;
            this.lblText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblText.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblText.Location = new System.Drawing.Point(716, 48);
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
            this.lblUsername.Location = new System.Drawing.Point(716, 25);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(71, 19);
            this.lblUsername.TabIndex = 29;
            this.lblUsername.Text = "Username";
            this.lblUsername.UseCustomBackColor = true;
            this.lblUsername.Click += new System.EventHandler(this.OpenProfile);
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.BackColor = System.Drawing.Color.Transparent;
            this.lblComments.Enabled = false;
            this.lblComments.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblComments.Location = new System.Drawing.Point(656, 82);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(86, 19);
            this.lblComments.TabIndex = 33;
            this.lblComments.Text = "15 comments";
            this.lblComments.UseCustomBackColor = true;
            this.lblComments.UseCustomForeColor = true;
            // 
            // profilePicture
            // 
            this.profilePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profilePicture.Image = global::TzalemTmuna.Properties.Resources.emptyprofilepicture;
            this.profilePicture.Location = new System.Drawing.Point(656, 25);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(48, 48);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 28;
            this.profilePicture.TabStop = false;
            this.profilePicture.Click += new System.EventHandler(this.OpenProfile);
            // 
            // pbPhoto
            // 
            this.pbPhoto.Location = new System.Drawing.Point(0, 0);
            this.pbPhoto.Name = "pbPhoto";
            this.pbPhoto.Size = new System.Drawing.Size(640, 640);
            this.pbPhoto.TabIndex = 27;
            this.pbPhoto.TabStop = false;
            this.pbPhoto.DoubleClick += new System.EventHandler(this.Like);
            // 
            // ViewPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 640);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.lblComments);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pbPhoto);
            this.MaximizeBox = false;
            this.Name = "ViewPost";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 0, 0);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ViewPost_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOption)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbPhoto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ProfilePicture profilePicture;
        private MetroFramework.Controls.MetroLabel lblText;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroTextBox txtCommentText;
        private MetroFramework.Controls.MetroLabel lblComments;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.PictureBox pbOption;
        private System.Windows.Forms.PictureBox pbComment;
        private System.Windows.Forms.PictureBox pbLike;
        private MetroFramework.Controls.MetroLabel lblLikes;
    }
}