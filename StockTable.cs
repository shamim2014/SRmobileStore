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
    public partial class StockTable : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public StockTable()
        {
            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);
            

            InitializeComponent();

            OleDbDataAdapter dataadapter = new OleDbDataAdapter("SELECT * from Stock", cnn);
            DataSet ds = new DataSet();
            cnn.Open();
            dataadapter.Fill(ds, "Stock_table");
            cnn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Stock_table";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void StockTable_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            //cnn.Open();
            //cmmd.Connection = cnn;
            //cmmd.CommandText = "select * from Stock where Serial_no= '" + this.textBox1.Text + "' and " + "Model= '" + this.textBox2.Text + "'";

            //OleDbDataReader reader = cmmd.ExecuteReader();

            //if (reader.Read())
            //{
            //    cnn.Close();
            //    cmmd.CommandText = "delete from Stock where Serial_no like '" + this.textBox1.Text + "' and Model like '" + this.textBox2.Text + "'";
            //    cnn.Open();
            //    int temp = cmmd.ExecuteNonQuery();

            //    if (temp > 0)
            //    {
            //        MessageBox.Show("Item has been deleted.");
            //        this.Close();
            //        new StockTable().Show();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Item does not deleted.");
            //    }
            //    cnn.Close();
            //}
            //else
            //{
            //    MessageBox.Show("There is no such Item in Stock.");
            //}
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new StockEdit(this.textBox1.Text, this.textBox2.Text).Show(); 
        }
    }
}
