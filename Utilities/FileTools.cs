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

        public static Image getProfilePicture(string username)
        {
            string path = Directory.GetCurrentDirectory();
            path = path.Substring(0, path.IndexOf("\\bin")) + "\\Users\\";
            return Image.FromFile(path + username +"\\profilepicture.png");
        }

        public static Image setProfilePicture(string username)
        {
            using (var openFile = new OpenFileDialog())
            {
                openFile.Filter = "Image Files(*.JPG;*.PNG;*.GIF)|*.JPG;*.PNG;*.GIF";
                openFile.Title = "Select Profile Picture";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    return Image.FromFile(openFile.FileName);
                }
            }
            return null;
        }
    }
}
