using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpenseTracker
{
    public partial class AddExpense : Form
    {

        SqlFile S = new SqlFile();
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-FQLMQHI0\SQLEXPRESS;Initial Catalog=VISHALDBO;Integrated Security=True;Pooling=False");
        SqlDataAdapter da;
        DataTable dt;


        public AddExpense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S.ExecutesqlQuery("INSERT INTO AddExpense(Name,ExpenseSource,Amount,Date) Values('" + textBox2.Text + "','" + comboBox1.Text + "','" + textBox1.Text + "','" + dateTimePicker1.Text + "')");
            MessageBox.Show("Expense Detailes Saved Succesfully..");
            ShowData();
        }
        
        
        public void ShowData()
        {
            da = new SqlDataAdapter("select * from AddExpense", cn);
            dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
            Homepagecs H = new Homepagecs();
            H.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
