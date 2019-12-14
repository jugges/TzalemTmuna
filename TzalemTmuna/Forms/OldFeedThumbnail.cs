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
using TzalemTmuna.Statics;
using TzalemTmuna.DB;

namespace TzalemTmuna.Forms
{
    public partial class OldFeedThumbnail : UserControl
    {
        Post post;
        bool liked;
        LikeDB likeDB;

        public OldFeedThumbnail(Post post)
        {
            InitializeComponent();
            likeDB = new LikeDB();
            this.post = post;
            lblUsername.Text = post.Owner.Username;
            profilePicture.Image = FileTools.getProfilePicture(post.Owner.Username);
            pb.Image = FileTools.getPost(post.Owner.Username, post.Post_number);

            foreach (User x in post.Likes)
            {
                if (x.Username == LoggedInUser.login.Username)
                {
                    liked = true;
                    pbLike.Image = Properties.Resources.darkLikeFilled;
                    break;
                }
            }

            //Display last comment
            try
            {
                Comment lastComment = post.Comments.Last();
                lblLatestComment.Text = lastComment.Owner.Username + ": " + lastComment.Comment_text;
            }
            catch
            {
                panel2.Controls.Remove(lblLatestComment);
                lblLatestComment.Dispose();
            }

            //Count comments and likes
            if (post.Likes.Count == 1)
                lblLikes.Text = "1 like";
            else
                lblLikes.Text = post.Likes.Count + " likes";
            if (post.Comments.Count == 1)
                lblComments.Text = "1 comment";
            else
                lblComments.Text = post.Comments.Count + " comments";
            lblText.Text = post.Post_text;
        }

        public OldFeedThumbnail()
        {
            InitializeComponent();
        }

        private void Like()
        {
            if (liked)
            {
                pbLike.Image = Properties.Resources.darkLike;
                likeDB.Unlike(post);
                liked = false;
            }
            else
            {
                pbLike.Image = Properties.Resources.darkLikeFilled;
                likeDB.Like(post);
                liked = true;
            }
            if (post.Likes.Count == 1)
                lblLikes.Text = "1 like";
            else
                lblLikes.Text = post.Likes.Count + " likes";
        }

        private void pb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Like();
        }

        private void pbLike_Click(object sender, EventArgs e)
        {
            Like();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            btnMenu.ContextMenuStrip.Show(btnMenu, new Point(0, btnMenu.Height));
        }

        private void OpenProfile(object sender, EventArgs e)
        {
            if (post.Owner.Username == LoggedInUser.login.Username)
            {
                LoggedInUser.profile.Show();
            }
            else
            {
                Profile newProfile = new Profile(post.Owner);
                newProfile.Show();
            }
        }

        private void pbComment_Click(object sender, EventArgs e)
        {
            var viewPost = new ViewPost(post);
            viewPost.Show();
        }

        private void lblLatestComment_Click(object sender, EventArgs e)
        {
            try
            {
                Comment lastComment = post.Comments.Last();
                if (lastComment.Owner.Username == LoggedInUser.login.Username)
                {
                    LoggedInUser.profile.Show();
                }
                else
                {
                    //callingProfile.Hide();
                    Profile newProfile = new Profile(lastComment.Owner);
                    newProfile.Show();
                }
            }
            catch
            {
            }
        }
    }
}
