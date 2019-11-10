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

            //Theme

            Statics.Theme.MetroThemeStyle = MetroFramework.MetroThemeStyle.Dark;

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
                    Application.Run(new Login());
                }
            }
            else
            {
                Application.Run(new Login());
            }
        }

        private static void DoLoginAuto(LoginUser user, string password)
        {
            if (user.Password.Equals(password))
            {
                Statics.LoggedInUser.login = user;
                Application.Run(new Profile(null));
            }
            else
            {
                //Can't login user in auto settings, so delete auto settings
                Properties.Settings.Default.username = string.Empty;
                Properties.Settings.Default.password = string.Empty;
                Properties.Settings.Default.Save();
            }
            Application.Run(new Login());
        }
    }
}
