using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.DB;

namespace TzalemTmuna.Entities
{
    public class Comment : IEntity
    {
        private int comment_id;
        private string comment_text;
        private User owner;
        private int post_id;
        public string Comment_text
        {
            set
            {
                if (value.Length <= 255)
                    comment_text = value;
                else
                    throw new Exception("Comment cannot surpass 255 characters");
            }
            get
            {
                return comment_text;
            }
        }
        public int Comment_id
        {
            get
            {
                return comment_id;
            }
        }
        public int Post_id
        {
            get
            {
                return post_id;
            }
        }
        public User Owner
        {
            get
            {
                return owner;
            }
        }
        public Comment(DataRow dr)
        {
            UserDB udb = new UserDB();
            comment_id = (int)dr["comment_id"];
            comment_text = dr["comment_text"].ToString();
            post_id = (int)dr["post_id"];
            udb.Find(dr["owner"]);
            owner = new User(udb.GetCurrentRow());
        }
        //public Comment(int post_id, string comment_text, LoginUser owner)
        //{
        //    this.post_id = post_id;
        //    Comment_text = comment_text;
        //    this.owner = new User(owner);
        //}
        public void Populate(DataRow dr)
        {
            dr["comment_text"] = comment_text;
            dr["owner"] = owner.Username;
            dr["post_id"] = post_id;
            dr["comment_id"] = comment_id;
        }
    }
}
