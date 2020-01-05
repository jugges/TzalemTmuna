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
                Theme = Statics.Theme.MetroThemeStyle
            };
        }
        public NewReport(int postId)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };

            lblReportType.Text = "Describe what's inappropriate about this post:";
            this.postId = postId;
        }

        private void SubmitReport(object sender, EventArgs e)
        {
            if (TextTools.StripWhitespace(txtText.Text)==string.Empty)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Report body cannot be empty!", "Error!", MessageBoxButtons.OKCancel,MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
            else if (MetroFramework.MetroMessageBox.Show(this, "Confirm submission of report \"" + txtText.Text + "\"", "Submit Report", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Add Report to Database
                DAL.GetInstance().ExecuteNonQuery("INSERT INTO reports " +
                    "([post_id], [report_text], [owner], [creation_date]) " +
                    "VALUES(@post_id, @report_text, @owner, @creation_date)", new OleDbParameter[]
                    {
                                    new OleDbParameter("@post_id", postId),
                                    new OleDbParameter("@report_text", txtText.Text),
                                    new OleDbParameter("@owner", LoggedInUser.login.Username),
                                    new OleDbParameter("@creation_date", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"))
                    });
                //Close NewReport dialog
                Close();
            }
        }
    }
}
