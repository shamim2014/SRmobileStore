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
    public partial class Daily_sammury : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";
 
        public Daily_sammury()
        {
            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);

            InitializeComponent();

            OleDbDataAdapter dataadapter1 = new OleDbDataAdapter("SELECT * from Daily_summary ", cnn);
            DataSet ds1 = new DataSet();
            cnn.Open();
            dataadapter1.Fill(ds1, "Summary_table");
            cnn.Close();
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = "Summary_table";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter dataadapter2 = new OleDbDataAdapter("SELECT * from Daily_summary where Summary_date like '" + this.dateTimePicker1.Text + "'", cnn);
            DataSet ds2 = new DataSet();
            cnn.Open();
            dataadapter2.Fill(ds2, "Employee_search_table");
            cnn.Close();
            dataGridView2.DataSource = ds2;
            dataGridView2.DataMember = "Employee_search_table";
        }
    }
}
