using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TzalemTmuna.Entities;
using TzalemTmuna.Data;

namespace TzalemTmuna.DB
{
    public abstract class GeneralDB
    {
        protected DataTable table;
        protected int currentRow;
        protected string primaryKey;
        public GeneralDB(string tableName, string primaryKey)
        {
            DAL.GetInstance().AddTable(tableName);
            table = DAL.GetInstance().GetTable(tableName);
            this.primaryKey = primaryKey;
            if (IsEmpty())
                currentRow = -1;
            else
                currentRow = 0;
        }
        public GeneralDB(string tableName, string sqlStat, string primaryKey)
        {
            DAL.GetInstance().AddTable(tableName,sqlStat);
            table = DAL.GetInstance().GetTable(tableName);
            this.primaryKey = primaryKey;
            if (IsEmpty())
                currentRow = -1;
            else
                currentRow = 0;
        }
        #region NAVIGATION
        public void GoToFirst()
        {
            if (IsEmpty())
                throw new Exception("Navigating on an empty table");
            currentRow = 0;
        }
        public void GoToLast()
        {
            if (IsEmpty())
                throw new Exception("Navigating on an empty table");
            currentRow = table.Rows.Count - 1;
        }
        public void MoveNext()
        {
            if (IsEmpty())
                throw new Exception("Navigating on an empty table");
            currentRow = (currentRow + 1) % table.Rows.Count;
        }
        public void MovePrev()
        {
            if (IsEmpty())
                throw new Exception("Navigating on an empty table");
            currentRow = currentRow == 0 ? table.Rows.Count - 1 : currentRow - 1;
        }
        //<summary>
        //Searching the object with a key
        //</summary>
        //<param name="key">key of the row</param>
        //<returns>True if found and update currentRow else False</returns>
        public bool Find(object key)
        {
            int r = 0;
            foreach(DataRow dr in table.Rows)
            {
                if (dr[primaryKey].Equals(key))
                {
                    currentRow = r;
                    return true;
                }
                else
                    r++;
            }
            return false;
        }
        #endregion
        #region GENERAL OPERATIONS
        public int Size()
        {
            return table.Rows.Count;
        }
        public bool IsEmpty()
        {
            return table.Rows.Count == 0;
        }
        public void Save()
        {
            DAL.GetInstance().Update(table.TableName);
        }
        #endregion
        #region CRUD
        protected DataRow GetCurrentRow()
        {
            return table.Rows[currentRow];
        }
        public void AddRow(IEntity obj)
        {
            DataRow dr = table.NewRow();
            obj.Populate(dr);
            table.Rows.Add(dr);
            //added by mew
            GoToLast();
        }
        public void UpdateRow(IEntity obj)
        {
            obj.Populate(table.Rows[currentRow]);
        }
        protected void DeleteRow(DataRow dr)
        {
            table.Rows.Remove(dr);
        }
        #endregion CRUD
    }
}
