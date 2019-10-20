using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            var styleManager = new MetroFramework.Components.MetroStyleManager();
            styleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            styleManager.Style = MetroFramework.MetroColorStyle.Teal;
            Application.Run(new Login(styleManager));
        }
    }
}
