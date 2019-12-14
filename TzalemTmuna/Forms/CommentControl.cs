using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TzalemTmuna.Utilities;
using TzalemTmuna.Entities;
using TzalemTmuna.DB;
using TzalemTmuna.Statics;

namespace TzalemTmuna.Forms
{
    public partial class CommentControl : MetroFramework.Controls.MetroUserControl
    {
        Comment comment;
        public CommentControl()
        {
            InitializeComponent();
        }
        public CommentControl(Comment comment)
        {
            InitializeComponent();

            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            this.comment = comment;
            lblUsername.Text = comment.Owner.Username;
            lblText.Text = comment.Comment_text;
            var pic = FileTools.getProfilePicture(comment.Owner.Username);
            if (pic != null)
            {
                ProfilePicture.Image = pic;
            }
            if (comment.Owner.Username != LoggedInUser.login.Username)
            {
                Controls.Remove(btnMenu);
                btnMenu.Dispose();
            }
        }

        public void ToggleMenu()
        {
            btnMenu.Visible = !btnMenu.Visible;
        }

        private void OpenProfile(object sender, EventArgs e)
        {
            if (comment.Owner.Username == LoggedInUser.login.Username)
            {
                LoggedInUser.profile.Show();
            }
            else
            {
                Profile newProfile = new Profile(comment.Owner);
                newProfile.Show();
            }
        }

        private void CommentControl_ParentChanged(object sender, EventArgs e)
        {
            Width = Parent.Width;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.ContextMenuStrip.Show(btnMenu, new Point(0, btnMenu.Height));
        }

        private void ProfilePicture_Click(object sender, EventArgs e)
        {

        }
    }
}
