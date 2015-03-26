namespace SRmobileStore
{
    partial class Bill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Bill_no = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Date = new System.Windows.Forms.Label();
            this.Cus_id = new System.Windows.Forms.TextBox();
            this.Customer_id = new System.Windows.Forms.Label();
            this.Serial_no = new System.Windows.Forms.TextBox();
            this.Company_name = new System.Windows.Forms.TextBox();
            this.Model = new System.Windows.Forms.TextBox();
            this.Warranty = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.Payment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Due = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Print = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Highlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(461, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Recitpt";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Bill_no
            // 
            this.Bill_no.AutoSize = true;
            this.Bill_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bill_no.Location = new System.Drawing.Point(46, 106);
            this.Bill_no.Name = "Bill_no";
            this.Bill_no.Size = new System.Drawing.Size(53, 20);
            this.Bill_no.TabIndex = 1;
            this.Bill_no.Text = "Bill No";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(142, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(72, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(795, 125);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(211, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(716, 126);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(44, 20);
            this.Date.TabIndex = 4;
            this.Date.Text = "Date";
            // 
            // Cus_id
            // 
            this.Cus_id.Location = new System.Drawing.Point(142, 172);
            this.Cus_id.Name = "Cus_id";
            this.Cus_id.Size = new System.Drawing.Size(72, 20);
            this.Cus_id.TabIndex = 5;
            // 
            // Customer_id
            // 
            this.Customer_id.AutoSize = true;
            this.Customer_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_id.Location = new System.Drawing.Point(12, 172);
            this.Customer_id.Name = "Customer_id";
            this.Customer_id.Size = new System.Drawing.Size(99, 20);
            this.Customer_id.TabIndex = 6;
            this.Customer_id.Text = "Customer ID";
            // 
            // Serial_no
            // 
            this.Serial_no.Location = new System.Drawing.Point(12, 308);
            this.Serial_no.Name = "Serial_no";
            this.Serial_no.Size = new System.Drawing.Size(63, 20);
            this.Serial_no.TabIndex = 7;
            // 
            // Company_name
            // 
            this.Company_name.Location = new System.Drawing.Point(211, 308);
            this.Company_name.Name = "Company_name";
            this.Company_name.ReadOnly = true;
            this.Company_name.Size = new System.Drawing.Size(109, 20);
            this.Company_name.TabIndex = 8;
            this.Company_name.TextChanged += new System.EventHandler(this.Company_name_TextChanged);
            this.Company_name.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Company_name_MouseClick);
            // 
            // Model
            // 
            this.Model.Location = new System.Drawing.Point(115, 308);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(64, 20);
            this.Model.TabIndex = 9;
            // 
            // Warranty
            // 
            this.Warranty.CausesValidation = false;
            this.Warranty.Location = new System.Drawing.Point(357, 308);
            this.Warranty.Name = "Warranty";
            this.Warranty.ReadOnly = true;
            this.Warranty.Size = new System.Drawing.Size(59, 20);
            this.Warranty.TabIndex = 10;
            this.Warranty.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Warranty_MouseClick);
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(466, 308);
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Size = new System.Drawing.Size(89, 20);
            this.Price.TabIndex = 11;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            this.Price.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Price_MouseClick);
            // 
            // Quantity
            // 
            this.Quantity.Location = new System.Drawing.Point(593, 308);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(47, 20);
            this.Quantity.TabIndex = 12;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(678, 308);
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Size = new System.Drawing.Size(82, 20);
            this.Total.TabIndex = 13;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            this.Total.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Total_MouseClick);
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(795, 308);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(81, 20);
            this.Payment.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Serial no";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(208, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Company name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Model";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(354, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Warranty";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(463, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(590, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "Quantity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(675, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Total";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(792, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 22;
            this.label9.Text = "Payment";
            // 
            // Due
            // 
            this.Due.Location = new System.Drawing.Point(914, 308);
            this.Due.Name = "Due";
            this.Due.ReadOnly = true;
            this.Due.Size = new System.Drawing.Size(82, 20);
            this.Due.TabIndex = 23;
            this.Due.TextChanged += new System.EventHandler(this.Due_TextChanged);
            this.Due.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Due_MouseClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(911, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 24;
            this.label10.Text = "Due";
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(902, 25);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 25;
            this.Print.Text = "Print";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SRmobileStore.Properties.Resources.Water_Eff;
            this.ClientSize = new System.Drawing.Size(1033, 469);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Due);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.Warranty);
            this.Controls.Add(this.Model);
            this.Controls.Add(this.Company_name);
            this.Controls.Add(this.Serial_no);
            this.Controls.Add(this.Customer_id);
            this.Controls.Add(this.Cus_id);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Bill_no);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Bill";
            this.Text = "Bill";
            this.Load += new System.EventHandler(this.Bill_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Bill_no;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox Cus_id;
        private System.Windows.Forms.Label Customer_id;
        private System.Windows.Forms.TextBox Serial_no;
        private System.Windows.Forms.TextBox Company_name;
        private System.Windows.Forms.TextBox Model;
        private System.Windows.Forms.TextBox Warranty;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox Payment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Due;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button Print;

    }
}