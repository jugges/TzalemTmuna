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
    public partial class AlertItem : MetroFramework.Controls.MetroUserControl, IMouseBoundable
    {
        int alert_id;
        public AlertItem()
        {
            InitializeComponent();
        }
        //Show a new follow requests alert
        public AlertItem(int requestCount)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
            //lblAlertText.Text = requestCount>1?$"You have {requestCount} new follow requests!":"You have a new follow request!";
            lblAlertText.Cursor = Cursors.Hand;
            lblAlertText.Click += new EventHandler(btnGoToFollowRequests_Click);
            Controls.Remove(btnRemove);
            btnRemove.Dispose();
            if (requestCount > 1)
            {
                pbMain.Location = new Point(3, 3);
                lblAlertText.Text = $"You have {requestCount} new follow requests!";
                pbSecond.Image = FileTools.getProfilePicture(LoggedInUser.login.ReceivedRequests[0].Username);
                pbMain.Image = FileTools.getProfilePicture(LoggedInUser.login.ReceivedRequests[1].Username);
            }
            else
            {
                Controls.Remove(pbSecond);
                pbSecond.Dispose();
                pbMain.Image = FileTools.getProfilePicture(LoggedInUser.login.ReceivedRequests[0].Username);
                lblAlertText.Text = "You have a new follow request!";
            }
        }
        //Show a custom alert
        public AlertItem(Alert alert)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
            Controls.Remove(pbSecond);
            pbSecond.Dispose();
            lblAlertText.Text = alert.Alert_text;
            alert_id = alert.Alert_id;
            pbMain.Image = Theme == MetroFramework.MetroThemeStyle.Dark ? Properties.Dark.darkAlert : Properties.Light.lightAlert;
        }

        public void ToggleMenu()
        {
            btnRemove.Visible = !btnRemove.Visible;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var adb = new AlertDB();
            adb.RemoveAlert(alert_id);
            foreach (Alert a in LoggedInUser.login.Alerts)
            {
                if(a.Alert_id == alert_id)
                {
                    LoggedInUser.login.Alerts.Remove(a);
                    break;
                }
            }
            this.Parent.Controls.Remove(this);
        }

        private void btnGoToFollowRequests_Click(object sender, EventArgs e)
        {
            new Followers(2).ShowDialog();
            if (LoggedInUser.login.ReceivedRequests.Count > 1)
            {
                pbMain.Location = new Point(3, 3);
                lblAlertText.Text = $"You have {LoggedInUser.login.ReceivedRequests.Count} new follow requests!";
                pbSecond.Image = FileTools.getProfilePicture(LoggedInUser.login.ReceivedRequests[0].Username);
                pbMain.Image = FileTools.getProfilePicture(LoggedInUser.login.ReceivedRequests[1].Username);
            }
            else if (LoggedInUser.login.ReceivedRequests.Count == 1)
            {
                pbMain.Location = pbSecond.Location;
                Controls.Remove(pbSecond);
                pbSecond.Dispose();
                pbMain.Image = FileTools.getProfilePicture(LoggedInUser.login.ReceivedRequests[0].Username);
                lblAlertText.Text = "You have a new follow request!";
            }
            else
            {
                this.Parent.Controls.Remove(this);
            }
        }

        private void AlertItem_ParentChanged(object sender, EventArgs e)
        {
            if (Parent != null)
            {
                MinimumSize = new Size(Parent.Width, MinimumSize.Height);
                Width = Parent.Width;
            }
        }
    }
}
