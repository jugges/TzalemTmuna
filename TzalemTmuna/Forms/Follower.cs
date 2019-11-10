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
    public partial class Follower : MetroFramework.Controls.MetroUserControl
    {
        Profile callingProfile;
        User user;
        int Mode;
        bool isMine;
        public Follower()
        {
            InitializeComponent();
        }
        //Not login's list, but login is the one on the list!
        public Follower(Profile callingProfile, User user, int Mode)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            this.callingProfile = callingProfile;
            this.user = user;
            this.isMine = true;
            this.Mode = Mode;
            lblUsername.Text = LoggedInUser.login.Username;
            lblFullName.Text = LoggedInUser.login.Full_name;
            var pic = FileTools.getProfilePicture(LoggedInUser.login.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }
            if (Mode == 0)
                Controls.Remove(btnOption);
            else
            {
                btnOption.Text = "Remove";
                btnOption.UseStyleColors = true;
            }
        }
        //login is not the one on the list!
        public Follower(Profile callingProfile, User user, int Mode, bool isMine)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            this.callingProfile = callingProfile;
            this.user = user;
            this.isMine = isMine;
            this.Mode = Mode;
            lblUsername.Text = user.Username;
            lblFullName.Text = user.Full_name;
            var pic = FileTools.getProfilePicture(user.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }
            if (Mode == 2)
            {
                btnOption.Text = "Accept";
                if (StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                    btnOption.Theme = MetroFramework.MetroThemeStyle.Light;
                else
                    btnOption.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
            else
            {
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
        }

        private void Unfollow()
        {
            var fdb = new FollowingDB();
            fdb.Unfollow(LoggedInUser.login, user);
            if (isMine && Mode == 1)
            {
                this.Parent.Controls.Remove(this);
            }
            else
            {
                btnOption.Text = "Follow";
                btnOption.Theme = StyleManager.Theme;
            }

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
            }
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
            btnOption.Text = "Follow";
            btnOption.Theme = StyleManager.Theme;
        }

        private void AcceptRequest()
        {
            var rdb = new RequestsDB();
            rdb.AcceptRequest(LoggedInUser.login, user);
            this.Parent.Controls.Remove(this);
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
                case "Remove":
                    Remove();
                    break;
                case "Requested":
                    RemoveRequest();
                    break;
                case "Accept":
                    AcceptRequest();
                    break;
            }
        }

        private int openProfile()
        {
            Followers followers = (Followers)Parent.Parent;
            try
            {
                var father = (Profile)callingProfile.father;
                if (father.isMine && isMine)
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
    }
}
