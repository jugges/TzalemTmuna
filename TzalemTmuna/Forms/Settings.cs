﻿using System;
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
    public partial class Settings : MetroFramework.Forms.MetroForm
    {
        public Settings()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            tDarkMode.Checked = Properties.Settings.Default.darkMode;
            //Add handler only now so previous change won't pop up a messagebox
            tDarkMode.CheckedChanged += new EventHandler(tDarkMode_CheckedChanged);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = string.Empty;
            Properties.Settings.Default.password = string.Empty;
            Properties.Settings.Default.Save();
            LoggedInUser.loginPage = new Login();
            LoggedInUser.loginPage.Show();
            Close();
        }

        private void tDarkMode_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.darkMode = tDarkMode.Checked;
            Properties.Settings.Default.Save();
            if (MetroFramework.MetroMessageBox.Show(this, "A restart is required for changes to take place, do you wish to restart TzalemTmuna?", "Changing the theme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            foreach (Report x in LoggedInUser.login.Reports)
            {
                AddReportToGrid(x);
            }
        }

        private void AddReportToGrid(Report x)
        {
            Bitmap reportedPost;
            string closing_date = x.Closing_date == DateTime.MinValue ? string.Empty : x.Closing_date.ToString("MM/dd/yyyy HH:mm:ss");
            if (x.Post_id != -1)
            {
                reportedPost = ImageTools.ResizeImage(FileTools.getPost(x.Post_id), 150, 150);
                grdMyReports.Rows.Add(x.Report_id, x.Post_id, reportedPost, x.Report_text, x.Creation_date, closing_date);
            }
            else
            {
                grdMyReports.Rows.Add(x.Report_id, x.Post_id, null, x.Report_text, x.Creation_date, closing_date);
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            if (new NewReport().ShowDialog() == DialogResult.OK)
            {
                AddReportToGrid(LoggedInUser.login.Reports.Last());
            }
        }

        private void grdMyReports_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                if (grdMyReports.Rows[e.RowIndex].Cells[1].Value.ToString() != "-1")
                {
                    new ViewPost(new PostDB().GetPost(int.Parse(grdMyReports.Rows[e.RowIndex].Cells[1].Value.ToString()))).ShowDialog();
                }
            }
            else
            {
                if (new ViewReport(new ReportDB().GetReport(int.Parse(grdMyReports.Rows[e.RowIndex].Cells[0].Value.ToString()))).ShowDialog() == DialogResult.OK)
                {
                    grdMyReports.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new ReportDB().GetReport(int.Parse(grdMyReports.Rows[grdMyReports.SelectedRows[0].Index].Cells[0].Value.ToString()));
            if (MetroFramework.MetroMessageBox.Show(this, "Confirm deletion of report \"" + report.Report_text + "\"", "Delete Report", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new ReportDB().RemoveReport(report.Report_id);
                LoggedInUser.login.Reports.Remove(report);
                //Report was deleted
                grdMyReports.Rows.RemoveAt(grdMyReports.SelectedRows[0].Index);
            }
        }
    }
}