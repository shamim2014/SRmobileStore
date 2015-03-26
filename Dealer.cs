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
    public partial class Dealer : Form
    {
        private OleDbConnection connection;
        private OleDbCommand command;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public Dealer()
        {
            command = new OleDbCommand();
            connection = new OleDbConnection(path);
            InitializeComponent();
        }

        private void Dealer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            connection.Open();
            command.Connection = connection;
            command.CommandText = "insert into Dealer(Dealer_id,Dealer_name,Address,Mobile,Email,Total_Purchase,Total_Payment,Due) values ('" + this.Id.Text + "','" + this.name.Text + "','" + this.Address.Text + "','" + this.Mobile.Text + "','" + this.Email.Text + "'," +0.00+ "," + 0 + "," + 0 +")";

            if (this.Id.Text != null)
            {
                int temp = command.ExecuteNonQuery();

                if (temp > 0)
                {
                    this.Id.Text = this.name.Text = this.Address.Text = null;
                    this.Mobile.Text = this.Email.Text = null;
                    MessageBox.Show("Record successfully added");
                }
                else
                {
                    MessageBox.Show("Failed to add");
                }

            }
            else
            {
                MessageBox.Show("Dealer Id can not be empty.");
            }
            connection.Close();

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
