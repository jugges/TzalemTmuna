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
        string content_id;
        int content_type = 0;
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
        public NewReport(int content_type, string content_id)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };

            this.content_id = content_id;
            this.content_type = content_type;

            string name = "post";
            switch (content_type)
            {
                case 2:
                    name = "comment";
                    break;
                case 3:
                    name = "user";
                    break;
            }

            lblReportType.Text = ($"Describe what's inappropriate about this "+name+":");
        }

        private void SubmitReport(object sender, EventArgs e)
        {
            if (TextTools.StripWhitespace(txtText.Text) != string.Empty)
            {
                bool alreadyReported = false;
                if (content_type != 0)
                {
                    foreach (Report x in LoggedInUser.login.Reports)
                    {
                        if (x.Content_id == content_id && x.Content_type == content_type)
                        {
                            alreadyReported = true;
                            break;
                        }
                    }
                }
                if (!alreadyReported)
                {
                    if (MetroFramework.MetroMessageBox.Show(this, "Confirm submission of report \"" + txtText.Text + "\"", "Submit Report", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DateTime creation_date = DateTime.Now;
                        //Add Report to Database
                        if (content_type == 0) //No content
                        {
                            DAL.GetInstance().ExecuteNonQuery("INSERT INTO reports " +
                                "([content_type], [report_text], [owner], [creation_date]) " +
                                "VALUES(@content_type, @report_text, @owner, @creation_date)", new OleDbParameter[]
                                {
                                    new OleDbParameter("@content_type", 0),
                                    new OleDbParameter("@report_text", txtText.Text),
                                    new OleDbParameter("@owner", LoggedInUser.login.Username),
                                    new OleDbParameter("@creation_date", creation_date.ToString("MM/dd/yyyy HH:mm:ss"))
                                });
                        }
                        else //Content
                        {
                            DAL.GetInstance().ExecuteNonQuery("INSERT INTO reports " +
                                "([content_type] ,[content_id], [report_text], [owner], [creation_date]) " +
                                "VALUES(@content_type ,@content_id, @report_text, @owner, @creation_date)", new OleDbParameter[]
                                {
                                    new OleDbParameter("@content_type", content_type),
                                    new OleDbParameter("@content_id", content_id),
                                    new OleDbParameter("@report_text", txtText.Text),
                                    new OleDbParameter("@owner", LoggedInUser.login.Username),
                                    new OleDbParameter("@creation_date", creation_date.ToString("MM/dd/yyyy HH:mm:ss"))
                                });
                        }
                        //Retrieve AutoNumber report_id from Database
                        int report_id = (int)DAL.GetInstance().ExecuteScalarQuery("SELECT [report_id] FROM reports ORDER BY [report_id] DESC");
                        //Create report object
                        Report report;
                        if (content_type == 0) //No content
                        {
                            report = new Report(report_id, txtText.Text, new User(LoggedInUser.login), creation_date);
                        }
                        else //Content
                        {
                            report = new Report(report_id, content_type, content_id, txtText.Text, new User(LoggedInUser.login), creation_date);
                        }
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
                    if (MetroFramework.MetroMessageBox.Show(this, $"You have already reported this {(content_type == 1 ? "post" : (content_type == 2 ? "comment" : "user"))}. to create a new report, please delete your previous report!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error) == DialogResult.OK)
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
