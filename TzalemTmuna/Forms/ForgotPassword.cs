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
    public partial class ForgotPassword : MetroFramework.Forms.MetroForm
    {
        string passwordResetCode = "";
        string emailAddress;
        public ForgotPassword()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
        }
        //Generates a random 8 digits Password Reset Code
        private void GeneratePRC()
        {
            string rnd = "";
            Random random = new Random();
            for (int i = 0; i < 8; i++)
            {
                rnd += random.Next(0, 10).ToString();
            }
            passwordResetCode = rnd;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Check whether password reset service email is configured
            if (TextTools.StripWhitespace(Properties.Settings.Default.emailForgotPassword) != string.Empty
                && Properties.Settings.Default.emailForgotPassword != "changeme@email.com"
                && TextTools.StripWhitespace(Properties.Settings.Default.passwordForgotPassword) != string.Empty)
            {
                //Lowercase email to mitigate case typos
                emailAddress = txtEmail.Text.ToLower();
                EmailDB edb = new EmailDB();
                if (TextTools.IsEmail(emailAddress))
                {
                    if (edb.Find(emailAddress))
                    {

                        var fromAddress = new MailAddress(Properties.Settings.Default.emailForgotPassword, "TzalemTmuna");
                        var toAddress = new MailAddress(emailAddress);
                        string fromPassword = Properties.Settings.Default.passwordForgotPassword;
                        const string subject = "TzalemTmuna - Password Recovery Code";

                        GeneratePRC();

                        var smtp = new SmtpClient
                        {
                            Host = "smtp.gmail.com",
                            Port = 587,
                            EnableSsl = true,
                            DeliveryMethod = SmtpDeliveryMethod.Network,
                            Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                            Timeout = 20000
                        };
                        using (var message = new MailMessage(fromAddress, toAddress)
                        {
                            Subject = subject,
                            Body = passwordResetCode
                        })
                        {
                            try
                            {
                                smtp.Send(message);
                                MetroFramework.MetroMessageBox.Show(this, "Password Recovery Code is being sent to \"" + emailAddress + "\",\rreturn here with the code and continue the process.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception exc) //Can't connect using creds to gmail so notify user to report to admins
                            {
                                MetroFramework.MetroMessageBox.Show(this, "Can't connect to the password recovery service,\rplease let the admins know by filing a report in the settings.\r\rPass this error in the report:\r" + exc.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Password Recovery Code is being sent to \"" + emailAddress + "\",\rreturn here with the code and continue the process.", "Forgot Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "Email is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Can't connect to the password recovery service!\r\rPlease let the admins know by filing a report in the settings.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (passwordResetCode.Equals(txtPRC.Text))
            {
                if (TextTools.IsPassword(txtNewPassword.Text))
                {
                    if (txtPasswordValidate.Text.Equals(txtNewPassword.Text))
                    {
                        //Change password in dataset
                        EmailDB edb = new EmailDB();
                        edb.Find(emailAddress);
                        edb.GetCurrentRow()["salt"] = PasswordTools.GetSalt();
                        edb.GetCurrentRow()["password"] = PasswordTools.HashSha256(txtNewPassword.Text, edb.GetCurrentRow()["salt"].ToString());
                        //Add user to Database
                        DAL.GetInstance().ExecuteNonQuery("UPDATE [users] SET [salt] = @salt, [password] = @password WHERE [email] = @email", new OleDbParameter[]
                                {
                                    new OleDbParameter("@salt", edb.GetCurrentRow()["salt"].ToString()),
                                    new OleDbParameter("@password", edb.GetCurrentRow()["password"].ToString()),
                                    new OleDbParameter("@email", emailAddress)
                                });
                        MetroFramework.MetroMessageBox.Show(this, "New Password is set, login to your account with new set password.", "Password Changed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        MetroFramework.MetroMessageBox.Show(this, "Passwords dont match!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MetroFramework.MetroMessageBox.Show(this, "New Password is invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MetroFramework.MetroMessageBox.Show(this, "Password Recovery Code is invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
