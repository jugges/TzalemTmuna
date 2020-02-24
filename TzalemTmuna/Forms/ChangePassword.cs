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
using System.Net.Mail;
using System.Net;
using System.Security.Cryptography;

namespace TzalemTmuna.Forms
{
    public partial class ChangePassword : MetroFramework.Forms.MetroForm
    {
        public ChangePassword()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (TextTools.IsPassword(txtNewPassword.Text))
            {
                if (txtPasswordValidate.Text.Equals(txtNewPassword.Text))
                {
                    //Change password and generate new salt in dataset
                    UserDB udb = new UserDB();
                    udb.Find(LoggedInUser.login.Username);
                    udb.GetCurrentRow()["salt"] = PasswordTools.GetSalt();
                    udb.GetCurrentRow()["password"] = PasswordTools.HashSha256(txtNewPassword.Text, udb.GetCurrentRow()["salt"].ToString());
                    //Change password and salt
                    LoggedInUser.login.ChangePassword(udb.GetCurrentRow()["password"].ToString(), udb.GetCurrentRow()["salt"].ToString());
                    //Add user to Database
                    DAL.GetInstance().ExecuteNonQuery("UPDATE [users] SET [salt] = @salt, [password] = @password WHERE [username] = @username", new OleDbParameter[]
                            {
                                    new OleDbParameter("@salt", udb.GetCurrentRow()["salt"].ToString()),
                                    new OleDbParameter("@password", udb.GetCurrentRow()["password"].ToString()),
                                    new OleDbParameter("@username", LoggedInUser.login.Username)
                            });
                    MetroFramework.MetroMessageBox.Show(this, "New Password is set!", "Password Changed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Passwords dont match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "New Password is invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
