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

        public string[] GetUsernameList()
        {
            var list = new string[table.Rows.Count];
            for(int i=0; i<table.Rows.Count; i++)
            {
                list[i]=table.Rows[i]["username"].ToString();
            }
            return list;
        }
    }
}
