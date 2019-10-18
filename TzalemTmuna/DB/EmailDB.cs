using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;

namespace TzalemTmuna.DB
{
    public class EmailDB:GeneralDB
    {
        public EmailDB(): base("users", "email") { }
        public new DataRow GetCurrentRow()
        {
            return base.GetCurrentRow();
        }
    }
}
