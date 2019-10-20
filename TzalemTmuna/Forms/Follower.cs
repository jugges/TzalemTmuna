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

namespace TzalemTmuna.Forms
{
    public partial class Follower : MetroFramework.Controls.MetroUserControl
    {
        MetroFramework.Components.MetroStyleManager styleManager;
        LoginUser login;
        User user;
        bool isFollower;
        bool isMine;
        public Follower()
        {
            InitializeComponent();
        }
        //Not login's list, but login is the one on the list!
        public Follower(MetroFramework.Components.MetroStyleManager styleManager, User user, LoginUser login, bool isFollower)
        {
            InitializeComponent();
            styleManager.Owner = this;
            StyleManager = styleManager;
            this.styleManager = styleManager;
            this.login = login;
            this.user = user;
            this.isMine = false;
            this.isFollower = isFollower;
            lblUsername.Text = user.Username;
            lblFullName.Text = user.Full_name;
            var pic = FileTools.getProfilePicture(user.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }
            if (isFollower)
                Controls.Remove(btnOption);
            else
            {
                btnOption.Text = "Remove";
                btnOption.UseStyleColors = true;
            }
        }
        //login is not the one on the list!
        public Follower(MetroFramework.Components.MetroStyleManager styleManager, User user, LoginUser login, bool isFollower, bool isMine)
        {
            InitializeComponent();
            styleManager.Owner = this;
            StyleManager = styleManager;
            this.styleManager = styleManager;
            this.login = login;
            this.user = user;
            this.isMine = isMine;
            this.isFollower = isFollower;
            lblUsername.Text = user.Username;
            lblFullName.Text = user.Full_name;
            var pic = FileTools.getProfilePicture(user.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }
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
            if (isMine && !isFollower)
            {
                this.Parent.Controls.Remove(this);
            }
            else
            {
                btnOption.Text = "Follow";
                btnOption.Theme = styleManager.Theme;
            }

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
        }

        private void Remove()
        {
            var fdb = new FollowingDB();
            fdb.Unfollow(login, user);
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
            }
        }
    }
}
