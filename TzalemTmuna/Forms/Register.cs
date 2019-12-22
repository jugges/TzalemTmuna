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
    public partial class Register : MetroFramework.Forms.MetroForm
    {
        public Register()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Lowercase username!
            txtUsername.Text = txtUsername.Text.ToLower();
            if (ValidateTools.IsUsername(txtUsername.Text))
            {
                var udp = new UserDB();
                if (!udp.Find(txtUsername.Text))
                {
                    if (ValidateTools.IsEmail(txtEmail.Text))
                    {
                        var edp = new EmailDB();
                        if (!edp.Find(txtEmail.Text))
                        {
                            if (ValidateTools.IsPassword(txtPassword.Text))
                            {
                                if (txtPassword.Text == txtPasswordValidate.Text)
                                {
                                    var user = new LoginUser(txtUsername.Text,txtEmail.Text,txtPassword.Text);

                                    //Add user to DataSet 
                                    udp.AddRow(user);
                                    //Add user to Database
                                    DAL.GetInstance().ExecuteNonQuery("INSERT INTO users " +
                                        "([username], [email], [salt], [password], [full_name]) " +
                                        "VALUES(@username, @email, @salt, @password, @username)", new OleDbParameter[]
                                        {
                                    new OleDbParameter("@username", user.Username),
                                    new OleDbParameter("@email", user.Email),
                                    new OleDbParameter("@salt", user.Salt),
                                    new OleDbParameter("@password", user.Password),
                                        });

                                    if (chkRememberMe.Checked)
                                    {
                                        Properties.Settings.Default.username = user.Username;
                                        Properties.Settings.Default.password = user.Password;
                                        Properties.Settings.Default.Save();
                                    }
                                    //Create a new pictures folder for user
                                    FileTools.CreateProfile(user.Username);

                                    LoggedInUser.login = user;
                                    var editProfile = new EditProfile();
                                    editProfile.Show();
                                    Hide();
                                    editProfile.Closed += (s, args) => editProfile.OpenProfileAfterRegister();
                                }
                                else
                                    MetroFramework.MetroMessageBox.Show(this, "Passwords dont match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                                MetroFramework.MetroMessageBox.Show(this, "Password is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                            MetroFramework.MetroMessageBox.Show(this, "Someone else is using that email address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Email address is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Someone else is using that username!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Username is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
