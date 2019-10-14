using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using TzalemTmuna.Entities;

namespace TzalemTmuna.Utilities
{
    public static class PasswordTools
    {
        public static bool Match(LoginUser user, string password)
        {
            string hash = HashSha256(password, user.Salt);
            return user.Password.Equals(hash);
        }
        //public void Set(User user, string password)
        //{
        //    if (Find(user.Username))
        //    {
        //        var dr = GetCurrentRow();
        //        string salt = string.Empty;
        //        foreach (byte x in GetSalt())
        //        {
        //            salt += x.ToString("X2");
        //        }
        //        string hash = HashSha256(password, salt);
        //        dr["salt"] = salt;
        //        dr["password"] = hash;
        //        Save();
        //    }
        //    else
        //        throw new Exception("User was not found in database!");
        //}
        public static string HashSha256(string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(salt + password);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += x.ToString("X2");
            }
            return hashString;
        }

        public static string GetSalt()
        {
            string salt = string.Empty;
            foreach (byte x in GetSalt(32))
            {
                salt += x.ToString("X2");
            }
            return salt;
        }
        private static byte[] GetSalt(int maximumSaltLength)
        {
            var salt = new byte[maximumSaltLength];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetNonZeroBytes(salt);
            }

            return salt;
        }
    }
}
