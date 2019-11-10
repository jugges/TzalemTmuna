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
    public partial class Thumbnail : UserControl
    {
        Image pic;
        Post post;
        public Thumbnail(Post post)
        {
            InitializeComponent();
            this.post = post;
            pic = FileTools.getPost(post.Owner.Username,post.Post_number);
            pb.Image = pic;
        }

        private void pb_MouseLeave(object sender, EventArgs e)
        {
            pb.Image = pic;
            lblComment.Hide();
            lblLike.Hide();
            pbComment.Hide();
            pbLike.Hide();
        }

        private void pb_Click(object sender, EventArgs e)
        {

        }

        private void pb_MouseEnter(object sender, EventArgs e)
        {
            pb.Image = ImageTools.SetImageOpacity((Bitmap)pic, 0.2f);
            lblComment.Show();
            lblLike.Show();
            pbComment.Show();
            pbLike.Show();
        }
    }
}
