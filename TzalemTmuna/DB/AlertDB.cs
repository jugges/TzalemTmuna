using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Data;
using TzalemTmuna.Entities;
using TzalemTmuna.Statics;

namespace TzalemTmuna.DB
{
    public class AlertDB : GeneralDB
    {
        public AlertDB() : base("alerts", "alert_id") { }

        public List<Alert> GetAlerts(string username)
        {
            var alerts = new List<Alert>();
            foreach (DataRow dr in table.Rows)
            {
                if (dr["recipient"].Equals(username))
                {
                    alerts.Add(new Alert(dr));
                }
            }
            return alerts;
        }

        public void RemoveAlert(int alert_id)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(alert_id))
                {
                    DeleteRow(dr);
                    break;
                }
            }
            Save();
        }

        public void NewAlert(string alert_text, User recipient)
        {
            //Add new alert to Database
            DAL.GetInstance().ExecuteNonQuery("INSERT INTO alerts " +
                "([alert_text], [recipient]) " +
                "VALUES(@alert_text, @recipient)", new OleDbParameter[]
                {
                                    new OleDbParameter("@alert_text", alert_text),
                                    new OleDbParameter("@recipient", recipient.Username)
                });
            //Retrieve AutoNumber alert_id from Database
            int alert_id = (int)DAL.GetInstance().ExecuteScalarQuery("SELECT [alert_id] FROM alerts ORDER BY [alert_id] DESC");
            //Create alert object
            var alert = new Alert(alert_id, alert_text, recipient);
            //Add alert to DataSet
            new AlertDB().AddRow(alert);
        }
    }
}
