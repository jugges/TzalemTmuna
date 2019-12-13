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
    public partial class CommentControl : MetroFramework.Controls.MetroUserControl
    {
        User user;
        int mode;
        ViewPost callingViewPost;
        public CommentControl()
        {
            InitializeComponent();
        }
        //Login's comment
        public CommentControl(ViewPost callingViewPost)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            user = new User(LoggedInUser.login);
            this.callingViewPost = callingViewPost;
            this.mode = mode;
            lblUsername.Text = LoggedInUser.login.Username;
            lblText.Text = LoggedInUser.login.Full_name;
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
            lblText.Text = user.Full_name;
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
            lblText.Text = user.Full_name;
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
            fdb.Unfollow(user);
            if (user.Username == LoggedInUser.login.Username && mode == 1)
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
                fdb.Follow(user);
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

        private void openProfile()
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
                    newProfile.redirectHere += (s, args) => callingProfile.RefreshFollowingAndFollowers();
                newProfile.redirectHere += (s, args) => callingProfile.Show();
                newProfile.redirectAfterClose = true;
            }
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
