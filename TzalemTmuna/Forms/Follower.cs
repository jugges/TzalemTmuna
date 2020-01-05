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
        User user;
        int mode;
        Profile callingProfile;
        public Follower()
        {
            InitializeComponent();
        }
        //Not login's list, but login is the one on the list!
        public Follower(Profile callingProfile, int mode)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            user = new User(LoggedInUser.login);
            this.callingProfile = callingProfile;
            this.mode = mode;
            lblUsername.Text = LoggedInUser.login.Username;
            lblFullName.Text = LoggedInUser.login.Full_name;
            var pic = FileTools.getProfilePicture(LoggedInUser.login.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }
            if (mode == 0)
                Controls.Remove(btnOption);
            else
            {
                btnOption.Text = "Remove";
                btnOption.UseStyleColors = true;
            }
        }
        //Not login's list, and login is NOT the one on the list!
        public Follower(Profile callingProfile, User user, int mode)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            this.callingProfile = callingProfile;
            this.user = user;
            this.mode = mode;
            lblUsername.Text = user.Username;
            lblFullName.Text = user.Full_name;
            var pic = FileTools.getProfilePicture(user.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }
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
        //Login's list
        public Follower(User user, int mode)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            this.callingProfile = LoggedInUser.profile;
            this.user = user;
            this.mode = mode;
            lblUsername.Text = user.Username;
            lblFullName.Text = user.Full_name;
            var pic = FileTools.getProfilePicture(user.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }
            bool flag = true;
            if (mode == 0)
            {
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
            else
            {
                btnOption.Text = "Following";
                if (StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                    btnOption.Theme = MetroFramework.MetroThemeStyle.Light;
                else
                    btnOption.Theme = MetroFramework.MetroThemeStyle.Dark;
            }
        }

        private void Unfollow()
        {
            var fdb = new FollowingDB();
            
            if (user.Username == LoggedInUser.login.Username && mode == 1)
            {
                fdb.UnfollowForUser(user);
                Parent.Controls.Remove(this);
            }
            else
            {
                fdb.Unfollow(user);
                btnOption.Text = "Follow";
                btnOption.Theme = StyleManager.Theme;
                //Refresh feed
                LoggedInUser.feed.RefreshFeed();
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
                fdb.Follow(user);
                btnOption.Text = "Following";
                if (StyleManager.Theme == MetroFramework.MetroThemeStyle.Dark)
                    btnOption.Theme = MetroFramework.MetroThemeStyle.Light;
                else
                    btnOption.Theme = MetroFramework.MetroThemeStyle.Dark;
                //Refresh feed
                LoggedInUser.feed.RefreshFeed();
            }
        }

        private void Remove()
        {
            var fdb = new FollowingDB();
            fdb.Remove(callingProfile.user);
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
            //THIS IS SOME UGLY CODE!
            //I should change it to something like ViewReport -> ViewReport(Report report) -> if (propertyOfLogin)
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

        private void OpenProfile(object sender, EventArgs e)
        {
            Followers followers = (Followers)Parent.Parent;
            if (user.Username == LoggedInUser.login.Username)
            {
                LoggedInUser.profile.RefreshFollowingAndFollowers();
                LoggedInUser.profile.Show();
                callingProfile.redirectAfterClose = false;
                callingProfile.Close();
                followers.Close();
            }
            else
            {
                callingProfile.Hide();
                Profile newProfile = new Profile(user);
                newProfile.Show();
                followers.Close();
                if (callingProfile.isMainProfile)
                    newProfile.RedirectHere += (s, args) => callingProfile.RefreshFollowingAndFollowers();
                newProfile.RedirectHere += (s, args) => callingProfile.Show();
                newProfile.redirectAfterClose = true;
            }
        }
}
}
