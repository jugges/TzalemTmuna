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
    public partial class EditProfile : MetroFramework.Forms.MetroForm
    {
        Bitmap pic;
        public EditProfile()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            chkPrivateAccount.Checked = LoggedInUser.login.is_private;
            txtFullName.Text = LoggedInUser.login.Full_name;
            txtWebsite.Text = LoggedInUser.login.External_url;
            txtBiography.Text = LoggedInUser.login.Biography;
            txtUsername.Text = LoggedInUser.login.Username;
            txtEmail.Text = LoggedInUser.login.Email;
            ProfilePicture.BackColor = BackColor;
            var pic = FileTools.getProfilePicture(LoggedInUser.login.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }
            this.pic = (Bitmap)ProfilePicture.Image;
            //lblChangeProfilePicture.Parent = ProfilePicture;
            //lblChangeProfilePicture.Location = new Point(ProfilePicture.Width / 2 - lblChangeProfilePicture.Width / 2, ProfilePicture.Height / 2);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool[] flagSave = new bool[6];
            bool flagError = false;
            FileTools.saveProfilePicture(LoggedInUser.login.Username, pic);
            var udp = new UserDB();
            if (!txtUsername.Text.Equals(LoggedInUser.login.Username))
                if (ValidateTools.IsUsername(txtUsername.Text))
                {
                    if (!udp.Find(txtUsername.Text))
                    {
                        flagSave[0] = true;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Someone else is using that username!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flagError = true;
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Username is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flagError = true;
                }

            if (!txtEmail.Text.Equals(LoggedInUser.login.Email))
                if (ValidateTools.IsEmail(txtEmail.Text))
                {
                    var edp = new EmailDB();
                    if (!edp.Find(txtEmail.Text))
                    {
                        flagSave[1] = true;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Someone else is using that email address!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flagError = true;
                    }
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Email address is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flagError = true;
                }

            if (!txtWebsite.Text.Equals(LoggedInUser.login.External_url) && txtWebsite.Text != string.Empty)
                if (ValidateTools.IsURL(txtWebsite.Text))
                {
                    flagSave[2] = true;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Website URL address is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flagError = true;
                }

            if (!txtBiography.Text.Equals(LoggedInUser.login.Biography) && txtBiography.Text != string.Empty)
            {
                flagSave[3] = true;
            }

            if (!txtFullName.Text.Equals(LoggedInUser.login.Full_name))
            {
                flagSave[4] = true;
            }

            if (chkPrivateAccount.Checked ^ LoggedInUser.login.is_private)
            {
                flagSave[5] = true;
            }

            if (!flagError)
            {
                if (flagSave.Contains(true))
                {
                    var instance = DAL.GetInstance();
                    string statement = "UPDATE users SET";
                    List<OleDbParameter> parameters = new List<OleDbParameter>();
                    bool flagFirst = true;
                    if (flagSave[1])
                    {
                        statement += " [email]=@email";
                        parameters.Add(new OleDbParameter("@email", txtEmail.Text));
                        flagFirst = false;
                        LoggedInUser.login.Email = txtEmail.Text;
                    }
                    if (flagSave[2])
                    {
                        if (flagFirst)
                        {
                            statement += " ";
                            flagFirst = false;
                        }
                        else
                            statement += ", ";
                        statement += "[external_url]=@external_url";
                        parameters.Add(new OleDbParameter("@external_url", txtWebsite.Text));
                        LoggedInUser.login.External_url = txtWebsite.Text;
                    }
                    if (flagSave[3])
                    {
                        if (flagFirst)
                        {
                            statement += " ";
                            flagFirst = false;
                        }
                        else
                            statement += ", ";
                        statement += "[biography]=@biography";
                        parameters.Add(new OleDbParameter("@biography", txtBiography.Text));
                        LoggedInUser.login.Biography = txtBiography.Text;
                    }
                    if (flagSave[4])
                    {
                        if (flagFirst)
                        {
                            statement += " ";
                            flagFirst = false;
                        }
                        else
                            statement += ", ";
                        statement += "[full_name]=@full_name";
                        parameters.Add(new OleDbParameter("@full_name", txtFullName.Text));
                        LoggedInUser.login.Full_name = txtFullName.Text;
                    }
                    if (flagSave[5])
                    {
                        if (flagFirst)
                        {
                            statement += " ";
                            flagFirst = false;
                        }
                        else
                            statement += ", ";
                        statement += "[is_private]=@is_private";
                        parameters.Add(new OleDbParameter("@is_private", chkPrivateAccount.Checked));
                        LoggedInUser.login.is_private = chkPrivateAccount.Checked;
                    }
                    if (flagSave[0])
                    {
                        if (flagFirst)
                            statement += " ";
                        else
                            statement += ", ";
                        parameters.Add(new OleDbParameter("@username", txtUsername.Text));
                        parameters.Add(new OleDbParameter("@oldusername", LoggedInUser.login.Username));
                        instance.ExecuteNonQuery(statement +
                            "[username]=@username WHERE [username]=@oldusername", parameters);
                        FileTools.ChangeUsername(LoggedInUser.login.Username, txtUsername.Text);
                        LoggedInUser.login.Username = txtUsername.Text;
                    }
                    else
                    {
                        parameters.Add(new OleDbParameter("@username", LoggedInUser.login.Username));
                        instance.ExecuteNonQuery(statement +
                                " WHERE [username]=@username",parameters);
                    }
                    udp.UpdateRow(LoggedInUser.login);
                    //udp.Save();
                }
                Close();
            }
        }

        public void openProfile()
        {
            new Profile(null).Show();
        }

        private void ProfilePicture_MouseLeave(object sender, EventArgs e)
        {
            ProfilePicture.Image = pic;
            lblChangeProfilePicture.Hide();
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            var pic = FileTools.setProfilePicture();
            if (pic != null)
            {
                ProfilePicture.Image = pic;
                this.pic = pic;
            }
        }

        private void ProfilePicture_MouseEnter(object sender, EventArgs e)
        {
            ProfilePicture.Image = ImageTools.SetImageOpacity(pic, 0.2f);
            lblChangeProfilePicture.Show();
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
