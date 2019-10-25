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
    public partial class Followers : MetroFramework.Forms.MetroForm
    {
        //login's list!
        public Followers(MetroFramework.Components.MetroStyleManager styleManager,Profile callingProfile, int Mode)
        {
            InitializeComponent();
            styleManager.Owner = this;
            StyleManager = styleManager;
            List<User> follow;
            if (Mode==0)
                follow = callingProfile.login.Followers;
            else if(Mode==1)
            {
                follow = callingProfile.login.Following;
                Text = "Following";
            }else
            {
                follow = callingProfile.login.ReceivedRequests;
                Text = "Follow Requests";
            }
            foreach (User x in follow)
            {
                //x is the follower/followed!
                var y = new Follower(styleManager, callingProfile,x, Mode, true);
                metroPanel.Controls.Add(y);
                y.Dock = DockStyle.Top;
            }
        }
        //user's list!
        public Followers(MetroFramework.Components.MetroStyleManager styleManager, Profile callingProfile, int Mode, User user)
        {
            InitializeComponent();
            styleManager.Owner = this;
            StyleManager = styleManager;
            List<User> follow;
            if (Mode==0)
                follow = user.Followers;
            else
            {
                follow = user.Following;
                Text = "Following";
            }
            foreach (User x in follow)
            {
                Follower y;
                if (x.Username == callingProfile.login.Username)
                {
                    //login is the follower/followed!
                    y = new Follower(styleManager,callingProfile,user, Mode);
                }
                else
                {
                    //x is the follower/followed!
                    y = new Follower(styleManager, callingProfile,x, Mode,false);
                }
                metroPanel.Controls.Add(y);
                y.Dock = DockStyle.Top;
            }
        }
    }
}
