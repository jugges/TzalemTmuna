using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using TzalemTmuna.DB;
using TzalemTmuna.Utilities;
using TzalemTmuna.Entities;
using TzalemTmuna.Data;
using TzalemTmuna.Statics;

namespace TzalemTmuna.Forms
{
    public partial class ViewReport : MetroFramework.Forms.MetroForm
    {
        bool propertyOfLogin;
        Report report;
        public ViewReport(Report report)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };

            this.report = report;
            Text = "Report " + report.Report_id;
            lblText.Text = report.Report_text;
            lblUsername.Text = report.Owner.Username;

            //Check if login's report
            propertyOfLogin = report.Owner.Username == LoggedInUser.login.Username;
            if (propertyOfLogin)
            {

            }

            //Sometimes the post's description is bigger than form's size, so this fixes the issue
            //Added padding of 10px, I know hardcoded is bad but not so important as of right now
            int resize = lblText.Size.Width + 10 - (Size.Width - lblText.Location.X);
            if (resize > 0)
            {
                Size = new Size(Size.Width + resize, Size.Height);
            }
        }

        private void OpenProfile(object sender, EventArgs e)
        {
            if (propertyOfLogin)
            {
                LoggedInUser.profile.Show();
            }
            else
            {
                Profile newProfile = new Profile(report.Owner);
                newProfile.Show();
            }
        }

        private void DeleteReport(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Confirm deletion of report \"" + report.Report_text + "\"", "Delete Report", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new ReportDB().RemoveReport(report.Report_id);
                LoggedInUser.login.Reports.Remove(report);
                Close();
            }
        }
    }
}
