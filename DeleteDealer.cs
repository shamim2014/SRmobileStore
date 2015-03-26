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
    public partial class DeleteDealer : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public DeleteDealer()
        {

            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);
            InitializeComponent();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;
            cmmd.CommandText = "delete from Dealer where Dealer_id = '" + this.textBox1.Text + "'";
            int temp = cmmd.ExecuteNonQuery();

            if (temp > 0)
            {
                cnn.Close();
                MessageBox.Show("Dealer has been deleted");
            }
            else
            {
                cnn.Close();
                MessageBox.Show("DEALER does not deleted");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
