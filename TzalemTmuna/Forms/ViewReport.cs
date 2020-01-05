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
            txtText.Text = report.Report_text;
            lblUsername.Text = report.Owner.Username;

            //Check if login's report
            propertyOfLogin = report.Owner.Username == LoggedInUser.login.Username;
            if (propertyOfLogin)
            {
                btnAction.Click += new EventHandler(DeleteReport);
                btnAction.Text = "Delete";
            }
            else
            {
                btnAction.Click += new EventHandler(CloseReport);
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

        private void CloseReport(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(this, "Confirm closing of report \"" + report.Report_text + "\"", "Close Report", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new ReportDB().CloseReport(report.Report_id);
                Close();
            }
        }
    }
}
