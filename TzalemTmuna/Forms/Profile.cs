using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TzalemTmuna.DB;
using TzalemTmuna.Utilities;
using TzalemTmuna.Entities;
using TzalemTmuna.Data;
using TzalemTmuna.Statics;

namespace TzalemTmuna.Forms
{
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        public User user;
        public bool isMine;
        public MetroFramework.Forms.MetroForm father;

        //login's profile
        public Profile(MetroFramework.Forms.MetroForm father)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            isMine = true;
            this.father = father;
            ProfilePicture.BackColor = BackColor;
            ProfilePicture.Image = FileTools.getProfilePicture(LoggedInUser.login.Username);
            if (LoggedInUser.login.Biography != null)
                lblBio.Text = LoggedInUser.login.Biography.Replace("\\n", Environment.NewLine);
            else
                lblBio.Text = string.Empty;
            lblName.Text = LoggedInUser.login.Full_name;
            lblUsername.Text = LoggedInUser.login.Username;
            lblWebsite.Text = LoggedInUser.login.External_url;
            lblFollowers.Text = LoggedInUser.login.Followers.Count.ToString();
            lblFollowing.Text = LoggedInUser.login.Following.Count.ToString();
            if (LoggedInUser.login.ReceivedRequests.Count == 0)
            {
                btnFollowRequests.Hide();
            }
            btnOption.Text = "Edit Profile";
        }
        //Edit Profile button - for login
        private void EditProfile()
        {
            new EditProfile().ShowDialog();
            //Refresh profile
            ProfilePicture.Image = FileTools.getProfilePicture(LoggedInUser.login.Username);
            if (LoggedInUser.login.Biography != null)
                lblBio.Text = LoggedInUser.login.Biography.Replace("\\n", Environment.NewLine);
            else
                lblBio.Text = string.Empty;
            lblName.Text = LoggedInUser.login.Full_name;
            lblUsername.Text = LoggedInUser.login.Username;
            lblWebsite.Text = LoggedInUser.login.External_url;
        }
        //user's profile
        public Profile(User user, MetroFramework.Forms.MetroForm father)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            this.user = user;
            isMine = false;
            this.father = father;
            ProfilePicture.BackColor = BackColor;
            ProfilePicture.Image = FileTools.getProfilePicture(user.Username);
            if (user.Biography != null)
                lblBio.Text = user.Biography.Replace("\\n", Environment.NewLine);
            else
                lblBio.Text = string.Empty;
            lblName.Text = user.Full_name;
            lblUsername.Text = user.Username;
            lblWebsite.Text = user.External_url;
            lblFollowers.Text = user.Followers.Count.ToString();
            lblFollowing.Text = user.Following.Count.ToString();
            Controls.Remove(btnFollowRequests);
            btnFollowRequests.Dispose();
            Controls.Remove(btnLogout);
            btnLogout.Dispose();
            Controls.Remove(btnUpload);
            btnUpload.Dispose();
            btnOption.Text = "Follow";
            bool flag = true;
            if (user.is_private)
            {
                foreach (User x in LoggedInUser.login.SentRequests)
                {
                    if (x.Username == user.Username)
                    {
                        btnOption.Text = "Requested";
                        flag = false;
                        if (StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                            btnOption.Theme = MetroFramework.MetroThemeStyle.Light;
                        else
                            btnOption.Theme = MetroFramework.MetroThemeStyle.Dark;
                        break;
                    }
                }
            }
            if (flag)
            {
                foreach (User x in LoggedInUser.login.Following)
                {
                    if (x.Username == user.Username)
                    {
                        btnOption.Text = "Following";
                        if (StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                            btnOption.Theme = MetroFramework.MetroThemeStyle.Light;
                        else
                            btnOption.Theme = MetroFramework.MetroThemeStyle.Dark;
                        break;
                    }
                }
            }
        }
        private void Unfollow()
        {
            var fdb = new FollowingDB();
            fdb.Unfollow(LoggedInUser.login, user);
            btnOption.Text = "Follow";
            btnOption.Theme = StyleManager.Theme;
            //Refresh followers
            lblFollowers.Text = user.Followers.Count.ToString();
        }
        private void Follow()
        {
            if (user.is_private)
            {
                var rdb = new RequestsDB();
                rdb.SendRequest(LoggedInUser.login, user);
                btnOption.Text = "Requested";
                if (StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                    btnOption.Theme = MetroFramework.MetroThemeStyle.Light;
                else
                    btnOption.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
                var fdb = new FollowingDB();
                fdb.Follow(LoggedInUser.login, user);
                btnOption.Text = "Following";
                if (StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                    btnOption.Theme = MetroFramework.MetroThemeStyle.Light;
                else
                    btnOption.Theme = MetroFramework.MetroThemeStyle.Dark;
                //Refresh followers
                lblFollowers.Text = user.Followers.Count.ToString();
            }
        }
        private void RemoveRequest()
        {
            var rdb = new RequestsDB();
            rdb.RemoveRequest(LoggedInUser.login, user);
            btnOption.Text = "Follow";
            btnOption.Theme = StyleManager.Theme;
        }
        private void btnOption_Click(object sender, EventArgs e)
        {
            switch (btnOption.Text)
            {
                case "Follow":
                    Follow();
                    break;
                case "Following":
                    Unfollow();
                    break;
                case "Edit Profile":
                    EditProfile();
                    break;
                case "Requested":
                    RemoveRequest();
                    break;
            }
        }

        private void ShowList(int Mode)
        {
            if (isMine)
            {
                new Followers(this, Mode).ShowDialog();
                //Refresh following
                lblFollowing.Text = LoggedInUser.login.Following.Count.ToString();
                lblFollowers.Text = LoggedInUser.login.Followers.Count.ToString();
                if (Mode == 2)
                    if (LoggedInUser.login.ReceivedRequests.Count == 0)
                    {
                        btnFollowRequests.Hide();
                    }
            }
            else
            {
                new Followers(this, Mode, user).ShowDialog();
                //Refresh following
                lblFollowing.Text = user.Following.Count.ToString();
                lblFollowers.Text = user.Followers.Count.ToString();
            }
        }

        public void RefreshPage()
        {
            if (isMine)
            {
                if (!btnFollowRequests.Visible && LoggedInUser.login.ReceivedRequests.Count != 0)
                {
                    btnFollowRequests.Show();
                }
            }
        }

        public void RefreshFollowingAndFollowers()
        {
            if (isMine)
            {
                //Refresh following
                lblFollowing.Text = LoggedInUser.login.Following.Count.ToString();
            }
            else
            {
                //Refresh following
                lblFollowing.Text = user.Following.Count.ToString();
            }
        }

        private void lblTextFollowers_Click(object sender, EventArgs e)
        {
            ShowList(0);
        }

        private void lblFollowers_Click(object sender, EventArgs e)
        {
            ShowList(0);
        }

        private void lblFollowingText_Click(object sender, EventArgs e)
        {
            ShowList(1);
        }

        private void lblFollowing_Click(object sender, EventArgs e)
        {
            ShowList(1);
        }

        private void btnFollowRequests_Click(object sender, EventArgs e)
        {
            ShowList(2);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = string.Empty;
            Properties.Settings.Default.password = string.Empty;
            Properties.Settings.Default.Save();
            if (father != null)
            {
                try
                {
                    Login login = (Login)father;
                    Closed += (s, args) => father.Show();
                }
                catch
                {
                }
            }
            //else
            //    Closed += (s, args) => new Login(styleManager).Show();
            Close();
        }

        private void Profile_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ActiveControl.Text != "Logout")
            {
                try
                {
                    Login login = (Login)father;
                    father = null;
                }
                catch
                {

                }
                if (father==null)
                    Environment.Exit(0);
            }
        }

        private void lblWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lblWebsite.Text);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            new NewPost(this).ShowDialog();
        }
    }
}
