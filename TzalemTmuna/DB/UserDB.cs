using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;

namespace TzalemTmuna.DB
{
    public class UserDB:GeneralDB
    {
        public UserDB(): base("users", "username") { }
        public new DataRow GetCurrentRow()
        {
            return base.GetCurrentRow();
        }
        
        public User GetUser(string username)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(username))
                {
                    return new User(dr);
                }
            }
            throw new Exception("username not found!");
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();
            foreach (DataRow dr in table.Rows)
            {
                users.Add(new User(dr));
            }
            return users;
        }

        public string[] GetUsernameList()
        {
            var list = new string[table.Rows.Count];
            for(int i=0; i<table.Rows.Count; i++)
            {
                list[i]=table.Rows[i]["username"].ToString();
            }
            return list;
        }
        //Used for un/banning
        public void ActionUser(string username, string reason)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(username))
                {
                    dr["ban_text"] = reason;
                    break;
                }
            }
            Save();
        }
    }
}
