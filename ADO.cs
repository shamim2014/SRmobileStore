using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Text;

namespace SRmobileStore
{
    class ADO
    {
        public class ConnectionManager
        {

            public static OleDbConnection GetSqlConnection()
            {
                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";
                OleDbConnection conn = new OleDbConnection(connectionString);
                conn.Open();
                return conn;
            }
        }

        public bool Insert_Purchase(EntityClass ec)
        {
            OleDbConnection conn = ConnectionManager.GetSqlConnection();
            string query = "insert into Purchase(Serial_no,Purchase_date,Dealer_id,Company_name,Model,Warranty,Quantity,Price,Total,Payment,Due) values('" + ec.P_id + "','" + ec.P_date + "','" + ec.P_did + "','" + ec.P_company + "','" + ec.P_Model + "','" + ec.P_warrenty + "','" + ec.P_qty + "','" + ec.P_price + "','" + ec.P_total + "','" + ec.P_payment + "','" + ec.P_due + "')";
            OleDbCommand comm = new OleDbCommand(query, conn);
            if (comm.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }


        public OleDbDataReader SearchData_Vendor(string id)
        {

            OleDbConnection conn = ConnectionManager.GetSqlConnection();
            string query = "select Dealer_id from Dealer where Dealer_id like('" + id + "')";
            OleDbCommand comm = new OleDbCommand(query, conn);
            OleDbDataReader reader = comm.ExecuteReader();
            return reader;
        }
    }
}
