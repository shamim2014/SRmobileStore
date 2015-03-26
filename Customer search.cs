using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace SRmobileStore
{
    public partial class Customer_search : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public Customer_search()
        {
            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;

            cmmd.CommandText = "SELECT * from Customer where Customer_id = '" + this.textBox1.Text + "'";
            OleDbDataReader reader = cmmd.ExecuteReader();

            if (reader.Read())
            {
                cnn.Close();
                cnn.Open();
                cmmd.Connection = cnn;

                OleDbDataAdapter dataadapter = new OleDbDataAdapter("SELECT * from Customer where Customer_id = '" + this.textBox1.Text + "'", cnn);
                DataSet ds = new DataSet();
                cnn.Close();
                cnn.Open();
                dataadapter.Fill(ds, "Cus_search_table");
                cnn.Close();
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Cus_search_table";
            }
            else
            {
                MessageBox.Show("Customer Not found in table");
            }
        }
    }
}
