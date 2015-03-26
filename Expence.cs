using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace SRmobileStore
{
    public partial class Expence : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";
        public Expence()
        {
            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;
            double amo = double.Parse(this.Amount.Text);
            cmmd.CommandText = "insert into Expense(Expense_date,Detail,Amount) values ('" + this.dateTimePicker1.Text + "','" + this.Detail.Text + "'," + amo + ")";
                        
           // MessageBox.Show(s);
            int temp = cmmd.ExecuteNonQuery();

            if (temp > 0)
            {
                cnn.Close();
                cnn.Open();
                cmmd.CommandText = "select * from Daily_summary where Summary_date like '" + this.dateTimePicker1.Text + "'";
                OleDbDataReader reader = cmmd.ExecuteReader();

                if (reader.Read())
                {
                    cnn.Close();
                    cnn.Open();
                    cmmd.CommandText = "update Daily_summary set Total_expense = Total_expense + " + amo + "," + "Net_sale= Net_sale -" + amo + " where Summary_date like '" + this.dateTimePicker1.Text+ "'";

                    int m = cmmd.ExecuteNonQuery();

                    if (m > 0)
                    {
                        MessageBox.Show("Record successfully added");
                    }
                    else
                    {
                        MessageBox.Show("Daily Summary does not updated.");
                    }
                    cnn.Close();
                }
                else
                {
                    cnn.Close();
                    cnn.Open();
                    cmmd.CommandText = "insert into Daily_summary(Summary_date,Total_sale,Total_expense,Net_sale) values ('" + this.dateTimePicker1.Text + "',"+0+","+ amo +",-"+amo+")";
                    int n = cmmd.ExecuteNonQuery();
                    cnn.Close();
                    if (n > 0)
                    {
                        MessageBox.Show("Record successfully added");
                    }
                    else
                    {
                        MessageBox.Show("Not inserted into Daily Summery.");
                    }
                }

                this.Detail.Text = this.Amount.Text = null;
                
            }
            else
            {
                MessageBox.Show("Failed to add");
            }
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter dataadapter2 = new OleDbDataAdapter("SELECT * from Expense where Expense_date like '" + this.dateTimePicker2.Text + "'", cnn);
            DataSet ds2 = new DataSet();
            cnn.Open();
            dataadapter2.Fill(ds2, "Expense_table");
            cnn.Close();
            dataGridView1.DataSource = ds2;
            dataGridView1.DataMember = "Expense_table";
        }
    }
}
