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
        LoginUser login;
        User user;
        bool isMine;
        public Profile(MetroFramework.Components.MetroStyleManager styleManager,LoginUser login)
        {
            InitializeComponent();
            styleManager.Owner = this;
            StyleManager = styleManager;
            this.styleManager = styleManager;
            this.login = login;
            isMine = true;
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

        public Profile(MetroFramework.Components.MetroStyleManager styleManager, LoginUser login, User user)
        {
            InitializeComponent();
            styleManager.Owner = this;
            StyleManager = styleManager;
            this.styleManager = styleManager;
            this.login = login;
            this.user = user;
            isMine = false;
            ProfilePicture.BackColor = BackColor;
            ProfilePicture.Image = FileTools.getProfilePicture(user.Username);
            lblBio.Text = user.Biography.Replace("\\n", Environment.NewLine);
            lblName.Text = user.Full_name;
            lblUsername.Text = user.Username;
            lblWebsite.Text = user.External_url;
            lblFollowers.Text = user.Followers.Count.ToString();
            lblFollowing.Text = user.Following.Count.ToString();

            //if(followers.Contains())
            btnOption.Text = "Follow";
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            
        }

        private void lblTextFollowers_Click(object sender, EventArgs e)
        {
            new Followers(styleManager,true,login).ShowDialog();
            lblFollowing.Text = login.Following.Count.ToString();
        }

        private void lblFollowers_Click(object sender, EventArgs e)
        {
            lblTextFollowers_Click(sender, e);
        }

        private void lblFollowingText_Click(object sender, EventArgs e)
        {
            new Followers(styleManager, false, login).ShowDialog();
            lblFollowing.Text = login.Following.Count.ToString();
        }

        private void lblFollowing_Click(object sender, EventArgs e)
        {

        }
    }
}
