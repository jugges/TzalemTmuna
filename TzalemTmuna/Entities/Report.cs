using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.DB;

namespace TzalemTmuna.Entities
{
    public class Report : IEntity
    {
        private int report_id;
        private string report_text;
        private User owner;
        private int post_id; //if post_id==-1 then the report doesn't deal with a post
        private DateTime creation_date;
        private DateTime closing_date;

        public string Report_text
        {
            set
            {
                if (value == string.Empty)
                    throw new Exception("Report text cannot be empty");
                if (value.Length <= 255)
                    report_text = value;
                else
                    throw new Exception("Report text cannot surpass 255 characters");
            }
            get
            {
                return report_text;
            }
        }
        public int Report_id
        {
            get
            {
                return report_id;
            }
        }
        public int Post_id
        {
            get
            {
                return post_id;
            }
        }
        public User Owner
        {
            get
            {
                return owner;
            }
        }
        public DateTime Creation_date
        {
            get
            {
                return creation_date;
            }
        }
        public DateTime Closing_date
        {
            get
            {
                return closing_date;
            }
            set
            {
                closing_date = value;
            }
        }
        public Report(DataRow dr)
        {
            UserDB udb = new UserDB();
            report_id = (int)dr["report_id"];
            report_text = dr["report_text"].ToString();
            post_id = (int)dr["post_id"];
            udb.Find(dr["owner"]);
            owner = new User(udb.GetCurrentRow());
            creation_date = (DateTime)dr["creation_date"];
            if (dr["closing_date"].ToString() != string.Empty)
                closing_date = (DateTime)dr["closing_date"];
        }
        public Report(int report_id, int post_id, string report_text, User owner, DateTime creation_date)
        {
            this.report_id = report_id;
            this.post_id = post_id;
            Report_text = report_text;
            this.creation_date = creation_date;
            this.owner = owner;
        }
        public void Populate(DataRow dr)
        {
            dr["report_id"] = report_id;
            dr["report_text"] = report_text;
            dr["post_id"] = post_id;
            dr["owner"] = owner.Username;
            dr["creation_date"] = creation_date;
            if(closing_date!=null)
                dr["closing_date"] = closing_date;
        }
    }
}
