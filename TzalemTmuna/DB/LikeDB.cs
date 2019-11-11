using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;

namespace TzalemTmuna.DB
{
    public class LikeDB : GeneralDB
    {
        public LikeDB(): base("likes", "post_id") { }
        public List<User> GetLikes(int post_id)
        {
            var likes = new List<User>();
            var udb = new UserDB();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["post_id"].Equals(post_id))
                {
                    if (udb.Find(dr["owner"]))
                        likes.Add(new User(dr));
                    else
                        throw new Exception("Liker was not found in users database!");
                }
            }
            return likes;
        }
        public void Unlike(int post_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(post_id))
                {
                        DeleteRow(dr);
                        break;
                }
            }
            Save();
        }
        public void Like(LoginUser login, int post_id)
        {
            table.Rows.Add(post_id,login.Username);
            Save();
        }
    }
}
