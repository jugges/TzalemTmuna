using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;

namespace TzalemTmuna.DB
{
    public class RequestsDB:GeneralDB
    {
        public RequestsDB(): base("requests", "follower") { }
        public List<User> GetSentRequests(string username)
        {
            var sentRequests = new List<User>();
            var udb = new UserDB();
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(username))
                {
                    if (udb.Find(dr["following"]))
                        sentRequests.Add(new User(udb.GetCurrentRow()));
                    else
                        throw new Exception("Requested user was not found in users database!");
                }
            }
            return sentRequests;
        }
        public List<User> GetReceivedRequests(string username)
        {
            var receivedRequests = new List<User>();
            var udb = new UserDB();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["following"].Equals(username))
                {
                    if (udb.Find(dr["follower"]))
                        receivedRequests.Add(new User(udb.GetCurrentRow()));
                    else
                        throw new Exception("Requesting user was not found in users database!");
                }
            }
            return receivedRequests;
        }
        public void RemoveRequest(LoginUser login, User user)
        {
            for(int i=0; i<login.SentRequests.Count; i++)
            {
                if(login.SentRequests[i].Username == user.Username)
                {
                    login.SentRequests.RemoveAt(i);
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
        public void SendRequest(LoginUser login, User user)
        {
            login.SentRequests.Add(user);
            table.Rows.Add(login.Username,user.Username);
            Save();
        }
        public void AcceptRequest(LoginUser login, User user)
        {
            DeclineRequest(login, user);
            var fdb = new FollowingDB();
            fdb.ReverseFollow(login, user);
        }
        public void DeclineRequest(LoginUser login, User user)
        {
            for (int i = 0; i < login.ReceivedRequests.Count; i++)
            {
                if (login.ReceivedRequests[i].Username == user.Username)
                {
                    login.ReceivedRequests.RemoveAt(i);
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
