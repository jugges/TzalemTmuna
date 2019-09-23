using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Objects;

namespace TzalemTmuna.DB
{
    public class UserDB:GeneralDB
    {
        public UserDB(): base("User", "username") { }
        public new User GetCurrentRow()
        {
            return new User(base.GetCurrentRow());
        }
    }
}
