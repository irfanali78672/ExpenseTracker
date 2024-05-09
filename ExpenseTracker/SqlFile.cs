using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ExpenseTracker
{
    class SqlFile
    {
        public SqlConnection cn;
        public SqlFile()
        {
            cn = new SqlConnection(@"Data Source=LAPTOP-FQLMQHI0\SQLEXPRESS;Initial Catalog=VISHALDBO;Integrated Security=True;Pooling=False");
            cn.Open();
        }
        public DataTable GettableData(string sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void ExecutesqlQuery(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
        public Boolean CheckLogin(string UserName, string Password)
        {
            string sql = "SELECT Name FROM  Registerdbo WHERE  (Email = '" + UserName + "' and Password='" + Password + "')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    return true;
                }

            }
            finally
            {

                reader.Close();
            }
            return false;
        }
        public Boolean TrackExpense(string Name)
        {
            string sql = "SELECT Name FROM  AddExpense WHERE  (Name = '" + Name + "')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    return true;
                }

            }
            finally
            {

                reader.Close();
            }
            return false;
        }
        public Boolean TrackIncome(string Name)
        {
            string sql = "SELECT Name FROM  AddIncome WHERE  (Name = '" + Name + "')";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    return true;
                }

            }
            finally
            {

                reader.Close();
            }
            return false;
        }
    }
}
