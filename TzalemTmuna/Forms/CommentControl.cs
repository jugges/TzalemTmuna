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
    public partial class CommentControl : MetroFramework.Controls.MetroUserControl,IMouseBoundable
    {
        Comment comment;
        bool editMode = false;
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
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
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
            if(!editMode)
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
            if (Parent != null)
            {
                MinimumSize = new Size(Parent.Width, MinimumSize.Height);
                Width = Parent.Width;
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.ContextMenuStrip.Show(btnMenu, new Point(0, btnMenu.Height));
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MetroFramework.MetroMessageBox.Show(ParentForm, "Confirm deletion of comment \"" + comment.Comment_text + "\"", "Delete Comment", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                new CommentDB().RemoveComment(comment.Comment_id);
                ((ViewPost)ParentForm).RemoveComment(comment.Comment_id, this);
                Parent.Controls.Remove(this);
                Dispose();
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Show textbox
            txtText.Text = comment.Comment_text;
            //8 is the difference between default textbox and label sizee, makes the text clear and not cropped
            txtText.Size = new Size(lblText.Width+8, lblText.Height+8);
            txtText.Show();
            //Show confirm edit button
            btnEdit.Show();
            //Disable options menu
            btnMenu.Enabled = false;
            editMode = true;
            //Hide text label
            lblText.Hide();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //If new text is only whitespace or empty -> delete comment
            if (TextTools.StripWhitespace(txtText.Text)==string.Empty)
            {
                removeToolStripMenuItem_Click(sender, e);
            }
            //If text is new -> update comment
            else if (txtText.Text != comment.Comment_text)
            {
                new CommentDB().EditComment(txtText.Text, comment.Comment_id);
                comment.Comment_text = txtText.Text;
                lblText.Text = txtText.Text;
            }
            //If text is not changed or after change
            btnMenu.Enabled = true;
            txtText.Hide();
            btnEdit.Hide();
            lblText.Show();
            editMode = false;
            btnMenu.Visible = true;
        }

        //DELETED: Now using autoSize with minSize
        //private void lblText_TextChanged(object sender, EventArgs e)
        //{
        //    int resize = lblText.Size.Height + lblText.Location.Y /**+ 10**/ - Size.Height;
        //    if (resize > 0)
        //    {
        //        Size = new Size(Size.Width, Size.Height + resize);
        //    }
        //}
    }
}
