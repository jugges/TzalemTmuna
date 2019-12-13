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
using TzalemTmuna.Statics;

namespace TzalemTmuna.Forms
{
    public partial class ViewPost : MetroFramework.Forms.MetroForm
    {
        Post post;
        bool liked;
        LikeDB likeDB;
        public ViewPost(Post post)
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.MetroThemeStyle
            };
            likeDB = new LikeDB();
            this.post = post;
            lblText.Text = post.Post_text;
            pbPhoto.Image = FileTools.getPost(post.Owner.Username, post.Post_number);
            profilePicture.Image = FileTools.getProfilePicture(post.Owner.Username);
            lblUsername.Text = post.Owner.Username;

            //Sometimes the post's description is bigger than form's size, so this fixes the issue
            int resize = lblText.Size.Width - (Size.Width - lblText.Location.X);
            if (resize > 0)
            {
                Size = new Size(Size.Width + resize, Size.Height);
                tableLayoutPanel1.Size = new Size(tableLayoutPanel1.Size.Width + resize, tableLayoutPanel1.Size.Height);
            }

            foreach (User x in post.Likes)
            {
                if (x.Username == LoggedInUser.login.Username)
                {
                    liked = true;
                    pbLike.Image = Properties.Resources.darkLikeFilled;
                    break;
                }
            }

            foreach (Comment x in post.Comments)
            {
                var commentControl = new CommentControl(x);
                flowLayoutPanel1.Controls.Add(commentControl);
            }

            //Likes count
            lblLikes.Text = post.Likes.Count + " likes";
            lblText.Text = post.Post_text;
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
            //Switch between opening and closing comment adding panel
            if (tableLayoutPanel1.RowStyles[2].Height == 0)
            {
                tableLayoutPanel1.RowStyles[2].Height = 20;
                tableLayoutPanel1.RowStyles[0].Height = 70;
                txtCommentText.Enabled = true;
                btnSubmit.Enabled = true;
            }
            else
            {
                tableLayoutPanel1.RowStyles[2].Height = 0;
                tableLayoutPanel1.RowStyles[0].Height = 90;
                txtCommentText.Enabled = false;
                btnSubmit.Enabled = false;
            }
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
            lblLikes.Text = post.Likes.Count + " likes";
        }

        private void pbLike_Click(object sender, EventArgs e)
        {
            Like();
        }

        private void pbPhoto_DoubleClick(object sender, EventArgs e)
        {
            Like();
        }

        private void ViewPost_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoggedInUser.feed.refreshFeed();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtCommentText.Text != string.Empty)
            {
                //Add Comment to Database
                DAL.GetInstance().ExecuteNonQuery("INSERT INTO comments " +
                    "([comment_text], [owner], [post_id]) " +
                    "VALUES(@comment_text, @owner, @post_id)", new OleDbParameter[]
                    {
                                    new OleDbParameter("@comment_text", txtCommentText.Text),
                                    new OleDbParameter("@owner", LoggedInUser.login.Username),
                                    new OleDbParameter("@post_id", post.Post_id)
                    });
                //Retrieve AutoNumber comment_id from Database
                int comment_id = (int)DAL.GetInstance().ExecuteScalarQuery("SELECT [comment_id] FROM comments ORDER BY [comment_id] DESC");
                //Create comment object
                var comment = new Comment(comment_id,post.Post_id, txtCommentText.Text, new User(LoggedInUser.login));
                //Add comment to DataSet
                new CommentDB().AddRow(comment);
                //Add comment to post's comment list
                post.Comments.Add(comment);
                //Add comment to flowLayoutPanel
                flowLayoutPanel1.Controls.Add(new CommentControl(comment));
                //Clean textbox
                txtCommentText.Text = string.Empty;
            }
        }
    }
}
