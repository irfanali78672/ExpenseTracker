using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExpenseTracker
{
    public partial class Register : Form
    {
        SqlFile S = new SqlFile();
        public Register()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login L = new Login();
            L.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            S.ExecutesqlQuery("INSERT INTO Registerdbo(NAME,EMAIL,PASSWORD) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')");
            MessageBox.Show("Registered Succesfully..");
            Login L = new Login();
            L.Show();
            this.Hide();
        }

       
        }
        }
    

