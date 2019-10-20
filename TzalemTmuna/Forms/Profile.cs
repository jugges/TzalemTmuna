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

namespace TzalemTmuna.Forms
{
    public partial class Profile : MetroFramework.Forms.MetroForm
    {
        MetroFramework.Components.MetroStyleManager styleManager;
        public LoginUser login;
        public User user;
        public bool isMine;
        public MetroFramework.Forms.MetroForm father;

        public Profile(MetroFramework.Components.MetroStyleManager styleManager,LoginUser login, MetroFramework.Forms.MetroForm father)
        {
            InitializeComponent();
            styleManager.Owner = this;
            StyleManager = styleManager;
            this.styleManager = styleManager;
            this.login = login;
            isMine = true;
            this.father = father;
            ProfilePicture.BackColor = BackColor;
            ProfilePicture.Image = FileTools.getProfilePicture(login.Username);
            lblBio.Text = login.Biography.Replace("\\n", Environment.NewLine);
            lblName.Text = login.Full_name;
            lblUsername.Text = login.Username;
            lblWebsite.Text = login.External_url;
            lblFollowers.Text = login.Followers.Count.ToString();
            lblFollowing.Text = login.Following.Count.ToString();
            btnOption.Text = "Edit Profile";
        }
        private void EditProfile()
        {
            new EditProfile(styleManager, login).ShowDialog();
            //Refresh profile
            ProfilePicture.Image = FileTools.getProfilePicture(login.Username);
            lblBio.Text = login.Biography.Replace("\\n", Environment.NewLine);
            lblName.Text = login.Full_name;
            lblUsername.Text = login.Username;
            lblWebsite.Text = login.External_url;
        }
        public Profile(MetroFramework.Components.MetroStyleManager styleManager, LoginUser login, User user, MetroFramework.Forms.MetroForm father)
        {
            InitializeComponent();
            styleManager.Owner = this;
            StyleManager = styleManager;
            this.styleManager = styleManager;
            this.login = login;
            this.user = user;
            isMine = false;
            this.father = father;
            ProfilePicture.BackColor = BackColor;
            ProfilePicture.Image = FileTools.getProfilePicture(user.Username);
            lblBio.Text = user.Biography.Replace("\\n", Environment.NewLine);
            lblName.Text = user.Full_name;
            lblUsername.Text = user.Username;
            lblWebsite.Text = user.External_url;
            lblFollowers.Text = user.Followers.Count.ToString();
            lblFollowing.Text = user.Following.Count.ToString();
            btnOption.Text = "Follow";
            foreach (User x in login.Following)
            {
                if (x.Username == user.Username)
                {
                    btnOption.Text = "Following";
                    if (styleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                        btnOption.Theme = MetroFramework.MetroThemeStyle.Light;
                    else
                        btnOption.Theme = MetroFramework.MetroThemeStyle.Dark;
                    break;
                }
            }
        }
        private void Unfollow()
        {
            var fdb = new FollowingDB();
            fdb.Unfollow(login, user);
            btnOption.Text = "Follow";
            btnOption.Theme = styleManager.Theme;
            //Refresh followers
            lblFollowers.Text = user.Followers.Count.ToString();
        }
        private void Follow()
        {
            var fdb = new FollowingDB();
            fdb.Follow(login, user);
            btnOption.Text = "Following";
            if (styleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                btnOption.Theme = MetroFramework.MetroThemeStyle.Light;
            else
                btnOption.Theme = MetroFramework.MetroThemeStyle.Dark;
            //Refresh followers
            lblFollowers.Text = user.Followers.Count.ToString();
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
            }
        }

        private void ShowList(bool isFollowers)
        {
            if (isMine)
            {
                new Followers(styleManager,this, isFollowers).ShowDialog();
                //Refresh following
                lblFollowing.Text = login.Following.Count.ToString();
                lblFollowers.Text = login.Followers.Count.ToString();
            }
            else
            {
                new Followers(styleManager,this, isFollowers, user).ShowDialog();
                //Refresh following
                lblFollowing.Text = user.Following.Count.ToString();
                lblFollowers.Text = user.Followers.Count.ToString();
            }
        }

        public void RefreshFollowingAndFollowers()
        {
            if (isMine)
            {
                //Refresh following
                lblFollowing.Text = login.Following.Count.ToString();
            }
            else
            {
                //Refresh following
                lblFollowing.Text = user.Following.Count.ToString();
            }
        }

        private void lblTextFollowers_Click(object sender, EventArgs e)
        {
            ShowList(true);
        }

        private void lblFollowers_Click(object sender, EventArgs e)
        {
            ShowList(true);
        }

        private void lblFollowingText_Click(object sender, EventArgs e)
        {
            ShowList(false);
        }

        private void lblFollowing_Click(object sender, EventArgs e)
        {
            ShowList(false);
        }
    }
}
