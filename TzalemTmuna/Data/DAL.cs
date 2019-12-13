using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TzalemTmuna.Data
{
    class DAL
    {
        private static DAL instance;
        private OleDbConnection con;
        private DataSet ds;
        private Hashtable adapters;

        private DAL(string connectionString)
        {
            con = new OleDbConnection(connectionString);
            ds = new DataSet();
            adapters = new Hashtable();
        }

        public static DAL GetInstance()
        {
            if (instance == null)
            {
                string path = System.IO.Directory.GetCurrentDirectory();
                path = path.Substring(0, path.IndexOf("\\bin")) + "\\Data\\tzalemtmuna.mdb";
                instance = new DAL("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path);
            }
            return instance;
        }

        public void AddTable(string tableName, string sqlStat)
        {
            if (!adapters.Contains(tableName))
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(sqlStat, con);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.InsertCommand = builder.GetInsertCommand();
                adapter.UpdateCommand = builder.GetUpdateCommand();
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapter.Fill(ds, tableName);
                adapters.Add(tableName, adapter);
            }
        }

        public void AddTable(string tableName)
        {
            AddTable(tableName, "SELECT * FROM " + tableName);
        }

        public DataTable GetTable(string tableName)
        {
            return ds.Tables[tableName];
        }

        public void Update(string tableName)
        {
            OleDbDataAdapter adapter = (OleDbDataAdapter)adapters[tableName];
            adapter.Update(ds, tableName);
        }

        public void Update()
        {
            foreach (DataTable table in ds.Tables)
            {
                Update(table.TableName);
            }
        }
        public int ExecuteNonQuery(string sqlQry)
        {
            using (OleDbCommand command = con.CreateCommand())
            {
                command.CommandText = sqlQry;
                con.Open();
                var x = command.ExecuteNonQuery();
                con.Close();
                return x;
            }
        }
        public int ExecuteNonQuery(string sqlQry, OleDbParameter[] parameters)
        {
            using (OleDbCommand command = con.CreateCommand())
            {
                command.CommandText = sqlQry;
                command.Parameters.AddRange(parameters);
                con.Open();
                var x = command.ExecuteNonQuery();
                con.Close();
                return x;
            }
        }
        public int ExecuteNonQuery(string sqlQry, List<OleDbParameter> parameters)
        {
            using (OleDbCommand command = con.CreateCommand())
            {
                command.CommandText = sqlQry;
                command.Parameters.AddRange(parameters.ToArray());
                con.Open();
                var x = command.ExecuteNonQuery();
                con.Close();
                return x;
            }
        }
        public object ExecuteScalarQuery(string sqlQry)
        {
            using (OleDbCommand command = con.CreateCommand())
            {
                command.CommandText = sqlQry;
                con.Open();
                var x = command.ExecuteScalar();
                con.Close();
                return x;
            }
        }
        public object ExecuteScalarQuery(string sqlQry, OleDbParameter[] parameters)
        {
            using (OleDbCommand command = con.CreateCommand())
            {
                command.CommandText = sqlQry;
                command.Parameters.AddRange(parameters);
                con.Open();
                var x = command.ExecuteScalar();
                con.Close();
                return x;
            }
        }
    }
}
