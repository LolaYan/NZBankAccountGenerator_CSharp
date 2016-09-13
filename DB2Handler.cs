using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace BankAccountGenerator
{
    class DB2Handler
    {
        /*
        public void ConnectDB2()
        {
            string strSql = @"select phone_no from no_store where id<5";
            string strConn = "Database=数据库名;UID=用户名;PWD=密码;";
            using (DB2Connection conn = new DB2Connection(strConn))
            {
                DB2Command cmd = new DB2Command(strSql, conn);
                try
                {
                    conn.Open();
                    DB2DataAdapter adp = new DB2DataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    if (dt != null)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Console.WriteLine("电话" + i + ":" + dt.Rows[i][0].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Read();
        }

        public void InsertRow(string myConnectionString)
        {
            string strSql = @"select phone_no from no_store where id<5";
            string strConn = "Provider=IBMDADB2;Data Source=数据库名;UID=用户名;PWD=密码;";
            using (OleDbConnection conn = new OleDbConnection(strConn))
            {
                OleDbCommand cmd = new OleDbCommand(strSql, conn);
                try
                {
                    conn.Open();
                    OleDbDataAdapter adp = new OleDbDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    adp.Fill(ds);
                    DataTable dt = ds.Tables[0];

                    if (dt != null)
                    {
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            Console.WriteLine("电话" + i + ":" + dt.Rows[i][0].ToString());
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.Read();
        }
         * 
         * */
    }
}
