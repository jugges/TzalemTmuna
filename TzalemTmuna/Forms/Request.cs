using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TzalemTmuna.Utilities;
using TzalemTmuna.Entities;
using TzalemTmuna.DB;
using TzalemTmuna.Statics;

namespace TzalemTmuna.Forms
{
    public partial class Request : MetroFramework.Controls.MetroUserControl
    {
        Profile callingProfile;
        User user;
        public Request()
        {
            InitializeComponent();
        }

        //login is not the one on the list!
        public Request(Profile callingProfile, User user)
        {
            InitializeComponent();
            StyleManager.Theme = Statics.Theme.MetroThemeStyle;
            this.callingProfile = callingProfile;
            this.user = user;
            lblUsername.Text = user.Username;
            lblFullName.Text = user.Full_name;
            var pic = FileTools.getProfilePicture(user.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }

            if (StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                btnAccept.Theme = MetroFramework.MetroThemeStyle.Light;
            else
                btnAccept.Theme = MetroFramework.MetroThemeStyle.Dark;
        }

        private void Remove()
        {
            var fdb = new FollowingDB();
            fdb.Remove(LoggedInUser.login, user);
            this.Parent.Controls.Remove(this);
        }

        private void RemoveRequest()
        {
            var rdb = new RequestsDB();
            rdb.RemoveRequest(LoggedInUser.login, user);
            btnDecline.Text = "Follow";
            btnDecline.Theme = StyleManager.Theme;
        }

        private void AcceptRequest()
        {
            var rdb = new RequestsDB();
            rdb.AcceptRequest(LoggedInUser.login, user);
            this.Parent.Controls.Remove(this);
        }

        private void DeclineRequest()
        {
            var rdb = new RequestsDB();
            rdb.DeclineRequest(LoggedInUser.login, user);
            this.Parent.Controls.Remove(this);
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            DeclineRequest();
        }

        private int openProfile()
        {
            Followers followers = (Followers)Parent.Parent;
            try
            {
                var father = (Profile)callingProfile.father;
                if (father.isMine)
                {
                    father.RefreshFollowingAndFollowers();
                    father.Show();
                    callingProfile.Close();
                    followers.Close();
                    return 0;
                }
            }
            catch
            {

            }
            callingProfile.Hide();
            Profile newProfile = new Profile(user, callingProfile);
            newProfile.Show();
            followers.Close();
            if (callingProfile.isMine)
                newProfile.Closed += (s, args) => callingProfile.RefreshFollowingAndFollowers();
            newProfile.Closed += (s, args) => callingProfile.Show();
            return 1;
        }
        private void lblUsername_Click(object sender, EventArgs e)
        {
            openProfile();
        }

        private void lblFullName_Click(object sender, EventArgs e)
        {
            openProfile();
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            openProfile();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            AcceptRequest();
        }
    }
}
