using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLKS
{
    internal class func
    {
        protected SqlConnection getConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Admin\OneDrive\Documents\dbQLKS.mdf;Integrated Security=True;Connect Timeout=30";
            return conn;
        }
        
        public DataSet getDaTa(string query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText= query;
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        public void setData(string query, string mess)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open();
            cmd.CommandText= query;
            cmd.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show(mess, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public SqlDataReader getCombo (string query)
        {
            SqlConnection conn = getConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            conn.Open ();
            cmd = new SqlCommand(query,conn);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
