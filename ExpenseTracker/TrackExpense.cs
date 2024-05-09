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
    public partial class TrackExpense : Form
    {
        SqlFile S = new SqlFile();
        SqlConnection cn = new SqlConnection(@"Data Source=LAPTOP-FQLMQHI0\SQLEXPRESS;Initial Catalog=VISHALDBO;Integrated Security=True;Pooling=False");
        SqlDataAdapter da;
        DataTable dt;
        public TrackExpense()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Name = textBox2.Text;
            bool isValid = S.TrackExpense(Name);
            if (isValid == true)
            {
                MessageBox.Show("Fetching Details");
            }
            else
            {
                MessageBox.Show("Not Found");
            }
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

        }
        
        }
    

