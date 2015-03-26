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
    public partial class Empolyee_Profile : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public Empolyee_Profile()
        {
            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);
            InitializeComponent();

            OleDbDataAdapter dataadapter = new OleDbDataAdapter("SELECT * from Employee", cnn);
            DataSet ds = new DataSet();
            cnn.Open();
            dataadapter.Fill(ds, "Employee_table");
            cnn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Employee_table";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Empolyee_Profile_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbDataAdapter dataadapter2 = new OleDbDataAdapter("SELECT * from Employee where Employee_id = '" + this.textBox1.Text + "'", cnn);
            DataSet ds2 = new DataSet();
            cnn.Open();
            dataadapter2.Fill(ds2, "Employee_search_table");
            cnn.Close();
            dataGridView2.DataSource = ds2;
            dataGridView2.DataMember = "Employee_search_table";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;
            cmmd.CommandText = "delete from Employee where Employee_id = '" + this.textBox1.Text + "'";
            int temp = cmmd.ExecuteNonQuery();

            if (temp > 0)
            {
                cnn.Close();
                MessageBox.Show("Employee has been deleted");
            }
            else
            {
                cnn.Close();
                MessageBox.Show("Employee does not deleted");
            }
        }
    }
}
