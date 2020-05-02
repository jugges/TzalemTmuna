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
        bool banUser = true;
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
                    //Show users tab
                    metroTabControl1.SelectTab(1);
                    foreach (DataGridViewRow r in grdUsers.Rows)
                    {
                        if (r.Cells[0].Value.ToString() == report.Owner.Username)
                        {
                            r.Selected = true;
                            break;
                        }
                    }
                }
                else if (e.ColumnIndex == 5 && report.Content_type != 0) //Clicked content and report has content
                {
                    if (report.Content_type == 1)
                    {
                        //Show posts tab
                        metroTabControl1.SelectTab(2);
                        foreach (DataGridViewRow r in grdPosts.Rows)
                        {
                            if (r.Cells[0].Value.ToString() == report.Content_id)
                            {
                                r.Selected = true;
                                break;
                            }
                        }
                    }
                    else if (report.Content_type == 2)
                    {
                        //Show comments tab
                        metroTabControl1.SelectTab(3);
                        foreach (DataGridViewRow r in grdComments.Rows)
                        {
                            if (r.Cells[0].Value.ToString() == report.Content_id)
                            {
                                r.Selected = true;
                                break;
                            }
                        }
                    }
                    else
                    {
                        //Show users tab
                        metroTabControl1.SelectTab(1);
                        foreach (DataGridViewRow r in grdUsers.Rows)
                        {
                            if (r.Cells[0].Value.ToString() == report.Content_id)
                            {
                                r.Selected = true;
                                break;
                            }
                        }
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
                if (new AdminRemoveForm(report).ShowDialog() == DialogResult.OK)
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

            //Load users page
            var udb = new UserDB();
            foreach (User u in udb.GetUsers())
            {
                grdUsers.Rows.Add(u.Username, u.Email, u.Full_name, u.is_private, u.is_admin, u.is_verified, u.Ban_text);
            }

            //Load posts page
            var pdb = new PostDB();
            foreach (Post p in pdb.GetPosts())
            {
                grdPosts.Rows.Add(p.Post_id, p.Owner.Username, p.Post_text, ImageTools.ResizeImage(FileTools.getPost(p.Post_id), 96, 96));
            }

            //Load comments page
            var cdb = new CommentDB();
            foreach (Comment c in cdb.GetComments())
            {
                grdComments.Rows.Add(c.Comment_id, c.Owner.Username, c.Comment_text, c.Post_id);
            }
        }

        private void grdUsers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var user = new UserDB().GetUser(grdUsers.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (user.Username == LoggedInUser.login.Username)
                    LoggedInUser.profile.Show();
                else
                    new Profile(user).ShowDialog();
            }
        }

        private void grdPosts_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var post = new PostDB().GetPost((int)grdPosts.Rows[e.RowIndex].Cells[0].Value);
                if (e.ColumnIndex == 1)
                {
                    //Show users tab
                    metroTabControl1.SelectTab(1);
                    foreach (DataGridViewRow r in grdUsers.Rows)
                    {
                        if (r.Cells[0].Value.ToString() == post.Owner.Username)
                        {
                            r.Selected = true;
                            break;
                        }
                    }
                }
                else
                {
                    new ViewPost(post).ShowDialog();
                }
            }
        }

        private void grdComments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                var comment = new CommentDB().GetComment((int)grdComments.Rows[e.RowIndex].Cells[0].Value);
                if (e.ColumnIndex == 1)
                {
                    //Show users tab
                    metroTabControl1.SelectTab(1);
                    foreach (DataGridViewRow r in grdUsers.Rows)
                    {
                        if (r.Cells[0].Value.ToString() == comment.Owner.Username)
                        {
                            r.Selected = true;
                            break;
                        }
                    }
                }
                else if (e.ColumnIndex == 3)
                {
                    //Show posts tab
                    metroTabControl1.SelectTab(2);
                    foreach (DataGridViewRow r in grdPosts.Rows)
                    {
                        if ((int)r.Cells[0].Value == comment.Post_id)
                        {
                            r.Selected = true;
                            break;
                        }
                    }
                }
                else
                {
                    new ViewPost(new PostDB().GetPost(comment.Post_id)).ShowDialog();
                }
            }
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Selected post tab
            if (metroTabControl1.SelectedIndex == 2)
            {
                Post post = new PostDB().GetPost((int)(grdPosts.Rows[grdPosts.SelectedRows[0].Index].Cells[0].Value));
                if (new AdminRemoveForm(post).ShowDialog() == DialogResult.OK)
                {
                    //Remove post in grid
                    grdPosts.Rows.Remove(grdPosts.Rows[grdPosts.SelectedRows[0].Index]);
                }
            }
            // Selected comments tab
            else
            {
                Comment comment = new CommentDB().GetComment((int)(grdComments.Rows[grdComments.SelectedRows[0].Index].Cells[0].Value));
                if (new AdminRemoveForm(comment).ShowDialog() == DialogResult.OK)
                {
                    //Remove comment in grid
                    grdComments.Rows.Remove(grdComments.Rows[grdComments.SelectedRows[0].Index]);
                }
            }
        }

        private void cmUsers_Opening(object sender, CancelEventArgs e)
        {
            if(grdUsers.Rows[grdUsers.SelectedRows[0].Index].Cells[6].Value.ToString() == "")
            {
                banUser = true;
                userActionToolStripMenuItem.Text = "Ban";
            }
            else
            {
                banUser = false;
                userActionToolStripMenuItem.Text = "Unban";
            }
        }

        private void userActionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User user = new UserDB().GetUser(grdUsers.Rows[grdUsers.SelectedRows[0].Index].Cells[0].Value.ToString());
            if (new AdminRemoveForm(user,banUser).ShowDialog() == DialogResult.OK)
            {
                //Update user ban_text in grid
                user = new UserDB().GetUser(user.Username);
                grdUsers.Rows[grdUsers.SelectedRows[0].Index].Cells[6].Value = user.Ban_text;
            }
        }
    }
}
