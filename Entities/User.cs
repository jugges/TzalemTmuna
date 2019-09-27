using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TzalemTmuna.DB;
using System.Threading.Tasks;

namespace TzalemTmuna.Entities
{
    public class User : IEntity
    {
        private string username;
        private string full_name;
        private string biography;
        private bool is_private;
        private string external_url;
        private List<User> following;
        private List<User> followers;

        public string Username
        {
            set
            {
                if (Regex.IsMatch(value, @"^[a-zA-Z0-9_]+$") && value.Length <= 12)
                    username = value;
                else
                    throw new Exception("Username can only contain English letters, numbers and underscores");
            }
            get
            {
                return username;
            }
        }
        public string Full_name
        {
            set
            {
                if (value.Length <= 30)
                    full_name = value;
                else
                    throw new Exception("Full name can not surpass 30 characters");
            }
            get
            {
                return full_name;
            }
        }
        public string Biography
        {
            set
            {
                if (value.Length <= 150)
                    biography = value;
                else
                    throw new Exception("Biography can not surapss 150 characters");
            }
            get
            {
                return biography;
            }
        }
        public bool Is_private
        {
            set
            {
                is_private = value;
            }
            get
            {
                return is_private;
            }
        }
        public string External_url
        {
            set
            {
                if (Regex.IsMatch(value, @"https?:\/\/(www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b([-a-zA-Z0-9()@:%_\+.~#?&//=]*)"))
                    external_url = value;
                else
                    throw new Exception("Link provided is not a valid url");
            }
            get
            {
                return external_url;
            }
        }

        public List<User> Following
        {
            get
            {
                if (following != null)
                    return following;
                else
                {
                    var fdb = new FollowingDB();
                    following = fdb.GetFollowing(username);
                    return following;
                }
            }
        }
        public User(DataRow dr)
        {
            username = dr["username"].ToString();
            full_name = dr["full_name"].ToString();
            biography = dr["biography"].ToString();
            is_private = Convert.ToBoolean(dr["is_private"]);
            external_url = dr["external_url"].ToString();
        }
        public User()
        {

        }
        public void Populate(DataRow dr)
        {
            dr["username"] = username;
            dr["full_name"] = full_name;
            dr["biography"] = biography;
            dr["is_private"] = is_private;
            dr["external_url"] = external_url;
        }
    }
}
