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
    public partial class Alerts : MetroFramework.Forms.MetroForm
    {
        public Alerts()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
            foreach (Alert x in LoggedInUser.login.Alerts)
            {
                var y = new AlertItem(x);
                metroPanel.Controls.Add(y);
                y.Dock = DockStyle.Top;
            }
            int followRequestCount = LoggedInUser.login.ReceivedRequests.Count;
            if (followRequestCount > 0)
            {
                var followRequestsAlert = new AlertItem(followRequestCount);
                metroPanel.Controls.Add(followRequestsAlert);
                followRequestsAlert.Dock = DockStyle.Top;
            }
        }
    }
}
