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
    public partial class Sales : Form
    {
        private OleDbConnection cnn;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public Sales()
        {
            cnn = new OleDbConnection(path);

            InitializeComponent();
            OleDbDataAdapter dataadapter1 = new OleDbDataAdapter("SELECT * from Sales", cnn);
            DataSet ds1 = new DataSet();
            cnn.Open();
            dataadapter1.Fill(ds1, "Purchase_table1");
            cnn.Close();
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = "Purchase_table1";

            //Group by Model
            OleDbDataAdapter dataadapter2 = new OleDbDataAdapter("SELECT * from(SELECT Model,sum(Quantity) as quantity,sum(Total_price) as total_sale from Sales group by Model) order by quantity", cnn);
            DataSet ds2 = new DataSet();
            cnn.Open();
            dataadapter2.Fill(ds2, "Purchase_table2");
            cnn.Close();
            dataGridView2.DataSource = ds2;
            dataGridView2.DataMember = "Purchase_table2";

            
            //Group by Price
            OleDbDataAdapter dataadapter3 = new OleDbDataAdapter("SELECT * from(SELECT Price,sum(Quantity) as quantity from Sales group by Price) order by quantity", cnn);
            DataSet ds3 = new DataSet();
            cnn.Open();
            dataadapter3.Fill(ds3, "Purchase_table3");
            cnn.Close();
            dataGridView3.DataSource = ds3;
            dataGridView3.DataMember = "Purchase_table3";


            //Group by Company name
            OleDbDataAdapter dataadapter4 = new OleDbDataAdapter("SELECT * from(SELECT Company_name,sum(Quantity) as quantity from Sales group by Company_name) order by quantity", cnn);
            DataSet ds4 = new DataSet();
            cnn.Open();
            dataadapter3.Fill(ds4, "Purchase_table4");
            cnn.Close();
            dataGridView4.DataSource = ds4;
            dataGridView4.DataMember = "Purchase_table4";
          
        }

        private void Sales_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
