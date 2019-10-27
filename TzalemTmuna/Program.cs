using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TzalemTmuna.DB;
using TzalemTmuna.Entities;
using TzalemTmuna.Forms;

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

            var styleManager = new MetroFramework.Components.MetroStyleManager();
            styleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            styleManager.Style = MetroFramework.MetroColorStyle.Teal;

            //Check Auto Login

            string autoUsername = Properties.Settings.Default.username;
            string autoPassword = Properties.Settings.Default.password;
            if (autoUsername != string.Empty && autoPassword != string.Empty)
            {
                var udb = new UserDB();
                if (udb.Find(autoUsername))
                {
                    DoLoginAuto(new LoginUser(udb.GetCurrentRow()), autoPassword,styleManager);
                }
                else
                {
                    //Can't find user in auto settings, so delete auto settings
                    Properties.Settings.Default.username = string.Empty;
                    Properties.Settings.Default.password = string.Empty;
                    Properties.Settings.Default.Save();
                    Application.Run(new Login(styleManager));
                }
            }
            else
            {
                Application.Run(new Login(styleManager));
            }
        }

        private static void DoLoginAuto(LoginUser user, string password, MetroFramework.Components.MetroStyleManager styleManager)
        {
            if (user.Password.Equals(password))
            {
                Application.Run(new Profile(styleManager, user, null));
            }
            else
            {
                //Can't login user in auto settings, so delete auto settings
                Properties.Settings.Default.username = string.Empty;
                Properties.Settings.Default.password = string.Empty;
                Properties.Settings.Default.Save();
                Application.Run(new Login(styleManager));
            }
        }
    }
}
