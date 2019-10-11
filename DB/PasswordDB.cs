using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;
using System.Security.Cryptography;

namespace TzalemTmuna.DB
{
    public class PasswordDB:GeneralDB
    {
        private int saltLengthLimit = 32;
        public PasswordDB() : base("users", "username") {}
        public bool Match(User user, string password)
        {
            if (Find(user.Username))
            {
                var dr = GetCurrentRow();
                string hash = HashSha256(password, dr["salt"].ToString());
                if (dr["password"].ToString().Equals(hash))
                    return true;
                else
                    return false;
            }
            else
                throw new Exception("User was not found in database!");
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
        public string HashSha256(string password, string salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(salt+password);
            SHA256Managed hashstring = new SHA256Managed();
            byte[] hash = hashstring.ComputeHash(bytes);
            string hashString = string.Empty;
            foreach (byte x in hash)
            {
                hashString += x.ToString("X2");
            }
            return hashString;
        }

        public byte[] GetSalt()
        {
            return GetSalt(saltLengthLimit);
        }
        private byte[] GetSalt(int maximumSaltLength)
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
