using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using  MySql.Data.MySqlClient;

namespace RFID_SmartHealthCard
{
    public class DBMySql
    {



        public static string MySqlConnectionString = "Server=localhost;Database=smart-health-card;Uid=root;pwd=;";   ////////---------- LocalHost ... Offline
        public static string MySqlOnlineConnectionString = "Server=148.72.232.171;Database=smarthealthcard;Uid=smarthealthcard;pwd=Freepwd123#;";   ////////---------- LocalHost ... Online



        //public static string MySqlConnectionString = "Server=50.62.209.108;Database=otc;Uid=otc;pwd=Testpwd123#;";///////////---------- Online

        public bool TestMySqlConnection()
        {
            try
            {
                using (MySqlConnection cn = GetMySqlActiveConnection())
                {
                    bool results = cn.State.Equals(ConnectionState.Open);
                    cn.Close();
                    return results;
                }

            }
            catch { return false; }
        }




        //----------------------- MySql -----------------------
        public MySqlConnection GetMySqlActiveConnection()
        {
            MySqlConnection cn;
           if (Properties.Settings.Default.WorkOnline) {  cn = new MySqlConnection(MySqlOnlineConnectionString); }else 
            {  cn = new MySqlConnection(MySqlConnectionString); }
           try { cn.Open(); }
           catch (Exception ex) { System.Windows.Forms.MessageBox.Show(ex.Message); }
            return cn;
        }
        public DataSet ResultQuery(string Query)
        {
            using (MySqlConnection cn = GetMySqlActiveConnection())
            {
                DataSet ds = ResultQuery(Query, cn);
                cn.Close(); cn.Dispose();
                return ds;
            }
        }
        public DataSet ResultQuery(string Query, MySqlConnection cn)
        {
            DataSet ds = new DataSet();
            new MySqlDataAdapter(Query, cn).Fill(ds);
            return ds;

        }
        public string ScalarQuery(string Query)
        {
            using (MySqlConnection cn = GetMySqlActiveConnection())
            {

                string s = ScalarQuery(Query, cn);
                cn.Close(); cn.Dispose();
                return s;

            }
        }
        public string ScalarQuery(string Query, MySqlConnection cn)
        {
            return new MySqlCommand(Query, cn).ExecuteScalar().ToString();
        }
        public bool NonQuery(string Query)
        {
            using (MySqlConnection cn = GetMySqlActiveConnection())
            {

                bool s = NonQuery(Query, cn);
                cn.Close(); cn.Dispose();
                return s;

            }
        }
        public bool NonQuery(string Query, MySqlConnection cn)
        {
            try
            {
                new MySqlCommand(Query, cn).ExecuteNonQuery();
                return true;
            }
            catch { return false; }

        }
        public List<string> ColumnQuery(string Query)
        {
            using (MySqlConnection cn = GetMySqlActiveConnection())
            {
                List<string> List = ColumnQuery(Query, cn);
                cn.Close(); cn.Dispose();
                return List;
            }
        }
        public List<string> ColumnQuery(string Query, MySqlConnection cn)
        {
            DataSet ds = new DataSet();
            List<string> List = new List<string>();
            new MySqlDataAdapter(Query, cn).Fill(ds);
            foreach (DataRow r in ds.Tables[0].Rows) { List.Add(r[0].ToString()); }
            return List;

        }
        public List<string> RowQuery(string Query)
        {
            List<string> List = new List<string>();
            using (MySqlConnection cn = GetMySqlActiveConnection())
            {
                DataSet ds = RowQuery(Query, cn);
                cn.Close(); cn.Dispose();

                foreach (DataColumn c in ds.Tables[0].Columns) { List.Add(ds.Tables[0].Rows[0][c].ToString()); }
            }
            return List;
        }
        public DataSet RowQuery(string Query, MySqlConnection cn)
        {
            DataSet ds = new DataSet();
            new MySqlDataAdapter(Query, cn).Fill(ds);
            return ds;

        }
        public static string MySqlTime(DateTime DT)
        {
            return MySqlDateTime(DT).Split(' ')[1];
        }
        public static string MySqlDateTime(DateTime DT)
        {
            string Month = DT.Month.ToString(); if (DT.Month < 10) { Month = "0" + Month; }
            string Day = DT.Day.ToString(); if (DT.Day < 10) { Day = "0" + Day; }
            string Hour = DT.Hour.ToString(); if (DT.Hour < 10) { Hour = "0" + Hour; }
            string Minute = DT.Minute.ToString(); if (DT.Minute < 10) { Minute = "0" + Minute; }
            string Second = DT.Second.ToString(); if (DT.Second < 10) { Second = "0" + Second; }
            return DT.Year.ToString() + "-" + Month + "-" + Day + " " + Hour + ":" + Minute + ":" + Second;

        }
        public static string MySqlDate(DateTime DT) { return MySqlDateTime(DT).Substring(0, 10); }

        public static string MySqlDateTimeStamp()
        {
            DateTime DT = DateTime.Now;
            string Month = DT.Month.ToString(); if (DT.Month < 10) { Month = "0" + Month; }
            string Day = DT.Day.ToString(); if (DT.Day < 10) { Day = "0" + Day; }
            string Hour = DT.Hour.ToString(); if (DT.Hour < 10) { Hour = "0" + Hour; }
            string Minute = DT.Minute.ToString(); if (DT.Minute < 10) { Minute = "0" + Minute; }
            string Second = DT.Second.ToString(); if (DT.Second < 10) { Second = "0" + Second; }

            return DT.Year.ToString() + "-" + Month + "-" + DT.Day.ToString() + "_" + DT.Hour.ToString() + "-" + DT.Minute.ToString() + "-" + DT.Second.ToString();

        }



    }
}
