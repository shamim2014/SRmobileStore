using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SRmobileStore
{
    public partial class Bill_info : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";
        
        public Bill_info()
        {
            cnn = new OleDbConnection(path);
            cmmd = new OleDbCommand();
            InitializeComponent();
            OleDbDataAdapter dataadapter1 = new OleDbDataAdapter("SELECT * from Bill", cnn);
            DataSet ds1 = new DataSet();
            cnn.Open();
            dataadapter1.Fill(ds1, "Bill_table1");
            cnn.Close();
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = "Bill_table1";

        }

        private void Bill_info_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;

            cmmd.CommandText = "SELECT * from Bill where Bill_no = " + this.textBox1.Text + "";
            OleDbDataReader reader = cmmd.ExecuteReader();

            if (reader.Read())
            {
                cnn.Close();
                cnn.Open();
                cmmd.Connection = cnn;

                OleDbDataAdapter dataadapter2 = new OleDbDataAdapter("SELECT * from Bill where Bill_no = " + this.textBox1.Text + "", cnn);
                DataSet ds2 = new DataSet();
                cnn.Close();
                cnn.Open();
                dataadapter2.Fill(ds2, "Bill_search_table");
                cnn.Close();
                dataGridView3.DataSource = ds2;
                dataGridView3.DataMember = "Bill_search_table";
            }
            else
            {
                MessageBox.Show("Bill Not found in table");
            }
        }
    }
}
