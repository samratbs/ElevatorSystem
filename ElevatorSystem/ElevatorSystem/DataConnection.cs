using System.Data;
using System.Data.OleDb;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ElevatorSystem
{
    class DataAdapter
    {
        static string dbconnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"data source = ElevatorLogDatabase.accdb";
        static OleDbConnection Connection = new OleDbConnection(dbconnection);
        static string dbcommand = "SELECT * FROM Logtable;";
        static OleDbCommand command = new OleDbCommand(dbcommand, Connection);
        static OleDbDataAdapter da = new OleDbDataAdapter(command);
        private static List<string> loglist = new List<string>();
        private static string[] logarray;


        public DataSet DisplayData()
        {
            try
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }

        public void StoreData(string task)
        {
            DateTime now = DateTime.Now;
            string datenow = now.ToString();
            string logevent = task + "," + datenow;
            loglist.Add(logevent);
            logarray = loglist.ToArray();
        }

        public void UpdateData()
        {
            try
            {
                DataSet ds = new DataSet();
                OleDbCommandBuilder ocb = new OleDbCommandBuilder(da);
                ds.Clear();
                da.Fill(ds);
                DataTable dt = ds.Tables[0];               
                foreach (string log in logarray)
                {
                    DataRow dr = dt.NewRow();
                    string[] data = log.Split(',');
                    dr["Logaction"] = data[0];
                    dr["Logtime"] = data[1];
                    dt.Rows.Add(dr);
                }
                
                DataSet dsc = ds.GetChanges();
                da.Update(dsc);
                dt.AcceptChanges();
                MessageBox.Show("Inserted data into database successfully.");
                loglist.Clear();
                Array.Clear(logarray, 0, logarray.Length);

            }
            catch
            { 
                MessageBox.Show("Perform an action first before inserting into database");
            }

        }
    }
}