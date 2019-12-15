using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TzalemTmuna.Entities;

namespace TzalemTmuna.Utilities
{
    public static class FileTools
    {
        public static void CreateProfile(string username)
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.IndexOf("\\bin")) + "\\Users\\";
            Directory.CreateDirectory(path + username);
        }

        public static void ChangeUsername(string oldUsername, string newUsername)
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.IndexOf("\\bin")) + "\\Users\\";
            Directory.Move(path + oldUsername, path + newUsername);
        }

        public static Bitmap getPost(string username, int post_number)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                path = path.Substring(0, path.IndexOf("\\bin")) + "\\Users\\";
                path += username + "\\" + post_number + ".jpg";
                using (var bmpTemp = new Bitmap(path))
                {
                    return new Bitmap(bmpTemp);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static Bitmap setPost()
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files(*.JPG;*.PNG;)|*.JPG;*.PNG;";
                openFile.Title = "Select Photo";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (var bmpTemp = new Bitmap(openFile.FileName))
                    {
                        return new Bitmap(bmpTemp);
                    }
                }
            }
            return null;
        }

        public static void deletePost(string username, int post_number)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                path = path.Substring(0, path.IndexOf("\\bin")) + "\\Users\\";
                path += username + "\\" + post_number + ".jpg";
                File.Delete(path);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static void savePost(string username, int post_number, Bitmap pic)
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.IndexOf("\\bin")) + "\\Users\\";
            path += username + "\\" + post_number + ".jpg";
            pic.Save(path);
        }
        public static Bitmap getProfilePicture(string username)
        {
            try
            {
                string path = Directory.GetCurrentDirectory();
                path = path.Substring(0, path.IndexOf("\\bin")) + "\\Users\\";
                path += username + "\\profilepicture.jpg";
                using (var bmpTemp = new Bitmap(path))
                {
                    return new Bitmap(bmpTemp);
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Bitmap setProfilePicture()
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files(*.JPG;*.PNG;)|*.JPG;*.PNG;";
                openFile.Title = "Select Profile Picture";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    using (var bmpTemp = new Bitmap(openFile.FileName))
                    {
                        return new Bitmap(bmpTemp);
                    }
                }
            }
            return null;
        }

        public static void saveProfilePicture(string username, Bitmap pic)
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.IndexOf("\\bin")) + "\\Users\\";
            path += username + "\\profilepicture.jpg";
            File.Delete(path);
            pic.Save(path);
        }
    }
}
