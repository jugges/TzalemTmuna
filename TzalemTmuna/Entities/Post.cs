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
    public class Post : IEntity
    {
        private int post_id; //Post number regarding all uploads
        private int post_number; //Post number in count regarding specific user's uploads
        private User owner; //Post creator
        private string post_text; //Post description
        private List<Comment> comments; //List of comments on post
        private List<User> likes; //List of users that applied likes on post

        public string Post_text
        {
            set
            {
                if (value.Length <= 255)
                    post_text = value;
                else
                    throw new Exception("Post cannot surpass 255 characters");
            }
            get
            {
                return post_text;
            }
        }

        public int Post_id
        {
            get
            {
                return post_id;
            }
        }

        public int Post_number
        {
            get
            {
                return post_number;
            }
        }

        public User Owner
        {
            get
            {
                return owner;
            }
        }
        public List<Comment> Comments
        {
            get
            {
                if (comments != null)
                    return comments;
                else
                {
                    var cdb = new CommentDB();
                    comments = cdb.GetComments(post_id);
                    return comments;
                }
            }
        }
        public List<User> Likes
        {
            get
            {
                if (likes != null)
                    return likes;
                else
                {
                    var ldb = new LikeDB();
                    likes = ldb.GetLikes(post_id);
                    return likes;
                }
            }
        }
        public Post(DataRow dr)
        {
            UserDB udb = new UserDB();
            post_id = (int)dr["post_id"];
            post_text = dr["post_text"].ToString();
            post_number = (int)dr["post_number"];
            udb.Find(dr["owner"]);
            owner = new User(udb.GetCurrentRow());
        }
        public Post(int post_id,string post_text, int post_number, User owner)
        {
            this.post_id = post_id;
            this.post_text = post_text;
            this.post_number = post_number;
            this.owner = owner;
        }
        public void Populate(DataRow dr)
        {
            dr["post_text"] = post_text;
            dr["owner"] = owner.Username;
            dr["post_number"] = post_number;
            dr["post_id"] = post_id;
        }
    }
}
