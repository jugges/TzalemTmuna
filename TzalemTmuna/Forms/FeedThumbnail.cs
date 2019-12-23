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
    public partial class FeedThumbnail : MetroFramework.Controls.MetroUserControl
    {
        Post post;
        Comment lastComment;
        bool liked;
        LikeDB likeDB;
        private void HandleTheme()
        {
            if (Theme == MetroFramework.MetroThemeStyle.Dark)
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
        public FeedThumbnail(Post post)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            HandleTheme();
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
                    if (Theme == MetroFramework.MetroThemeStyle.Dark)
                    {
                        pbLike.Image = Properties.Dark.likeFilled;
                    }
                    else
                    {
                        pbLike.Image = Properties.Light.likeFilled;
                    }
                    break;
                }
            }

            //Display last comment
            if (post.Comments.Count != 0)
            {
                lastComment = post.Comments.Last();
                lblLatestComment.Text = lastComment.Owner.Username + ": " + lastComment.Comment_text;
            }
            else
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

        public FeedThumbnail()
        {
            InitializeComponent();
        }

        private void Like()
        {
            if (liked)
            {
                if (Theme == MetroFramework.MetroThemeStyle.Dark)
                {
                    pbLike.Image = Properties.Dark.like;
                }
                else
                {
                    pbLike.Image = Properties.Light.like;
                }
                likeDB.Unlike(post);
                liked = false;
            }
            else
            {
                if (Theme == MetroFramework.MetroThemeStyle.Dark)
                {
                    pbLike.Image = Properties.Dark.likeFilled;
                }
                else
                {
                    pbLike.Image = Properties.Light.likeFilled;
                }
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
    }
}
