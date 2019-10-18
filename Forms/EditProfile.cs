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
    public partial class EditProfile : MetroFramework.Forms.MetroForm
    {
        LoginUser user;
        Image pic;
        public EditProfile(LoginUser user)
        {
            InitializeComponent();
            this.user = user;
            chkPrivateAccount.Checked = user.is_private;
            txtFullName.Text = user.Full_name;
            txtWebsite.Text = user.External_url;
            txtBiography.Text = user.Biography;
            txtUsername.Text = user.Username;
            txtEmail.Text = user.Email;
            ProfilePicture.BackColor = BackColor;
            var pic = FileTools.getProfilePicture(user.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }
            this.pic = ProfilePicture.Image;
            lblChangeProfilePicture.Parent = ProfilePicture;
            lblChangeProfilePicture.Location = new Point(ProfilePicture.Width / 2 - lblChangeProfilePicture.Width / 2, ProfilePicture.Height / 2);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            bool flagSave = false;
            bool flagError = false;
            FileTools.saveProfilePicture(user.Username, pic);
            var udp = new UserDB();
            if (!txtUsername.Text.Equals(user.Username))
                if (ValidateTools.IsUsername(txtUsername.Text))
                {
                    if (!udp.Find(txtUsername.Text))
                    {
                        FileTools.ChangeUsername(user.Username, txtUsername.Text);
                        user.Username = txtUsername.Text;
                        udp.UpdateRow(user);
                        flagSave = true;
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

            if (!txtEmail.Text.Equals(user.Email))
                if (ValidateTools.IsEmail(txtEmail.Text))
                {
                    var edp = new EmailDB();
                    if (!edp.Find(txtEmail.Text))
                    {
                        user.Email = txtEmail.Text;
                        udp.UpdateRow(user);
                        flagSave = true;
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

            if (!txtWebsite.Text.Equals(user.External_url))
                if (ValidateTools.IsURL(txtWebsite.Text))
                {
                    user.External_url = txtWebsite.Text;
                    udp.UpdateRow(user);
                    flagSave = true;
                }
                else
                {
                    MetroFramework.MetroMessageBox.Show(this, "Website URL address is not valid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    flagError = true;
                }

            if (!txtBiography.Text.Equals(user.Biography))
            {
                user.External_url = txtWebsite.Text;
                udp.UpdateRow(user);
                flagSave = true;
            }

            if (!txtFullName.Text.Equals(user.Full_name))
            {
                user.Full_name = txtFullName.Text;
                udp.UpdateRow(user);
                flagSave = true;
            }

            if (chkPrivateAccount.Checked ^ user.is_private)
            {
                user.is_private = chkPrivateAccount.Checked;
                udp.UpdateRow(user);
                flagSave = true;
            }

            if (!flagError)
            {
                if (flagSave)
                    udp.Save();
                Close();
            }
        }

        private void ProfilePicture_MouseLeave(object sender, EventArgs e)
        {
            ProfilePicture.Image = pic;
            lblChangeProfilePicture.Hide();
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {
            var pic = FileTools.setProfilePicture(user.Username);
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
