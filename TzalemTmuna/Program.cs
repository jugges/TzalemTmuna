using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TzalemTmuna.DB;
using TzalemTmuna.Forms;
using TzalemTmuna.Entities;

namespace TzalemTmuna
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Applying Theme
            if (Properties.Settings.Default.darkMode)
                Statics.Theme.metroThemeStyle = MetroFramework.MetroThemeStyle.Dark;
            else
                Statics.Theme.metroThemeStyle = MetroFramework.MetroThemeStyle.Light;

            Statics.Theme.metroColorStyle = Properties.Settings.Default.accentColor;
            //Check Auto Login

            string autoUsername = Properties.Settings.Default.username;
            string autoPassword = Properties.Settings.Default.password;
            if (autoUsername != string.Empty && autoPassword != string.Empty)
            {
                var udb = new UserDB();
                if (udb.Find(autoUsername))
                {
                    DoLoginAuto(new LoginUser(udb.GetCurrentRow()), autoPassword);
                }
                else
                {
                    //Can't find user in auto settings, so delete auto settings
                    Properties.Settings.Default.username = string.Empty;
                    Properties.Settings.Default.password = string.Empty;
                    Properties.Settings.Default.Save();
                    LoadLoginForm();
                }
            }
            else
            {
                LoadLoginForm();
            }
        }

        private static void LoadLoginForm()
        {
            Statics.LoggedInUser.loginPage = new Login();
            Statics.LoggedInUser.feed = new Feed();
            Statics.LoggedInUser.loginPage.Show();
            Application.Run(Statics.LoggedInUser.feed);
        }

        private static void DoLoginAuto(LoginUser user, string password)
        {
            if (user.Password.Equals(password) && user.GetBanText() == string.Empty)
            {
                Statics.LoggedInUser.login = user;
                Statics.LoggedInUser.loginPage = new Login();
                Statics.LoggedInUser.profile = new Profile();

                Statics.LoggedInUser.feed = new Feed();
                Statics.LoggedInUser.feed.ResetMe();
                Application.Run(Statics.LoggedInUser.feed);

                //Application.Run(Statics.LoggedInUser.profile);
            }
            else
            {
                //Can't login user in auto settings, so delete auto settings
                Properties.Settings.Default.username = string.Empty;
                Properties.Settings.Default.password = string.Empty;
                Properties.Settings.Default.Save();
                //Check if failed because banned
                if (user.GetBanText() != string.Empty)
                {
                    var msg = new MetroFramework.Forms.MetroForm();
                    msg.Size = new System.Drawing.Size(500, 150);
                    msg.Show();
                    MetroFramework.MetroMessageBox.Show(msg, "Sorry " + user.Username + ",\rBut your account is banned.\r\rBan reason:\r" + user.GetBanText(), "User is banned", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    msg.Close();
                }
                LoadLoginForm();
            }
            //DISABLED FOR FEED!!!
            //Login after user closes window
            //Application.Run(new Login());
        }
    }
}
