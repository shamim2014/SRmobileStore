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
    public partial class StockEdit : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";
        String s1,s2;
        public StockEdit(String str1, String str2)
        {
            s2 = str2;
            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);
            InitializeComponent();
            OleDbDataAdapter dataadapter = new OleDbDataAdapter("SELECT * from Stock where Serial_no= '" + str1 + "' and " + "Model= '" + str2+ "'", cnn);
            DataSet ds = new DataSet();
            cnn.Open();
            dataadapter.Fill(ds, "Stock_table");
            cnn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Stock_table";
            s1=str1;
            
        }

        private void StockEdit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String info = this.textBox1.Text;

            cnn.Open();
            cmmd.Connection = cnn;
            int n, p, m, q, r;
            n = m = q = r = p = 0;
            if (this.textBox1.Text != null)
            {
                cmmd.CommandText = "update Stock set Company_name = '" + this.textBox1.Text + "' where Serial_no like '" + s1 + "' and Model like '" + s2 + "'";
                 n = cmmd.ExecuteNonQuery();
                 n = 1;

            }
            if (this.textBox2.Text != null)
            {
                String s = this.textBox2.Text;
                double t=double.Parse(s);
                cmmd.CommandText = "update Stock set Warranty = " + t + " where Serial_no like '" + s1 + "' and Model like '" + s2 + "'";
                m = cmmd.ExecuteNonQuery();


            }
            if (this.textBox3.Text != null)
            {
                String s = this.textBox3.Text;
                double t = Convert.ToDouble(s);
                
                cmmd.CommandText = "update Stock set Quantity = " + t + " where Serial_no like '" + s1 + "' and Model like '" + s2 + "'";
               p = cmmd.ExecuteNonQuery();


            }
            if (this.textBox4.Text != null)
            {
                String s = this.textBox2.Text;
                double t = Convert.ToDouble(s);
                
                cmmd.CommandText = "update Stock set Price = " + t + " where Serial_no like '" + s1 + "' and Model like '" + s2 + "'";
                 q = cmmd.ExecuteNonQuery();


            }
            if (this.dateTimePicker1.Text != null)
            {
                cmmd.CommandText = "update Stock set Stock_date= '" + this.dateTimePicker1.Text + "' where Serial_no like '" + s1 + "' and Model like '" + s2 + "'";
                 r = cmmd.ExecuteNonQuery();

            }
            cnn.Close();
            if((n>0)||(q>0)||(r>0)||(n>0)||(m>0))
            {
                MessageBox.Show("Successed");
            }
            else
            {
                MessageBox.Show("Fail");
            }
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
