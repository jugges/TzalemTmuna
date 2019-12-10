using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;
using TzalemTmuna.Statics;

namespace TzalemTmuna.DB
{
    public class LikeDB : GeneralDB
    {
        public LikeDB() : base("likes", "post_id") { }
        public List<User> GetLikes(int post_id)
        {
            var likes = new List<User>();
            var udb = new UserDB();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["post_id"].Equals(post_id))
                {
                    if (udb.Find(dr["owner"]))
                        likes.Add(new User(udb.GetCurrentRow()));
                    else
                        throw new Exception("Liker was not found in users database!");
                }
            }
            return likes;
        }
        public void Unlike(Post post)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(post.Post_id))
                    if (dr["owner"].ToString() == LoggedInUser.login.Username)
                    {
                        DeleteRow(dr);
                        
                        foreach(User x in post.Likes)
                        {
                            if(x.Username == LoggedInUser.login.Username)
                            {
                                post.Likes.Remove(x);
                                break;
                            }
                        }

                        break;
                    }
            }
            Save();
        }
        public void Like(Post post)
        {
            table.Rows.Add(post.Post_id, LoggedInUser.login.Username);
            post.Likes.Add(new User(LoggedInUser.login));
            Save();
        }
    }
}
