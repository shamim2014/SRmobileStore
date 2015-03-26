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
    public partial class DealerInfo : Form
    {
        private OleDbConnection cnn;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public DealerInfo()
        {
            cnn = new OleDbConnection(path);

            InitializeComponent();

            OleDbDataAdapter dataadapter = new OleDbDataAdapter("SELECT * from Dealer",cnn);
            DataSet ds = new DataSet();
            cnn.Open();
            dataadapter.Fill(ds,"Dealer_table");
            cnn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember="Dealer_table";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DealerInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
