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
    public partial class Followers : MetroFramework.Forms.MetroForm
    {
        //login's list!
        public Followers(int mode)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
            if (mode == 0)
            {
                foreach (User x in LoggedInUser.login.Followers)
                {
                    //x is the follower!
                    var y = new Follower(x, mode);
                    metroPanel.Controls.Add(y);
                    y.Dock = DockStyle.Top;
                }
            }
            else if (mode == 1)
            {
                Text = "Following";
                foreach (User x in LoggedInUser.login.Following)
                {
                    //x is the followed!
                    var y = new Follower(x, mode);
                    metroPanel.Controls.Add(y);
                    y.Dock = DockStyle.Top;
                }
            }
            else
            {
                Text = "Follow Requests";
                foreach (User x in LoggedInUser.login.ReceivedRequests)
                {
                    //x is the requester!
                    var y = new Request(x);
                    metroPanel.Controls.Add(y);
                    y.Dock = DockStyle.Top;
                }
            }
        }
        //user's list!
        public Followers(Profile callingProfile, int mode, User user)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
            List<User> follow;
            if (mode == 0)
                follow = user.Followers;
            else
            {
                follow = user.Following;
                Text = "Following";
            }
            foreach (User x in follow)
            {
                Follower y;
                if (x.Username == LoggedInUser.login.Username)
                {
                    //login is the follower/followed!
                    y = new Follower(callingProfile, mode);
                }
                else
                {
                    //x is the follower/followed!
                    y = new Follower(callingProfile,x, mode);
                }
                metroPanel.Controls.Add(y);
                y.Dock = DockStyle.Top;
            }
        }
    }
}
