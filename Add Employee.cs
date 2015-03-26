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
    public partial class Add_Employee : Form
    {
        private OleDbConnection cnn;
        private OleDbCommand cmmd;
        private String path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\user\Documents\Visual Studio 2008\Projects\SRmobileStore\mobileShop.mdb.mdb;Persist Security Info=False";
        private String sex = null;

        public Add_Employee()
        {
            cnn = new OleDbConnection(path);
            cmmd = new OleDbCommand();
            InitializeComponent();
        }

        private void Add_Employee_Load(object sender, EventArgs e)
        {
            
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            cnn.Open();
            cmmd.Connection = cnn;

            cmmd.CommandText = "insert into Employee(Employee_id,Employee_name,Address,Sex,Dob,Designation,Experience,Doj,Salary) values ('" + this.Employee_id.Text + "','" + this.Employee_name.Text + "','" + this.Address.Text + "','" + sex + "','" + this.Dob.Text + "','" + this.Designation.Text + "'," + Double.Parse(this.Experience.Text) + ",'" + this.Doj.Text + "'," + Double.Parse(this.Salary.Text) + ")";
           
            if (this.Employee_id.Text != null)
            {
                int temp = cmmd.ExecuteNonQuery();

                if (temp > 0)
                {
                    this.Employee_id.Text = this.Employee_name.Text = this.Address.Text = null;
                    this.Designation.Text = this. Salary.Text = this.Experience.Text=null;
                    sex = null;
                    MessageBox.Show("Record successfully added");
                }
                else
                {
                    MessageBox.Show("Failed to add");
                }

            }
            else
            {
                MessageBox.Show("Employee Id can not be empty.");
            }
            cnn.Close();
        }

        private void Dob_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Designation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Experience_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void M_CheckedChanged(object sender, EventArgs e)
        {
            sex = this.M.Text;
        }

        private void F_CheckedChanged(object sender, EventArgs e)
        {
            sex = this.F.Text;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
