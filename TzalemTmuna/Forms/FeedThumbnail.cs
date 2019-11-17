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
    public partial class FeedThumbnail : UserControl
    {
        Image pic;
        Post post;

        public FeedThumbnail(Post post)
        {
            InitializeComponent();
            this.post = post;
            pic = FileTools.getPost(post.Owner.Username,post.Post_number);
            pb.Image = pic;
        }

        public FeedThumbnail()
        {
            InitializeComponent();
        }

        private void Like()
        {
            pbLike.Image = Properties.Resources.like;
        }

        private void pbLike_MouseClick(object sender, MouseEventArgs e)
        {
            Like();
        }

        private void pb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Like();
        }
    }
}
