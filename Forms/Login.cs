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
using TzalemTmuna.Entities;

namespace TzalemTmuna.Forms
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            if (Regex.IsMatch(txtUsername.Text, @"^[\d\w]+@[\d\w]+\.[\w]+$"))
            {
                var edb = new EmailDB();
                if (edb.Find(txtUsername.Text))
                {
                    DoLogin(edb.GetCurrentRow());
                }
                else
                    throw new Exception("Username/Email and/or password is not valid");
            }
            else if (Regex.IsMatch(txtUsername.Text, @"^[a-zA-Z0-9_]+$") && txtUsername.Text.Length <= 12)
            {
                var udb = new UserDB();
                if (udb.Find(txtUsername.Text))
                {
                    DoLogin(udb.GetCurrentRow());
                }
                else
                    throw new Exception("Username/Email and/or password is not valid");
            }
            else
                throw new Exception("Username/Email and/or password is not valid");
        }

        private void DoLogin(User user)
        {
            var pdb = new PasswordDB();
            if (pdb.Match(user, txtPassword.Text))
                MessageBox.Show("Connecting!");
            else
                throw new Exception("Username/Email and/or password is not valid");
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //    nirgolan4,gayboy
            //    udirubin8,uduman
        }
    }
}
