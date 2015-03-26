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
    public partial class Bill : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public Bill()
        {
            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);
            InitializeComponent();
            cnn.Open();
            cmmd.Connection = cnn;
            cmmd.CommandText = "Select max(Bill_no) from Bill";
            OleDbDataReader reader = cmmd.ExecuteReader();

            if (reader.Read())
            {
                String s=reader[0].ToString();
                double m = 1;

                if (s == null)
                {
                    this.textBox1.Text = "" + m + "";
                }
                else
                {
                    m = Convert.ToDouble(s);
                    m++;
                    this.textBox1.Text = "" + m + "";
                }
                
            }
           
            cnn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Print_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;
            cmmd.CommandText = "select * from Customer where Customer_id= '"+this.Cus_id.Text+"'";
            OleDbDataReader reader = cmmd.ExecuteReader();
            int k = 0;
            int n = 0;
            if (reader.Read())
            {
                cnn.Close();
                double war = double.Parse(this.Warranty.Text);
                double quan = double.Parse(this.Quantity.Text);
                double pric = double.Parse(this.Price.Text);
                double pay = double.Parse(this.Payment.Text);
                double total = pric * quan;
                double due = total - pay;

                cnn.Open();
                cmmd.CommandText ="insert into Bill(Bill_no,Bill_date,Customer_id,Serial_no,Company_name,Model,Warranty,Price,Quantity,Total_amount,Payment,Due) values ('" + this.textBox1.Text + "','" + this.dateTimePicker1.Text + "','" + this.Cus_id.Text + "','"+this.Serial_no.Text+"','" + this.Company_name.Text + "','" + this.Model.Text + "'," + war + "," + pric + "," + quan + "," + total + "," + pay + "," + due + ")";
                int temp = cmmd.ExecuteNonQuery();

                if (temp > 0)
                {


                    cmmd.CommandText = "update Stock set Quantity = Quantity-" + quan + " where Serial_no= '" + this.Serial_no.Text + "' and " + "Model= '" + this.Model.Text + "'";
                    int m = cmmd.ExecuteNonQuery();
                    if (m > 0)
                    {
                        cnn.Close();
                        cmmd.CommandText = "select * from Sales where Sales_date like'" + this.dateTimePicker1.Text + "' and Serial_no = '" + this.Serial_no.Text + "' and Model = '" + this.Model.Text + "' and Customer_id = '" + this.Cus_id.Text + "'";
                        
                        
                        cnn.Open();
                        cmmd.Connection = cnn;
                        OleDbDataReader r1 = cmmd.ExecuteReader();
                 

                        if (r1.Read())
                        {
                            cnn.Close();
                            cmmd.CommandText = "update Sales set Quantity= Quantity +"+ quan+ ",Total_price= Total_price +" + total + " where Sales_date like '" + this.dateTimePicker1.Text + "' and Serial_no = '" + this.Serial_no.Text + "' and Model = '" + this.Model.Text + "' and Customer_id = '" + this.Cus_id.Text + "'";
                            cnn.Open();
                            k = cmmd.ExecuteNonQuery();
                            cnn.Close();
                            if (k <= 0)
                            {
                                MessageBox.Show("Sales does not updated.");
                            }
                        }
                        else
                        {
                            cnn.Close();
                            cnn.Open();
                            cmmd.CommandText = "insert into Sales(Sales_date,Serial_no,Customer_id,Company_name,Model,Price,Quantity,Total_price) values ('" + this.dateTimePicker1.Text + "','" + this.Serial_no.Text + "','" + this.Cus_id.Text + "','" + this.Company_name.Text + "','" + this.Model.Text + "'," + pric + "," + quan + "," + total + ")";
                            n = cmmd.ExecuteNonQuery();

                            if (n <= 0)
                            {
                                MessageBox.Show("Sales does not inserted.");
                            }
                        }
                        if (n >0||k>0)
                        {
                            cnn.Close();
                            cnn.Open();
                            cmmd.CommandText = "select * from Daily_summary where Summary_date like '" + this.dateTimePicker1.Text + "'";
                            OleDbDataReader r = cmmd.ExecuteReader();

                            if (r.Read())
                            {
                                cnn.Close();
                                cnn.Open();
                                cmmd.Connection = cnn;
                                cmmd.CommandText = "update Daily_summary set Total_sale = Total_sale + " + total + " , Net_sale = Net_sale + "+total+" where Summary_date like '" + this.dateTimePicker1.Text + "'";

                                int p = cmmd.ExecuteNonQuery();

                                if (p > 0)
                                {
                                    MessageBox.Show("Successfully printed.");
                                    this.Close();
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
                                cmmd.CommandText = "insert into Daily_summary(Summary_date,Total_sale,Total_expense,Net_sale) values ('" + this.dateTimePicker1.Text + "'," + total + "," + 0 + "," +total+ ")";
                                int q = cmmd.ExecuteNonQuery();
                                cnn.Close();
                                if (q > 0)
                                {
                                    MessageBox.Show("Successfully printed.");
                                    this.Close();
                                }
                                else
                                {
                                    MessageBox.Show("Not inserted into Daily Summery.");
                                }
                            }

                            
                        }
                        else
                        {
                            MessageBox.Show("Does not inserted into sales table.");
                            cnn.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Stock table does not updated");
                        this.Close();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Bill table do not updated.");
                }
                cnn.Close();                 
            }
            else
            {
                MessageBox.Show("Fill up the Customer information");
                new Customer().ShowDialog();
                cnn.Close();
            }
            
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Company_name_MouseClick(object sender, MouseEventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;
            cmmd.CommandText = "Select Company_name from Stock where Serial_no= '"+this.Serial_no.Text+"' and "+"Model= '"+this.Model.Text+"'";
            OleDbDataReader reader = cmmd.ExecuteReader();

            if (reader.Read())
            {
                this.Company_name.Text = reader[0].ToString();
            }
            else
            {
                MessageBox.Show("No such a product in Stock\nInvalid Serial or Model");
            }
            cnn.Close();
        }

        private void Bill_Load(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void Warranty_MouseClick(object sender, MouseEventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;
            cmmd.CommandText = "Select Warranty from Stock where Serial_no= '" + this.Serial_no.Text + "' and " + "Model= '" + this.Model.Text + "'";
            OleDbDataReader reader = cmmd.ExecuteReader();

            if (reader.Read())
            {
                this.Warranty.Text = reader[0].ToString();
            }
            else
            {
                MessageBox.Show("No such a product in Stock\nInvalid Serial or Model");
            }
            cnn.Close();
        }

        private void Price_MouseClick(object sender, MouseEventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;
            cmmd.CommandText = "Select  Price from Stock where Serial_no= '" + this.Serial_no.Text + "' and " + "Model= '" + this.Model.Text + "'";
            OleDbDataReader reader = cmmd.ExecuteReader();

            if (reader.Read())
            {
                this.Price.Text = reader[0].ToString();
            }
            else
            {
                MessageBox.Show("No such a product in Stock\nInvalid Serial or Model");
            }
            cnn.Close();
        }

        private void Total_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (this.Price.Text != null && this.Quantity.Text != null)
            {
                cnn.Open();
                cmmd.Connection = cnn;
                cmmd.CommandText = "Select Quantity from Stock where Serial_no= '" + this.Serial_no.Text + "' and " + "Model= '" + this.Model.Text + "'";
                OleDbDataReader reader = cmmd.ExecuteReader();

                if (reader.Read())
                {
                    double value = double.Parse(reader[0].ToString());
                    double pric = double.Parse(this.Price.Text);
                    double quan = double.Parse(this.Quantity.Text);

                    if (value >= quan)
                    {
                        this.Total.Text = "" + pric * quan + "";
                    }
                    else
                    {
                        MessageBox.Show("Maximum available quantity "+value);
                    }
                }
                else
                {
                    MessageBox.Show("No such a product in Stock\nInvalid Serial or Model");
                }
                cnn.Close();
                
            }
            else
            {
                MessageBox.Show("Fill Quantity and Click on Price box");
            }
        }

        private void Due_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.Payment.Text != null && this.Total.Text != null)
            {
                double pric = double.Parse(this.Price.Text);
                double quan = double.Parse(this.Quantity.Text);
                double t = pric * quan;
                double p = double.Parse(this.Payment.Text);
                t -= p;
                this.Due.Text = "" + t + "";
            }
            else
            {
                MessageBox.Show("Fill up the payment box");
            }
        }

        private void Company_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void Due_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
