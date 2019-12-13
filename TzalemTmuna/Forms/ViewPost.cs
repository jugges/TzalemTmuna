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

            foreach (User x in post.Likes)
            {
                if (x.Username == LoggedInUser.login.Username)
                {
                    liked = true;
                    pbLike.Image = Properties.Resources.darkLikeFilled;
                    break;
                }
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

        private void ViewPost_Load(object sender, EventArgs e)
        {
            //Sometimes the post's description is bigger than form's size, so this fixes the issue
            int resize = lblText.Size.Width - (Size.Width - lblText.Location.X);
            if (resize > 0)
            {
                Size newSize = new Size(Size.Width + resize, Size.Height);
                Size = newSize;
                Size newSizeTableLayout = new Size(tableLayoutPanel1.Size.Width + resize, tableLayoutPanel1.Size.Height);
                tableLayoutPanel1.Size = newSizeTableLayout;
            }
        }

        private void pbComment_Click(object sender, EventArgs e)
        {
            //Switch between opening and closing comment adding panel
            if (tableLayoutPanel1.RowStyles[2].Height == 0)
            {
                tableLayoutPanel1.RowStyles[2].Height = 20;
                tableLayoutPanel1.RowStyles[0].Height = 70;
            }
            else
            {
                tableLayoutPanel1.RowStyles[2].Height = 0;
                tableLayoutPanel1.RowStyles[0].Height = 90;
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
    }
}
