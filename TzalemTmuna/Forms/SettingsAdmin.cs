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
    public partial class SettingsAdmin : MetroFramework.Forms.MetroForm
    {
        bool changedTheme = false;
        bool changedStyleColor = false;
        public SettingsAdmin()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
            cbAccentColor.SelectedItem = Properties.Settings.Default.accentColor.ToString();
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
            //XOR
            changedTheme = Properties.Settings.Default.darkMode ^ tDarkMode.Checked;
        }

        private void grdReports_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1) // If clicked on a report and not on header
            {
                Report report = new ReportDB().GetReport((int)grdReports.Rows[e.RowIndex].Cells[0].Value);
                if (e.ColumnIndex == 1)
                {
                    if (report.Owner.Username == LoggedInUser.login.Username)
                        LoggedInUser.profile.Show();
                    else
                        new Profile(report.Owner).ShowDialog();
                }
                else if (e.ColumnIndex == 5 && report.Content_type != 0) //Clicked content and report has content
                {
                    if (report.Content_type == 1)
                    {
                        new ViewPost(new PostDB().GetPost(int.Parse(report.Content_id))).ShowDialog();
                    }
                    else if (report.Content_type == 2)
                    {
                        new ViewPost(new PostDB().GetPost(new CommentDB().GetComment(int.Parse(report.Content_id)).Post_id)).ShowDialog();
                    }
                    else
                    {
                        new Profile(new UserDB().GetUser(report.Content_id)).ShowDialog();
                    }
                }
                else
                {
                    if (new ViewReport(report).ShowDialog() == DialogResult.OK)
                    {
                        //Update report in grid to closed
                        report = new ReportDB().GetReport(report.Report_id);
                        grdReports.Rows[e.RowIndex].Cells[4].Value = report.Closing_date.ToString("MM/dd/yyyy HH:mm:ss");
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (grdReports.Rows[grdReports.SelectedRows[0].Index].Cells[4].Value.ToString() == string.Empty)
            {
                Report report = new ReportDB().GetReport(int.Parse(grdReports.Rows[grdReports.SelectedRows[0].Index].Cells[0].Value.ToString()));
                if (new CloseReport(report).ShowDialog() == DialogResult.OK)
                {
                    //Update report in grid to closed
                    report = new ReportDB().GetReport(report.Report_id);
                    grdReports.Rows[grdReports.SelectedRows[0].Index].Cells[4].Value = report.Closing_date.ToString("MM/dd/yyyy HH:mm:ss");
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(this, "The report you are trying to close is already closed...", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbAccentColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbAccentColor.SelectedItem)
            {
                case "Blue":
                    cbAccentColor.BackColor = MetroFramework.MetroColors.Blue;
                    break;
                case "Lime":
                    cbAccentColor.BackColor = MetroFramework.MetroColors.Lime;
                    break;
                case "Magenta":
                    cbAccentColor.BackColor = MetroFramework.MetroColors.Magenta;
                    break;
                case "Teal":
                    cbAccentColor.BackColor = MetroFramework.MetroColors.Teal;
                    break;
                case "Yellow":
                    cbAccentColor.BackColor = MetroFramework.MetroColors.Yellow;
                    break;
            }
            changedStyleColor = Properties.Settings.Default.accentColor.ToString() != cbAccentColor.SelectedItem.ToString();
            /**
             * Blue
             * Lime 
             * Magenta
             * Teal
             * Yellow
            **/
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (changedTheme || changedStyleColor)
            {
                if (changedTheme)
                {
                    Properties.Settings.Default.darkMode = tDarkMode.Checked;
                }
                if (changedStyleColor)
                {
                    //enum parser
                    Properties.Settings.Default.accentColor = (MetroFramework.MetroColorStyle)System.Enum.Parse(typeof(MetroFramework.MetroColorStyle), cbAccentColor.SelectedItem.ToString());
                }
                Properties.Settings.Default.Save();
                if (MetroFramework.MetroMessageBox.Show(this, "A restart is required for changes to take place, do you wish to restart TzalemTmuna?", "Changing the Theme", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Restart();
                    Environment.Exit(0);
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var changePassword = new ChangePassword();
            changePassword.ShowDialog();
        }

        private void SettingsAdmin_Load(object sender, EventArgs e)
        {
            //Load reports analysis
            ReportDB rdb = new ReportDB();
            foreach (Report x in rdb.GetReports())
            {
                //Plot report to graph

                //Is graph empty?
                //OR
                //Is last point not plotted on the same date as this report's date?
                if (chart1.Series[0].Points.Count == 0 || DateTime.FromOADate(chart1.Series[0].Points.Last().XValue) != x.Creation_date.Date)
                {
                    chart1.Series[0].Points.AddXY(x.Creation_date.Date, 1);
                }
                else
                {

                    chart1.Series[0].Points.Last().YValues[0] += 1;
                }
                if (x.Closing_date != DateTime.MinValue)
                    if (chart1.Series[1].Points.Count == 0 || DateTime.FromOADate(chart1.Series[1].Points.Last().XValue) != x.Closing_date.Date)
                    {
                        chart1.Series[1].Points.AddXY(x.Closing_date.Date, 1);
                    }
                    else
                    {
                        chart1.Series[1].Points.Last().YValues[0] += 1;
                    }

                //Load report to grid
                string closing_date = x.Closing_date == DateTime.MinValue ? string.Empty : x.Closing_date.ToString("MM/dd/yyyy HH:mm:ss");

                //Warning, ternary heaven (or dare I say hell) below...
                grdReports.Rows.Add(x.Report_id, x.Owner.Username, x.Report_text, x.Creation_date, closing_date,
                    (x.Content_type == 0 ?
                        (Statics.Theme.metroThemeStyle == MetroFramework.MetroThemeStyle.Light ?
                        Properties.Light.lightNoContentReport : Properties.Dark.darkNoContentReport
                        ) :
                            (x.Content_type == 1 ?
                            ImageTools.ResizeImage(FileTools.getPost(int.Parse(x.Content_id)), 96, 96) :
                                (x.Content_type == 2 ? 
                                    (Statics.Theme.metroThemeStyle == MetroFramework.MetroThemeStyle.Light ?
                                       Properties.Light.lightCommentReport : Properties.Dark.darkCommentReport
                                    ) :
                                        (Statics.Theme.metroThemeStyle == MetroFramework.MetroThemeStyle.Light ?
                                        Properties.Light.lightUser : Properties.Dark.darkUser
                                        )
                                )
                            )
                    ), x.Content_id
                );
            }

            //Load posts page

            //Load users page

        }
    }
}
