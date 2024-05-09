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
    public partial class Login : Form
    {
        SqlFile S = new SqlFile();
        public Login()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = textBox1.Text;
            string Password = textBox2.Text;

            bool isValid = S.CheckLogin(UserName, Password);
                if(isValid==true)
                {
                    MessageBox.Show("Login Succesfully..");
                    Homepagecs H = new Homepagecs();
                    H.Show();
                    this.Hide();
                }
            else
                {
                    MessageBox.Show("Please Register..");
                    Register R = new Register();
                    R.Show();
                    this.Hide();
                }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register R = new Register();
            R.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        
        }
        }

    
      
    
