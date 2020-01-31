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
    public partial class NewPost : MetroFramework.Forms.MetroForm
    {
        const int SIZE = 640;
        Bitmap pic;
        Bitmap picBackup;
        public NewPost()
        {
            InitializeComponent();
            StyleManager = new MetroFramework.Components.MetroStyleManager
            {
                Owner = this,
                Theme = Statics.Theme.metroThemeStyle,
                Style = Statics.Theme.metroColorStyle
            };
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Save post image file
            FileTools.savePost(LoggedInUser.login.Username, LoggedInUser.login.Posts.Count, pic);
            //Add Post to Database
            DAL.GetInstance().ExecuteNonQuery("INSERT INTO posts " +
                "([post_text], [owner], [post_number]) " +
                "VALUES(@post_text, @owner, @post_number)", new OleDbParameter[]
                {
                                    new OleDbParameter("@post_text", txtText.Text),
                                    new OleDbParameter("@owner", LoggedInUser.login.Username),
                                    new OleDbParameter("@post_number", LoggedInUser.login.Posts.Count)
                });
            //Retrieve AutoNumber post_id from Database
            int post_id = (int)DAL.GetInstance().ExecuteScalarQuery("SELECT [post_id] FROM posts WHERE [owner]=@owner AND [post_number]=@post_number", new OleDbParameter[]
                {
                                    new OleDbParameter("@owner",LoggedInUser.login.Username),
                                    new OleDbParameter("@post_number",LoggedInUser.login.Posts.Count)
                });
            //Create post object
            var post = new Post(post_id, txtText.Text, LoggedInUser.login.Posts.Count, new User(LoggedInUser.login));
            //Add post to DataSet
            new PostDB().AddRow(post);
            //Add post to login list
            LoggedInUser.login.Posts.Add(post);
            //View post
            var viewPost = new ViewPost(post);
            viewPost.Show();
            //Return positive dialog result and close
            DialogResult = DialogResult.OK;
            Close();
        }

        private void pbPhoto_MouseLeave(object sender, EventArgs e)
        {
            if (pic != null)
            {
                pbPhoto.Image = pic;
            }
            lblSelectPhoto.Hide();
        }

        private void pbPhoto_Click(object sender, EventArgs e)
        {
            var picBackup = FileTools.setPost();

            if (picBackup != null)
            {
                this.picBackup = picBackup;
                pic = tCrop.Checked ? Crop() : ImageTools.ResizeImage(picBackup, SIZE, SIZE);
                pbPhoto.Image = pic;
            }
        }

        private void pbPhoto_MouseEnter(object sender, EventArgs e)
        {
            if (pic != null)
            {
                pbPhoto.Image = ImageTools.SetImageOpacity(pic, 0.2f);
            }
            lblSelectPhoto.Show();
        }

        private void cropToggle_CheckedChanged(object sender, EventArgs e)
        {
            tbCropX.Enabled = tCrop.Checked;
            tbCropY.Enabled = tCrop.Checked;
            tbCropZ.Enabled = tCrop.Checked;
            tbPosX.Enabled = tCrop.Checked;
            tbPosY.Enabled = tCrop.Checked;
            if (picBackup != null)
            {
                pic = tCrop.Checked ? Crop() : ImageTools.ResizeImage(picBackup, SIZE, SIZE);
                pbPhoto.Image = pic;
            }
        }
        private Bitmap Crop()
        {
            GC.Collect();
            return ImageTools.CropImage(ImageTools.ResizeImage(picBackup, (picBackup.Width * tbCropZ.Value) / 100, (picBackup.Height * tbCropZ.Value) / 100), SIZE, SIZE, (picBackup.Width * tbCropX.Value) / 100, (picBackup.Height * tbCropY.Value) / 100, (SIZE * tbPosX.Value) / 100, (SIZE * tbPosY.Value) / 100);
        }
        private void CropRefresh()
        {
            pic = Crop();
            pbPhoto.Image = pic;
        }

        private void tbCropX_ValueChanged(object sender, EventArgs e)
        {
            CropRefresh();
        }

        private void tbCropY_ValueChanged(object sender, EventArgs e)
        {
            CropRefresh();
        }

        private void tbCropZ_ValueChanged(object sender, EventArgs e)
        {
            CropRefresh();
        }

        private void tbCropY2_ValueChanged(object sender, EventArgs e)
        {
            CropRefresh();
        }

        private void tbCropX2_ValueChanged(object sender, EventArgs e)
        {
            CropRefresh();
        }
    }
}
