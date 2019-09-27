using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;

namespace TzalemTmuna.DB
{
    public class FollowedDB:GeneralDB
    {
        public FollowedDB(): base("following", "following") { }
        public new User GetCurrentRow()
        {
            return new User(base.GetCurrentRow());
        }
    }
}
