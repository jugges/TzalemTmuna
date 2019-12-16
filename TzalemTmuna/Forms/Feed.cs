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
        int scrollLocation = 0;
        public Feed()
        {
            InitializeComponent();
            //StyleManager = new MetroFramework.Components.MetroStyleManager
            //{
            //    Owner = this,
            //    Theme = Statics.Theme.MetroThemeStyle
            //};
            //udb = new UserDB();
            //var usernameList = udb.GetUsernameList();
            //txtSearch.AutoCompleteCustomSource.AddRange(usernameList);

            //foreach (Post post in LoggedInUser.login.Posts)
            //{
            //    FeedThumbnail thumbnail = new FeedThumbnail(post);
            //    thumbnail.Anchor = AnchorStyles.None;
            //    flowLayoutPanel1.Controls.Add(thumbnail);
            //}

            //if (LoggedInUser.login.ReceivedRequests.Count == 0)
            //{
            //    Controls.Remove(lblNotifications);
            //    lblNotifications.Dispose();
            //}
            //else
            //    lblNotifications.Text = LoggedInUser.login.ReceivedRequests.Count.ToString();

        }
        public void ResetMe()
        {
            Refresh();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            udb = new UserDB();
            var usernameList = udb.GetUsernameList();
            txtSearch.AutoCompleteCustomSource.AddRange(usernameList);

            flowLayoutPanel1.Controls.Clear();
            foreach (Post post in LoggedInUser.login.FeedPosts())
            {
                FeedThumbnail thumbnail = new FeedThumbnail(post);
                thumbnail.Anchor = AnchorStyles.None;
                flowLayoutPanel1.Controls.Add(thumbnail);
                flowLayoutPanel1.VerticalScroll.Maximum += thumbnail.Height;
            }

            if (LoggedInUser.login.ReceivedRequests.Count == 0)
            {
                lblNotifications.Hide();
            }
            else
            {
                lblNotifications.Show();
                lblNotifications.Text = LoggedInUser.login.ReceivedRequests.Count.ToString();
            }
        }

        public void RefreshFeed()
        {
            flowLayoutPanel1.Controls.Clear();
            foreach (Post post in LoggedInUser.login.FeedPosts())
            {
                FeedThumbnail thumbnail = new FeedThumbnail(post);
                thumbnail.Anchor = AnchorStyles.None;
                flowLayoutPanel1.Controls.Add(thumbnail);
                flowLayoutPanel1.VerticalScroll.Maximum += thumbnail.Height;
            }

            if (LoggedInUser.login.ReceivedRequests.Count == 0)
            {
                lblNotifications.Hide();
            }
            else
            {
                lblNotifications.Show();
                lblNotifications.Text = LoggedInUser.login.ReceivedRequests.Count.ToString();
            }
        }
        private void flowLayoutPanel1_MouseWheel(object sender, MouseEventArgs e)
        {
            scrollLocation -= e.Delta;

            if (scrollLocation < flowLayoutPanel1.VerticalScroll.Minimum)
            {
                scrollLocation = flowLayoutPanel1.VerticalScroll.Minimum;
            }
            else if (scrollLocation > flowLayoutPanel1.VerticalScroll.Maximum)
            {
                scrollLocation = flowLayoutPanel1.VerticalScroll.Maximum;
            }

            flowLayoutPanel1.VerticalScroll.Value = scrollLocation;
            flowLayoutPanel1.AutoScrollPosition = new Point(0,scrollLocation);
            flowLayoutPanel1.PerformLayout();
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
                    LoggedInUser.profile.redirectAfterClose = true;
                    LoggedInUser.profile.RedirectHere += (s,args) => RefreshFeed();
                }
                else
                {
                    Profile newProfile = new Profile(new User(udb.GetCurrentRow()));
                    newProfile.Show();
                    newProfile.redirectAfterClose = true;
                    newProfile.RedirectHere += (s, args) => RefreshFeed();
                }
            }
            else
                MessageBox.Show("User not found!");
        }

        private void lblNotifications_Click(object sender, EventArgs e)
        {
            new Followers(2).ShowDialog();
            RefreshFeed();
        }
    }
}
