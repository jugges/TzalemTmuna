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
        public EditProfile(LoginUser user)
        {
            InitializeComponent();
            this.user = user;
            txtFullName.Text = user.Full_name;
            txtBiography.Text = user.Biography;
            profilePicture1.Image = FileTools.getProfilePicture(user.Username);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
        }

        private void btnProfilePicture_Click(object sender, EventArgs e)
        {
            var pic = FileTools.setProfilePicture(user.Username);
            if (pic != null)
                profilePicture1.Image = pic;
        }
    }
}
