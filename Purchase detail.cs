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
    public partial class Purchase_detail : Form
    {
        private OleDbConnection cnn;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public Purchase_detail()
        {

            cnn = new OleDbConnection(path);

            InitializeComponent();

            OleDbDataAdapter dataadapter = new OleDbDataAdapter("SELECT * from Purchase order by Serial_no", cnn);
            DataSet ds = new DataSet();
            cnn.Open();
            dataadapter.Fill(ds, "Purchase_table");
            cnn.Close();
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "Purchase_table";
        }

        private void Purchase_detail_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
