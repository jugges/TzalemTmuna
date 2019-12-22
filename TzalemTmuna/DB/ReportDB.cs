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
    public class ReportDB : GeneralDB
    {
        public ReportDB() : base("reports", "report_id") { }

        public List<Report> GetReports(int post_id)
        {
            var reports = new List<Report>();
            var udb = new UserDB();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["post_id"].Equals(post_id))
                {
                    if (udb.Find(dr["owner"]))
                        reports.Add(new Report(dr));
                    else
                        throw new Exception("Report owner was not found in users database!");
                }
            }
            return reports;
        }

        public List<Report> GetReports(string username)
        {
            var reports = new List<Report>();
            var udb = new UserDB();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["owner"].Equals(username))
                {
                    if (udb.Find(username))
                        reports.Add(new Report(dr));
                    else
                        throw new Exception("Report owner was not found in users database!");
                }
            }
            return reports;
        }

        public void RemoveReport(int report_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(report_id))
                {
                    DeleteRow(dr);
                    break;
                }
            }
            Save();
        }
        public void CloseReport(int report_id)
        {
            //A closed report means it was dealt with by an admin
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(report_id))
                {
                    dr["closing_date"] = DateTime.Now;
                    break;
                }
            }
            Save();
        }
    }
}
