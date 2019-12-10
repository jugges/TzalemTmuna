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
        Profile senderProfile;
        public ViewPost(Post post)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            this.post = post;
            lblText.Text = post.Post_text;
            pbPhoto.Image = FileTools.getPost(post.Owner.Username, post.Post_number);
            profilePicture.Image = FileTools.getProfilePicture(post.Owner.Username);
            lblUsername.Text = post.Owner.Username;
        }

        public ViewPost(Post post, Profile senderProfile)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            this.post = post;
            this.senderProfile = senderProfile;
            lblText.Text = post.Post_text;
            pbPhoto.Image = FileTools.getPost(post.Owner.Username, post.Post_number);
            profilePicture.Image = FileTools.getProfilePicture(post.Owner.Username);
            lblUsername.Text = post.Owner.Username;
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
            openProfile();
        }

        private void profilePicture_Click(object sender, EventArgs e)
        {
            openProfile();
        }

        public void openProfile()
        {
            if (senderProfile != null && senderProfile.user.Username != post.Owner.Username)
            {
                senderProfile.Hide();
                Profile openProfile = new Profile(post.Owner);
                openProfile.redirectHere += (s, args) => senderProfile.Show();
                openProfile.redirectAfterClose = true;
            }
            Close();
        }

        private void ViewPost_Load(object sender, EventArgs e)
        {
            //Sometimes the post's description is bigger than form's size, so this fixes the issue
            int resize = lblText.Size.Width - (Size.Width - lblText.Location.X);
            if (resize > 0)
            {
                Size newSize = new Size(Size.Width+ resize, Size.Height);
                Size = newSize;
                Size newSizeTableLayout = new Size(tableLayoutPanel1.Size.Width + resize, tableLayoutPanel1.Size.Height);
                tableLayoutPanel1.Size = newSizeTableLayout;
            }
        }
    }
}
