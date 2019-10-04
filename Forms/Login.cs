using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TzalemTmuna.DB;
using TzalemTmuna.Entities;

namespace TzalemTmuna.Forms
{
    public partial class Login : Form
    {
        //color palette - https://colorhunt.co/palette/158293
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            var udb = new UserDB();
            if (udb.Find("udirubin8"))
            {
                User nir = udb.GetCurrentRow();
                List<User> l = nir.Following;
                MessageBox.Show(nir.Following[0].Username);
            }
        }
    }
}
