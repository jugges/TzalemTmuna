using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;

namespace TzalemTmuna.DB
{
    public class FollowingDB:GeneralDB
    {
        public FollowingDB(): base("following", "follower") { }
        public List<User> GetFollowing(string username)
        {
            var following = new List<User>();
            var udb = new UserDB();
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(username))
                {
                    if (udb.Find(dr["following"]))
                        following.Add(new User(udb.GetCurrentRow()));
                    else
                        throw new Exception("Followed user was not found in users database!");
                }
            }
            return following;
        }
    }
}
