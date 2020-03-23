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
    public partial class AlertItem : MetroFramework.Controls.MetroUserControl
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
            lblAlertText.Text = requestCount>1?$"You have {requestCount} new follow requests!":"You have a new follow request!";

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
            lblAlertText.Text = alert.Alert_text;
            alert_id = alert.Alert_id;
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            var adb = new AlertDB();
            adb.RemoveAlert(alert_id);
            this.Parent.Controls.Remove(this);
        }

        private void AlertItem_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
