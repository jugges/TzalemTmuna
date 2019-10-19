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
        IEntity user;
        List<User> following;
        List<User> followers;
        public Profile(LoginUser user)
        {
            InitializeComponent();
            this.user = user;
            ProfilePicture.BackColor = BackColor;
            ProfilePicture.Image = FileTools.getProfilePicture(user.Username);
            lblBio.Text = user.Biography.Replace("\\n", Environment.NewLine);
            lblName.Text = user.Full_name;
            lblUsername.Text = user.Username;
            lblWebsite.Text = user.External_url;
            followers = user.Followers;
            following = user.Following;
            lblFollowers.Text = followers.Count.ToString();
            lblFollowing.Text = following.Count.ToString();
            btnOption.Text = "Edit Profile";
        }

        public Profile(User user)
        {
            InitializeComponent();
            this.user = user;
            ProfilePicture.BackColor = BackColor;
            ProfilePicture.Image = FileTools.getProfilePicture(user.Username);
            lblBio.Text = user.Biography.Replace("\\n", Environment.NewLine);
            lblName.Text = user.Full_name;
            lblUsername.Text = user.Username;
            lblWebsite.Text = user.External_url;
            followers = user.Followers;
            following = user.Following;
            lblFollowers.Text = followers.Count.ToString();
            lblFollowing.Text = following.Count.ToString();

            //if(followers.Contains())
            btnOption.Text = "Follow";
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
