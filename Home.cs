using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SRmobileStore
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dailtSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            new Daily_sammury().Show();
        }

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            new New_Purchase().ShowDialog();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            new Customer().ShowDialog();
        }

        private void newBillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            new Bill().ShowDialog();
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            new Add_Employee().ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void expenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = false;
            new Expence().Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // this.Visible = false;
            new Sales().Show();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dealer().ShowDialog();
        }

        private void empProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Empolyee_Profile().Show();
        }

        private void rezaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StockTable().Show();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void detailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Purchase_detail().Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Login().Show();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new DealerInfo().Show();
        }

        private void cusProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Customer_search().Show();
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Empolyee_Profile().Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Dealer_Search().Show();
        }

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StockTable().Show();
        }

        private void cheakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Bill_info().Show();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Empolyee_Profile().Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new StockTable().Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new DeleteDealer().Show();
        }
    }
}
