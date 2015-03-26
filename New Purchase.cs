using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace SRmobileStore
{
    public partial class New_Purchase : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";

        public New_Purchase()
        {
            cmmd = new OleDbCommand();
            cnn = new OleDbConnection(path);
            InitializeComponent();
        }

        private void New_Purchase_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;
            double war = double.Parse(this.Warranty.Text);
            double quan = double.Parse(this.Quantity.Text);
            double pric = double.Parse(this.Price.Text);
            double pay = double.Parse(this.Payment.Text);
            double total = pric * quan;
            double due = total - pay;
            
            cmmd.CommandText = "select * from Dealer where Dealer_id = '"+this.Dealer_id.Text+"'";
            OleDbDataReader reader = cmmd.ExecuteReader();


            if (reader.Read())
            {
                cnn.Close();
                cnn.Open();
                cmmd.Connection = cnn;
                cmmd.CommandText = "insert into Purchase(Serial_no,Purchase_date,Dealer_id,Company_name,Model,Warranty,Quantity,Price,Total,Payment,Due) values ('" + this.Serial_no.Text + "','" + this.dateTimePicker1.Text + "','" + this.Dealer_id.Text + "','" + this.Company_name.Text + "','" + this.Model.Text + "'," + war + "," + quan + "," + pric + "," + total + "," + pay + "," + due + ")";

                if (this.Serial_no.Text != null && this.Model.Text != null)
                {
                    int temp = cmmd.ExecuteNonQuery();

                    if (temp > 0)
                    {
                        cmmd.CommandText = "insert into Stock(Serial_no,Company_name,Model,Stock_date,Warranty,Quantity,Price) values ('" + this.Serial_no.Text + "','" + this.Company_name.Text + "','" + this.Model.Text + "','" + this.dateTimePicker1.Text+"',"+war+"," +quan + "," + pric*1.25+")";
                        
                        int m = cmmd.ExecuteNonQuery();
                        if (m > 0)
                        {
                           
                            cmmd.CommandText = "update Dealer set Total_purchase = Total_purchase+"+total+",Total_payment=Total_payment+"+pay+",Due=Due+"+due+" where Dealer_id = "+"'"+this.Dealer_id.Text+"'";
      

                            int n = cmmd.ExecuteNonQuery();
                            if (n > 0)
                            {
                                MessageBox.Show("Record successfully added");
                            }
                            else
                            {
                                MessageBox.Show("Dealer table do not updated.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Do not inserted into Stock");
                        }
                         this.Model.Text = this.Dealer_id.Text = this.Company_name.Text = null;
                         this.Warranty.Text = this.Quantity.Text = this.Price.Text = this.Payment.Text = null;
                       
                    }
                    else
                    {
                        MessageBox.Show("Failed to add");
                    }
    
                    cnn.Close();
                }
                else
                {
                    MessageBox.Show("Serial no and Model can not be empty.");
                }

            }
            else
            {
                MessageBox.Show("Fill up Dealer information");
                new Dealer().ShowDialog();
                cnn.Close();
            }
            


            //EntityClass ec = new EntityClass();
            //ec.P_id = ID.Text;
            //ec.P_did = dealerID.Text;
            //ec.P_company = Company.Text;
            //ec.P_Model = Model.Text;
            //ec.P_date = dateTimePicker1.Text;
            //ec.P_warrenty = warrenty.Text;
            //ec.P_qty = Convert.ToDouble(qty.Text);
            //ec.P_price = Convert.ToDouble(price.Text);
            //ec.P_payment = Convert.ToDouble(payment.Text);

            //// double war = double.Parse(this.textBox5.Text);
            //double quan = Convert.ToDouble(qty.Text);
            //double pric = Convert.ToDouble(price.Text);

            //double pay = Convert.ToDouble(payment.Text);
            //double total = pric * quan;
            //double due = total - pay;

            //ec.P_total = total;
            //ec.P_due = due;

            //ADO a = new ADO();
            //if (a.Insert_Purchase(ec) == true)
            //{
            //    MessageBox.Show("ok");
            //}
            //else
            //{
            //    label1.Text = "0";

            //}

            //if (label1.Text == "")
            //{
            //    Dealer d = new Dealer();
            //    d.Show();

            //}

            //if (label1.Text != "")
            //{
            //    ADO a = new ADO();
            //    if (a.Insert_Purchase(ec))
            //    {
            //        MessageBox.Show("ok");
            //    }
            //}




        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //new Home().Visible = true;
            this.Visible = false;
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        //private void dealerID_KeyUp(object sender, KeyEventArgs e)
        //{
        //    ADO a = new ADO();
        //    OleDbDataReader reader = a.SearchData_Vendor(dealerID.Text);
        //    while (reader.Read())
        //    {
        //        label1.Text = reader.GetString(0);
                
        //    }
            
        //}
    }
}
