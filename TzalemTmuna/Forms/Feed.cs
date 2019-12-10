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
    public partial class Feed : MetroFramework.Forms.MetroForm
    {
        UserDB udb;
        public Feed()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            udb = new UserDB();
            var usernameList = udb.GetUsernameList();
            txtSearch.AutoCompleteCustomSource.AddRange(usernameList);

            foreach (Post post in LoggedInUser.login.Posts)
            {
                FeedThumbnail thumbnail = new FeedThumbnail(post);
                thumbnail.Anchor = AnchorStyles.None;
                flowLayoutPanel1.Controls.Add(thumbnail);
            }

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            LoggedInUser.profile.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (udb.Find(txtSearch.Text))
            {
                if (udb.GetCurrentRow()["username"].ToString() == LoggedInUser.login.Username)
                {
                    LoggedInUser.profile.Show();
                }
                else
                {
                    Profile newProfile = new Profile(new User(udb.GetCurrentRow()));
                    newProfile.Show();
                }
            }
            else
                MessageBox.Show("User not found!");
        }
    }
}
