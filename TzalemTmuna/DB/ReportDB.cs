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

        public List<Report> GetReports()
        {
            var reports = new List<Report>();
            foreach (DataRow dr in table.Rows)
            {
                reports.Add(new Report(dr));
            }
            return reports;
        }

        public List<Report> GetReports(int content_type, int content_id)
        {
            var reports = new List<Report>();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["content_id"].Equals(content_id) && dr["content_type"].Equals(content_type))
                {
                    reports.Add(new Report(dr));
                }
            }
            return reports;
        }

        public List<Report> GetReports(string username)
        {
            var reports = new List<Report>();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["owner"].Equals(username))
                {
                    reports.Add(new Report(dr));
                }
            }
            return reports;
        }

        public Report GetReport(int report_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(report_id))
                {
                    return new Report(dr);
                }
            }
            throw new Exception("report_id not found!");
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
                    dr["closing_date"] = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                    break;
                }
            }
            Save();
        }
    }
}
