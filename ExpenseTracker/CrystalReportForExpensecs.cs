using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace ExpenseTracker
{
    public partial class CrystalReportForExpensecs : Form
    {
        SqlFile C = new SqlFile();
        public CrystalReportForExpensecs()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
        public void creport(string sql, SqlConnection cn)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataSet1ForExpense ds = new DataSet1ForExpense();
            da.Fill(ds, "AddExpense");
            CrystalReport1ForExpense cr1 = new CrystalReport1ForExpense();
            cr1.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr1;
        }

        private void CrystalReportForExpensecs_Load(object sender, EventArgs e)
        {
            creport("Select * from AddExpense", C.cn);
        }


    }
}
