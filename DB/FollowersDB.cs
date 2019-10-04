using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;

namespace TzalemTmuna.DB
{
    public class FollowersDB:GeneralDB
    {
        public FollowersDB(): base("following", "following") { }
        public List<User> GetFollowers(string username)
        {
            var followers = new List<User>();
            var udb = new UserDB();
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(username))
                {
                    if (udb.Find(dr["follower"]))
                        followers.Add(udb.GetCurrentRow());
                    else
                        throw new Exception("Following user was not found in users database!");
                }
            }
            return followers;
        }
    }
}
