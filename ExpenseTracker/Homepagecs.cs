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
    public partial class Homepagecs : Form
    {
        public Homepagecs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Homepagecs_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Logout ?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login L = new Login();
                L.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddIncome AI = new AddIncome();
            AI.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddExpense AE = new AddExpense();
            AE.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TrackIncome T = new TrackIncome();
            T.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TrackExpense T = new TrackExpense();
            T.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddCatagory AC = new AddCatagory();
            AC.Show();
            this.Hide();

        }
    }
}
