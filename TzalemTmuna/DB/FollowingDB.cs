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
        public void Unfollow(LoginUser login, User user)
        {
            for(int i=0; i<login.Following.Count; i++)
            {
                if(login.Following[i].Username == user.Username)
                {
                    login.Following.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < user.Followers.Count; i++)
            {
                if (user.Followers[i].Username == login.Username)
                {
                    user.Followers.RemoveAt(i);
                    break;
                }
            }
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(login.Username))
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
        public void Follow(LoginUser login, User user)
        {
            login.Following.Add(user);
            user.Followers.Add(new User(login));
            table.Rows.Add(login.Username,user.Username);
            Save();
        }
        public void ReverseFollow(LoginUser login, User user)
        {
            login.Followers.Add(user);
            user.Following.Add(new User(login));
            table.Rows.Add(user.Username, login.Username);
            Save();
        }
        public void Remove(LoginUser login, User user)
        {
            for (int i = 0; i < login.Followers.Count; i++)
            {
                if (login.Followers[i].Username == user.Username)
                {
                    login.Followers.RemoveAt(i);
                    break;
                }
            }
            for (int i = 0; i < user.Following.Count; i++)
            {
                if (user.Following[i].Username == login.Username)
                {
                    user.Following.RemoveAt(i);
                    break;
                }
            }
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(user.Username))
                {
                    if (dr["following"].Equals(login.Username))
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
