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
    public partial class Customer : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public Customer()
        {
            cnn = new OleDbConnection(path);
            cmmd = new OleDbCommand();
            InitializeComponent();
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Insert_Click(object sender, EventArgs e)
        {

            cnn.Open();
            cmmd.Connection = cnn;
            cmmd.CommandText = "insert into Customer(Customer_id,Customer_name,Address,Mobile,Email) values ('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "')";

            if (this.textBox1.Text != null)
            {
                int temp = cmmd.ExecuteNonQuery();

                if (temp > 0)
                {
                    this.textBox1.Text = this.textBox2.Text = this.textBox3.Text = null;
                    this.textBox4.Text = this.textBox5.Text = null;
                    MessageBox.Show("Record successfully added");
                }
                else
                {
                    MessageBox.Show("Failed to add");
                }

            }
            else
            {
                MessageBox.Show("Customer Id can not be empty.");
            }
            cnn.Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
