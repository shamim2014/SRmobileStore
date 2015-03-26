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
    public partial class Login : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public Login()
        {
            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;

            cmmd.CommandText = "select Password from Login where User_name = '" + this.textBox1.Text + "'";
            OleDbDataReader reader = cmmd.ExecuteReader();

            if (reader.Read())
            {
                String pass = reader[0].ToString();

                if (pass.Equals(this.passwordBox.Text))
                {
                    cnn.Close();
                    cnn.Open();
                    cmmd.CommandText = "select Password from Login where User_name = 'Admin'";
                    reader = cmmd.ExecuteReader();

                    if (reader.Read())
                    {
                        String passA = reader[0].ToString();

                        if (passA.Equals(this.passwordBox.Text))
                        {
                            cnn.Close();
                            new SystemControl().Show();
                        }
                        else
                        {
                            cnn.Close();
                            new Home().Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No data as a Admin in Login table");
                    }
                    
                }
                else
                {
                    MessageBox.Show("Error in user name or password");
                }
                cnn.Close();

            }
            else
            {
                MessageBox.Show("No data in Login table");
            }
                    
            
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
