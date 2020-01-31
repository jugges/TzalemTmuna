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
    public partial class NewReport : MetroFramework.Forms.MetroForm
    {
        int postId = -1;
        public NewReport()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
        }
        public NewReport(int postId)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };

            lblReportType.Text = "Describe what's inappropriate about this post:";
            this.postId = postId;
        }

        private void SubmitReport(object sender, EventArgs e)
        {
            if (TextTools.StripWhitespace(txtText.Text) != string.Empty)
            {
                bool alreadyReported = false;
                foreach (Report x in LoggedInUser.login.Reports)
                {
                    if (x.Post_id != -1 && x.Post_id == postId)
                    {
                        alreadyReported = true;
                        break;
                    }
                }
                if (!alreadyReported)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Confirm submission of report \"" + txtText.Text + "\"", "Submit Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DateTime creation_date = DateTime.Now;
                        //Add Report to Database
                        DAL.GetInstance().ExecuteNonQuery("INSERT INTO reports " +
                            "([post_id], [report_text], [owner], [creation_date]) " +
                            "VALUES(@post_id, @report_text, @owner, @creation_date)", new OleDbParameter[]
                            {
                                    new OleDbParameter("@post_id", postId),
                                    new OleDbParameter("@report_text", txtText.Text),
                                    new OleDbParameter("@owner", LoggedInUser.login.Username),
                                    new OleDbParameter("@creation_date", creation_date.ToString("MM/dd/yyyy HH:mm:ss"))
                            });
                        //Retrieve AutoNumber report_id from Database
                        int report_id = (int)DAL.GetInstance().ExecuteScalarQuery("SELECT [report_id] FROM reports ORDER BY [report_id] DESC");
                        //Create report object
                        var report = new Report(report_id, postId, txtText.Text, new User(LoggedInUser.login), creation_date);
                        //Add report to DataSet
                        new ReportDB().AddRow(report);
                        //Add report to users's report list
                        LoggedInUser.login.Reports.Add(report);
                        //Close NewReport dialog and set DialogResult
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "You already reported this post, to create a new report for this post delete your previous report!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
                    {
                        Close();
                    }
                }
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Report body cannot be empty!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }
    }
}
