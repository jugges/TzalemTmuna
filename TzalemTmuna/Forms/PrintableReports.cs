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
    public partial class PrintableReports : MetroFramework.Forms.MetroForm
    {
        public PrintableReports()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
        }

        private void PrintableReports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tzalemtmunaDataSet.reports' table. You can move, or remove it, as needed.
            reportsTableAdapter.Fill(tzalemtmunaDataSet.reports);
            usersTableAdapter.Fill(tzalemtmunaDataSet.users);
            postsTableAdapter.Fill(tzalemtmunaDataSet.posts);
            commentsTableAdapter.Fill(tzalemtmunaDataSet.comments);
            reportViewer1.RefreshReport();
            reportViewer2.RefreshReport();
            reportViewer3.RefreshReport();
            reportViewer4.RefreshReport();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFilterReports_Click(object sender, EventArgs e)
        {
            string owner = TextTools.StripWhitespace(txtFilterReports.Text);
            if (owner == string.Empty)
                reportsTableAdapter.Fill(tzalemtmunaDataSet.reports);
            else
                reportsTableAdapter.FillBy(tzalemtmunaDataSet.reports, owner);
            reportViewer1.RefreshReport();
        }

        private void btnFilterPosts_Click(object sender, EventArgs e)
        {
            string owner = TextTools.StripWhitespace(txtFilterPosts.Text);
            if (owner == string.Empty)
                postsTableAdapter.Fill(tzalemtmunaDataSet.posts);
            else
                postsTableAdapter.FillBy(tzalemtmunaDataSet.posts, owner);
            reportViewer3.RefreshReport();
        }

        private void btnFilterComments_Click(object sender, EventArgs e)
        {
            string owner = TextTools.StripWhitespace(txtFilterComments.Text);
            if (owner == string.Empty)
                commentsTableAdapter.Fill(tzalemtmunaDataSet.comments);
            else
                commentsTableAdapter.FillBy(tzalemtmunaDataSet.comments, owner);
            reportViewer4.RefreshReport();
        }
    }
}
