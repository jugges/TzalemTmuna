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
    public partial class ViewPost : MetroFramework.Forms.MetroForm
    {
        Post post;
        public ViewPost(Post post, MetroFramework.Forms.MetroForm father)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            this.post = post;
            lblText.Text = post.Post_text;
            pbPhoto.Image = FileTools.getPost(post.Owner.Username,post.Post_number);
            if(father!=null)
                Closed += (s, args) => father.Show();
        }

        //public void openProfile()
        //{
        //    new Profile(user, null).Show();
        //}
    }
}
