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

namespace TzalemTmuna.Forms
{
    public partial class ProfileThumbnail : UserControl
    {
        Image pic;
        Post post;
        private void HandleTheme()
        {
            if (Statics.Theme.MetroThemeStyle == MetroFramework.MetroThemeStyle.Dark)
            {
                pbComment.Image = Properties.Dark.comment;
                pbLike.Image = Properties.Dark.like;
            }
            else
            {
                pbComment.Image = Properties.Light.comment;
                pbLike.Image = Properties.Light.like;
            }
        }
        public ProfileThumbnail(Post post)
        {
            InitializeComponent();
            HandleTheme();
            this.post = post;
            pic = FileTools.getPost(post.Owner.Username,post.Post_number);
            pb.Image = pic;
            lblComments.Text = post.Comments.Count.ToString();
            lblLikes.Text = post.Likes.Count.ToString();
        }

        private void pb_MouseLeave(object sender, EventArgs e)
        {
            pb.Image = pic;
            lblComments.Hide();
            lblLikes.Hide();
            pbComment.Hide();
            pbLike.Hide();
        }

        private void pb_Click(object sender, EventArgs e)
        {
            var viewPost = new ViewPost(post);
            viewPost.Show();
        }

        private void pb_MouseEnter(object sender, EventArgs e)
        {
            pb.Image = ImageTools.SetImageOpacity((Bitmap)pic, 0.2f);
            lblComments.Show();
            lblLikes.Show();
            pbComment.Show();
            pbLike.Show();
        }
    }
}
