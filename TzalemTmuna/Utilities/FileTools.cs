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

        public static Image getProfilePicture(string username)
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

        public static Image setProfilePicture(string username)
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
        public static void saveProfilePicture(string username, Image pic)
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.IndexOf("\\bin")) + "\\Users\\";
            path += username + "\\profilepicture.jpg";
            File.Delete(path);
            pic.Save(path);
        }
    }
}
