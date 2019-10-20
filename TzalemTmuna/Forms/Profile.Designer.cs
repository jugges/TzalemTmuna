
namespace TzalemTmuna.Forms
{
    partial class Profile
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
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblBio = new MetroFramework.Controls.MetroLabel();
            this.lblWebsite = new MetroFramework.Controls.MetroLink();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPosts = new MetroFramework.Controls.MetroLabel();
            this.lblTextPosts = new MetroFramework.Controls.MetroLabel();
            this.lblFollowers = new MetroFramework.Controls.MetroLink();
            this.lblTextFollowers = new MetroFramework.Controls.MetroLink();
            this.lblFollowing = new MetroFramework.Controls.MetroLink();
            this.lblFollowingText = new MetroFramework.Controls.MetroLink();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblUsername = new MetroFramework.Controls.MetroLabel();
            this.btnOption = new MetroFramework.Controls.MetroButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.ProfilePicture = new TzalemTmuna.Forms.ProfilePicture();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(265, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(486, 254);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.lblName);
            this.flowLayoutPanel3.Controls.Add(this.lblBio);
            this.flowLayoutPanel3.Controls.Add(this.lblWebsite);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 103);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(480, 148);
            this.flowLayoutPanel3.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Enabled = false;
            this.lblName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblName.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblName.Location = new System.Drawing.Point(3, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 25);
            this.lblName.TabIndex = 25;
            this.lblName.Text = "Name";
            this.lblName.UseCustomBackColor = true;
            // 
            // lblBio
            // 
            this.lblBio.AutoSize = true;
            this.lblBio.BackColor = System.Drawing.Color.Transparent;
            this.lblBio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBio.Enabled = false;
            this.lblBio.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblBio.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblBio.Location = new System.Drawing.Point(3, 25);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(62, 19);
            this.lblBio.TabIndex = 26;
            this.lblBio.Text = "Bio";
            this.lblBio.UseCustomBackColor = true;
            // 
            // lblWebsite
            // 
            this.lblWebsite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblWebsite.Location = new System.Drawing.Point(3, 47);
            this.lblWebsite.Name = "lblWebsite";
            this.lblWebsite.Size = new System.Drawing.Size(62, 42);
            this.lblWebsite.TabIndex = 27;
            this.lblWebsite.Text = "Website";
            this.lblWebsite.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblWebsite.UseCustomBackColor = true;
            this.lblWebsite.UseSelectable = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.lblPosts);
            this.flowLayoutPanel2.Controls.Add(this.lblTextPosts);
            this.flowLayoutPanel2.Controls.Add(this.lblFollowers);
            this.flowLayoutPanel2.Controls.Add(this.lblTextFollowers);
            this.flowLayoutPanel2.Controls.Add(this.lblFollowing);
            this.flowLayoutPanel2.Controls.Add(this.lblFollowingText);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 53);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(480, 44);
            this.flowLayoutPanel2.TabIndex = 17;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // lblPosts
            // 
            this.lblPosts.AutoSize = true;
            this.lblPosts.BackColor = System.Drawing.Color.Transparent;
            this.lblPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPosts.Enabled = false;
            this.lblPosts.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPosts.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblPosts.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblPosts.Location = new System.Drawing.Point(3, 0);
            this.lblPosts.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.lblPosts.Name = "lblPosts";
            this.lblPosts.Size = new System.Drawing.Size(57, 43);
            this.lblPosts.TabIndex = 25;
            this.lblPosts.Text = "1,141";
            this.lblPosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPosts.UseCustomBackColor = true;
            // 
            // lblTextPosts
            // 
            this.lblTextPosts.AutoSize = true;
            this.lblTextPosts.BackColor = System.Drawing.Color.Transparent;
            this.lblTextPosts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextPosts.Enabled = false;
            this.lblTextPosts.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTextPosts.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblTextPosts.Location = new System.Drawing.Point(60, 0);
            this.lblTextPosts.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.lblTextPosts.Name = "lblTextPosts";
            this.lblTextPosts.Size = new System.Drawing.Size(51, 43);
            this.lblTextPosts.TabIndex = 26;
            this.lblTextPosts.Text = "posts";
            this.lblTextPosts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTextPosts.UseCustomBackColor = true;
            // 
            // lblFollowers
            // 
            this.lblFollowers.AutoSize = true;
            this.lblFollowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblFollowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFollowers.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblFollowers.Location = new System.Drawing.Point(144, 3);
            this.lblFollowers.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblFollowers.Name = "lblFollowers";
            this.lblFollowers.Size = new System.Drawing.Size(23, 37);
            this.lblFollowers.TabIndex = 31;
            this.lblFollowers.Text = "1";
            this.lblFollowers.UseCustomBackColor = true;
            this.lblFollowers.UseSelectable = true;
            this.lblFollowers.Click += new System.EventHandler(this.lblFollowers_Click);
            // 
            // lblTextFollowers
            // 
            this.lblTextFollowers.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblTextFollowers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTextFollowers.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblTextFollowers.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.lblTextFollowers.Location = new System.Drawing.Point(167, 3);
            this.lblTextFollowers.Margin = new System.Windows.Forms.Padding(0, 3, 30, 3);
            this.lblTextFollowers.Name = "lblTextFollowers";
            this.lblTextFollowers.Size = new System.Drawing.Size(79, 37);
            this.lblTextFollowers.TabIndex = 17;
            this.lblTextFollowers.Text = "followers";
            this.lblTextFollowers.UseCustomBackColor = true;
            this.lblTextFollowers.UseSelectable = true;
            this.lblTextFollowers.Click += new System.EventHandler(this.lblTextFollowers_Click);
            // 
            // lblFollowing
            // 
            this.lblFollowing.AutoSize = true;
            this.lblFollowing.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblFollowing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFollowing.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblFollowing.Location = new System.Drawing.Point(279, 3);
            this.lblFollowing.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lblFollowing.Name = "lblFollowing";
            this.lblFollowing.Size = new System.Drawing.Size(23, 37);
            this.lblFollowing.TabIndex = 33;
            this.lblFollowing.Text = "1";
            this.lblFollowing.UseCustomBackColor = true;
            this.lblFollowing.UseSelectable = true;
            this.lblFollowing.Click += new System.EventHandler(this.lblFollowing_Click);
            // 
            // lblFollowingText
            // 
            this.lblFollowingText.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.lblFollowingText.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lblFollowingText.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.lblFollowingText.Location = new System.Drawing.Point(302, 3);
            this.lblFollowingText.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.lblFollowingText.Name = "lblFollowingText";
            this.lblFollowingText.Size = new System.Drawing.Size(81, 37);
            this.lblFollowingText.TabIndex = 32;
            this.lblFollowingText.Text = "following";
            this.lblFollowingText.UseCustomBackColor = true;
            this.lblFollowingText.UseSelectable = true;
            this.lblFollowingText.Click += new System.EventHandler(this.lblFollowingText_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.lblUsername);
            this.flowLayoutPanel1.Controls.Add(this.btnOption);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(480, 44);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Enabled = false;
            this.lblUsername.FontSize = MetroFramework.MetroLabelSize.Extreme;
            this.lblUsername.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(125, 36);
            this.lblUsername.TabIndex = 24;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsername.UseCustomBackColor = true;
            // 
            // btnOption
            // 
            this.btnOption.AutoSize = true;
            this.btnOption.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOption.Location = new System.Drawing.Point(134, 3);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(160, 30);
            this.btnOption.TabIndex = 25;
            this.btnOption.TabStop = false;
            this.btnOption.Text = "metroButton1";
            this.btnOption.UseSelectable = true;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(23, 323);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(728, 306);
            this.flowLayoutPanel4.TabIndex = 16;
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ProfilePicture.Image = global::TzalemTmuna.Properties.Resources.emptyprofilepicture;
            this.ProfilePicture.Location = new System.Drawing.Point(52, 66);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(150, 150);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ProfilePicture.TabIndex = 14;
            this.ProfilePicture.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 652);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ProfilePicture);
            this.MaximizeBox = false;
            this.Name = "Profile";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private ProfilePicture ProfilePicture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLabel lblUsername;
        private MetroFramework.Controls.MetroButton btnOption;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblBio;
        private MetroFramework.Controls.MetroLink lblWebsite;
        private MetroFramework.Controls.MetroLabel lblPosts;
        private MetroFramework.Controls.MetroLabel lblTextPosts;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private MetroFramework.Controls.MetroLink lblTextFollowers;
        private MetroFramework.Controls.MetroLink lblFollowers;
        private MetroFramework.Controls.MetroLink lblFollowing;
        private MetroFramework.Controls.MetroLink lblFollowingText;
    }
}