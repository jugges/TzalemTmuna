using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using TzalemTmuna.DB;
using TzalemTmuna.Utilities;
using TzalemTmuna.Entities;

namespace TzalemTmuna.Forms
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        MetroFramework.Components.MetroStyleManager styleManager;
        public Login(MetroFramework.Components.MetroStyleManager styleManager)
        {
            InitializeComponent();
            styleManager.Owner = this;
            StyleManager = styleManager;
            this.styleManager = styleManager;
        }

        private void LoginError()
        {
            MetroFramework.MetroMessageBox.Show(this, "Username/Email and/or password is not valid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateTools.IsEmail(txtUsername.Text))
            {
                var edb = new EmailDB();
                if (edb.Find(txtUsername.Text))
                {
                    DoLogin(new LoginUser(edb.GetCurrentRow()));
                }
                else
                    LoginError();
            }
            else if (ValidateTools.IsUsername(txtUsername.Text))
            {
                var udb = new UserDB();
                if (udb.Find(txtUsername.Text))
                {
                    DoLogin(new LoginUser(udb.GetCurrentRow()));
                }
                else
                    LoginError();
            }
            else
                LoginError();
        }

        private void DoLogin(LoginUser user)
        {
            if (PasswordTools.Match(user, txtPassword.Text))
            {
                var profile = new Profile(styleManager,user,this);
                profile.Show();
                Hide();
                //profile.Closed += (s, args) => Location = profile.Location;
                //profile.Closed += (s, args) => Show();
                profile.Closed += (s, args) => Close();
            }
            else
                LoginError();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //    nirgolan4,gayboy
            //    udirubin8,uduman
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var register = new Register(styleManager);
            register.Location = Location;
            register.Show();
            Hide();
            register.Closed += (s, args) => Location = register.Location;
            register.Closed += (s, args) => Show();
        }
    }
}
