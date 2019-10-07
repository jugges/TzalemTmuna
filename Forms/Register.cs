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

namespace TzalemTmuna.Forms
{
    public partial class Register : MetroFramework.Forms.MetroForm
    {

        public Register()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var udp = new UserDB();
            var edp = new EmailDB();
            if (ValidateTools.IsUsername(txtUsername.Text))
            {
                if (!udp.Find(txtUsername.Text))
                {
                    if (ValidateTools.IsEmail(txtEmail.Text))
                    {
                        if(!edp.Find(txtEmail.Text))
                        {
                            if (ValidateTools.IsPassword(txtPassword.Text))
                            {
                                if(txtPassword.Text == txtPasswordValidate.Text)
                                {
                                    var user = new User();
                                    user.Username = txtUsername.Text;
                                    user.Email = txtEmail.Text;
                                    var register = new OleDbCommand();
                                    register.s

                                    DAL.GetInstance().ExecuteNonQuery();
                                    udp.Save();
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
