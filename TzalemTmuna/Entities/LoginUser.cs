using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using TzalemTmuna.DB;
using System.Threading.Tasks;
using TzalemTmuna.Utilities;

namespace TzalemTmuna.Entities
{
    public class LoginUser : IEntity
    {
        private string username;
        private string email;
        private string salt;
        private string password;
        private string full_name;
        private string biography;
        public bool is_private;
        public bool is_admin;
        public bool is_verified;
        private string external_url;
        private List<User> following;
        private List<User> followers;
        private List<User> receivedRequests;
        private List<User> sentRequests;
        private List<Post> posts;
        private List<Report> reports;

        public string Username
        {
            set
            {
                if (TextTools.IsUsername(value))
                    username = value;
                else
                    throw new Exception("Username can only contain English letters, numbers and underscores");
            }
            get
            {
                return username;
            }
        }
        public string Email
        {
            set
            {
                if (TextTools.IsEmail(value))
                    email = value;
                else
                    throw new Exception("You must enter a valid email address");
            }
            get
            {
                return email;
            }
        }
        public void NewSalt()
        {
            salt = PasswordTools.GetSalt();
        }
        public string Salt
        {
            get
            {
                return salt;
            }
        }
        public string Password
        {
            set
            {
                if(TextTools.IsPassword(value))
                    password = PasswordTools.HashSha256(value,salt);
                else
                    throw new Exception("You must enter a valid password");
            }
            get
            {
                return password;
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
        public string External_url
        {
            set
            {
                if (TextTools.IsURL(value))
                    external_url = value;
                else if (value == string.Empty)
                { }
                else
                    throw new Exception("Link provided is not a valid url");
            }
            get
            {
                return external_url;
            }
        }
        public List<User> ReceivedRequests
        {
            get
            {
                if (receivedRequests != null)
                    return receivedRequests;
                else
                {
                    var rdb = new RequestsDB();
                    receivedRequests = rdb.GetReceivedRequests(username);
                    return receivedRequests;
                }
            }
        }
        public List<User> SentRequests
        {
            get
            {
                if (sentRequests != null)
                    return sentRequests;
                else
                {
                    var rdb = new RequestsDB();
                    sentRequests = rdb.GetSentRequests(username);
                    return sentRequests;
                }
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
        public List<User> Followers
        {
            get
            {
                if (followers != null)
                    return followers;
                else
                {
                    var fdb = new FollowingDB();
                    followers = fdb.GetFollowers(username);
                    return followers;
                }
            }
        }
        public List<Post> Posts
        {
            get
            {
                if (posts != null)
                    return posts;
                else
                {
                    var pdb = new PostDB();
                    posts = pdb.GetPosts(username);
                    return posts;
                }
            }
        }

        public List<Report> Reports
        {
            get
            {
                if (reports != null)
                    return reports;
                else
                {
                    var rdb = new ReportDB();
                    reports = rdb.GetReports(username);
                    return reports;
                }
            }
        }

        public List<Post> FeedPosts()
        {
            var feedPosts = new List<Post>();

            feedPosts.AddRange(Posts);
            foreach(User x in Following)
            {
                feedPosts.AddRange(x.Posts);
            }

            feedPosts = feedPosts.OrderByDescending(post => post.Post_id).ToList();

            return feedPosts;
        }

        //Used only for login procedures
        public string GetBanText()
        {
            //Used to check if user is banned
            var udb = new UserDB();
            udb.Find(username);
            return udb.GetCurrentRow()["ban_text"].ToString();
        }

        public LoginUser(DataRow dr)
        {
            username = dr["username"].ToString();
            email = dr["email"].ToString();
            salt = dr["salt"].ToString();
            password = dr["password"].ToString();
            full_name = dr["full_name"].ToString();
            biography = dr["biography"].ToString();
            is_private = Convert.ToBoolean(dr["is_private"]);
            is_admin = Convert.ToBoolean(dr["is_admin"]);
            is_verified = Convert.ToBoolean(dr["is_verified"]);
            external_url = dr["external_url"].ToString();
        }
        public LoginUser(string username, string email, string password)
        {
            this.username = username;
            this.email = email;
            NewSalt();
            if (TextTools.IsPassword(password))
                this.password = PasswordTools.HashSha256(password, salt);
            else
                throw new Exception("You must enter a valid password");
            full_name = username;
            is_private = false;
            is_admin = false;
        }
        public LoginUser()
        {

        }

        public void ChangePassword(string password, string salt)
        {
            this.password = password;
            this.salt = salt;
        }

        public void Populate(DataRow dr)
        {
            dr["username"] = username;
            dr["email"] = email;
            dr["salt"] = salt;
            dr["password"] = password;
            dr["full_name"] = full_name;
            dr["biography"] = biography;
            dr["is_private"] = is_private;
            dr["is_admin"] = is_admin;
            dr["is_verified"] = is_verified;
            dr["external_url"] = external_url;
        }
    }
}
