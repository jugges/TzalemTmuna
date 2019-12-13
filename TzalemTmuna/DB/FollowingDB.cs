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
        public List<User> GetFollowers(string username)
        {
            var followers = new List<User>();
            var udb = new UserDB();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["following"].Equals(username))
                {
                    if (udb.Find(dr["follower"]))
                        followers.Add(new User(udb.GetCurrentRow()));
                    else
                        throw new Exception("Following user was not found in users database!");
                }
            }
            return followers;
        }
        public void Unfollow(User user)
        {
            for(int i=0; i< LoggedInUser.login.Following.Count; i++)
            {
                if(LoggedInUser.login.Following[i].Username == user.Username)
                {
                    LoggedInUser.login.Following.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < user.Followers.Count; i++)
            {
                if (user.Followers[i].Username == LoggedInUser.login.Username)
                {
                    user.Followers.RemoveAt(i);
                    break;
                }
            }
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(LoggedInUser.login.Username))
                {
                    if (dr["following"].Equals(user.Username))
                    {
                        DeleteRow(dr);
                        break;
                    }
                }
            }
            Save();
        }
        public void Follow(User user)
        {
            LoggedInUser.login.Following.Add(user);
            user.Followers.Add(new User(LoggedInUser.login));
            table.Rows.Add(LoggedInUser.login.Username,user.Username);
            Save();
        }
        public void ReverseFollow(User user)
        {
            LoggedInUser.login.Followers.Add(user);
            user.Following.Add(new User(LoggedInUser.login));
            table.Rows.Add(user.Username, LoggedInUser.login.Username);
            Save();
        }
        public void Remove(User user)
        {
            for (int i = 0; i < LoggedInUser.login.Followers.Count; i++)
            {
                if (LoggedInUser.login.Followers[i].Username == user.Username)
                {
                    LoggedInUser.login.Followers.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < user.Following.Count; i++)
            {
                if (user.Following[i].Username == LoggedInUser.login.Username)
                {
                    user.Following.RemoveAt(i);
                    break;
                }
            }
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(user.Username))
                {
                    if (dr["following"].Equals(LoggedInUser.login.Username))
                    {
                        DeleteRow(dr);
                        break;
                    }
                }
            }
            Save();
        }
    }
}
