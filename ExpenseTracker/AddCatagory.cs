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
    public partial class AddCatagory : Form
    {
        public AddCatagory()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Homepagecs H = new Homepagecs();
            H.Show();
            this.Hide();
        }
    }
}
