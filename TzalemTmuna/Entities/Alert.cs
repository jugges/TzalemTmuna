using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.DB;

namespace TzalemTmuna.Entities
{
    public class Alert : IEntity
    {
        private int alert_id;
        private string alert_text;
        private User recipient;

        public string Alert_text
        {
            set
            {
                if (value == string.Empty)
                    throw new Exception("Alert text cannot be empty");
                if (value.Length <= 255)
                    alert_text = value;
                else
                    throw new Exception("Alert text cannot surpass 255 characters");
            }
            get
            {
                return alert_text;
            }
        }

        public int Alert_id
        {
            get
            {
                return alert_id;
            }
        }

        public User Recipient
        {
            get
            {
                return recipient;
            }
        }

        public Alert(DataRow dr)
        {
            UserDB udb = new UserDB();
            alert_id = (int)dr["alert_id"];
            alert_text = dr["alert_text"].ToString();
            udb.Find(dr["recipient"]);
            recipient = new User(udb.GetCurrentRow());
        }
        public Alert(int alert_id, string alert_text, User recipient)
        {
            this.alert_id = alert_id;
            Alert_text = alert_text;
            this.recipient = recipient;
        }

        public void Populate(DataRow dr)
        {
            dr["alert_id"] = alert_id;
            dr["alert_text"] = alert_text;
            dr["recipient"] = recipient.Username;
        }
    }
}
