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
    public partial class SystemControl : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public SystemControl()
        {
            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);

            InitializeComponent();
        }

        private void SystemControl_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;
            cmmd.CommandText = "select Password from Login where User_name = '" + this.textBox1.Text + "'";

            OleDbDataReader reader = cmmd.ExecuteReader();

            if (reader.Read())
            {
                MessageBox.Show("User name exit\nplease enter another user name");
            }
            else
            {
                cnn.Close();
                cnn.Open();
                cmmd.Connection = cnn;
                cmmd.CommandText = "insert into Login values ('" + this.textBox1.Text + "', '" + this.textBox2.Text + "')";


                if (this.textBox1.Text != null && this.textBox2.Text != null)
                {

                    int temp = cmmd.ExecuteNonQuery();


                    if (temp > 0)
                    {
                        MessageBox.Show("User successfully created");
                    }
                    else
                    {
                        MessageBox.Show("User does not created");
                    }
                }

            }
            cnn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;
            cmmd.CommandText = "delete from Login where User_name like '" + this.textBox3.Text + "'";
            int temp = cmmd.ExecuteNonQuery();

            cmmd.CommandText = "insert into Login values ('" + this.textBox3.Text + "', '" + this.textBox4.Text + "')";

            int tmp = cmmd.ExecuteNonQuery();

            if (temp > 0 && tmp > 0)
            {
                cnn.Close();
                MessageBox.Show("Password Changes");
            }
            else
            {
                cnn.Close();
                MessageBox.Show("PassWord does not changed");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String p = "Admin";

            if (p.Equals(this.textBox5.Text))
            {
                MessageBox.Show("Admin can no be deleted");
            }
            else
            {
                cnn.Open();
                cmmd.Connection = cnn;
                cmmd.CommandText = "delete from Login where User_name like '" + this.textBox5.Text + "'";
                int temp = cmmd.ExecuteNonQuery();

                if (temp > 0)
                {
                    cnn.Close();
                    MessageBox.Show("User has been deleted");
                }
                else
                {
                    cnn.Close();
                    MessageBox.Show("User does not deleted");
                }

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            new Home().Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
             String p ="Admin";

             if (p.Equals(this.textBox5.Text))
             {
                 MessageBox.Show("Admin can no be deleted");
             }
             else
             {
                 cnn.Open();
                 cmmd.Connection = cnn;
                 cmmd.CommandText = "delete from Login where User_name like '" + this.textBox5.Text + "'";
                 int temp = cmmd.ExecuteNonQuery();

                 if (temp > 0)
                 {
                     cnn.Close();
                     MessageBox.Show("User has been deleted");
                 }
                 else
                 {
                     cnn.Close();
                     MessageBox.Show("User does not deleted");
                 }
             }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            new Home().Show();
        }
    }
}
