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
            if (MetroFramework.MetroMessageBox.Show(this,"A restart is required for changes to take place, do you wish to restart TzalemTmuna?","Changing the theme", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
    }
}
