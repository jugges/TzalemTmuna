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
    public partial class CloseReport : MetroFramework.Forms.MetroForm
    {
        Report report;
        public CloseReport()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
        }
        public CloseReport(Report report)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };

            this.report = report;
        }

        private void Close(object sender, EventArgs e)
        {
            if (TextTools.StripWhitespace(txtText.Text) != string.Empty)
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Confirm closing of report \"" + report.Report_text + "\"", "Close Report", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new ReportDB().CloseReport(report.Report_id);
                    new AlertDB().NewAlert($"Your report:\n\r\"{report.Report_text}\"\n\r\n\rIs closed by an admin:\n\r\"{txtText.Text}\"", report.Owner);
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                if (MetroFramework.MetroMessageBox.Show(this, "Report closing description cannot be empty!", "Error!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                {
                    Close();
                }
            }
        }
    }
}
