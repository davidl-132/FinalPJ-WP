using System;
using System.Data;
using System.Data.SqlClient;

namespace FinalPJ_WP.DB_layer
{
    class DBMain
    {
        // ── Chỉ thay tên database ở đây ──
        string ConnStr = "Data Source=DESKTOP-2C2VUAL\\SQLEXPRESS;Initial Catalog=QuanLyBanGame;Integrated Security=True;TrustServerCertificate=True";

        SqlConnection conn = null;
        SqlCommand comm = null;
        SqlDataAdapter da = null;

        public DBMain()
        {
            conn = new SqlConnection(ConnStr);
            comm = conn.CreateCommand();
        }

        // Dùng cho SELECT → trả về DataSet (giống thầy)
        public DataSet ExecuteQueryDataSet(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            da = new SqlDataAdapter(comm);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

        // Dùng cho INSERT / UPDATE / DELETE (giống thầy)
        public bool MyExecuteNonQuery(string strSQL, CommandType ct, ref string error)
        {
            bool f = false;
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            try
            {
                comm.ExecuteNonQuery();
                f = true;
            }
            catch (SqlException ex)
            {
                error = ex.Message;
            }
            finally
            {
                conn.Close();
            }
            return f;
        }

        // Dùng cho SELECT trả về 1 giá trị (ExecuteScalar)
        public object MyExecuteScalar(string strSQL, CommandType ct)
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
            conn.Open();
            comm.CommandText = strSQL;
            comm.CommandType = ct;
            object result = comm.ExecuteScalar();
            conn.Close();
            return result;
        }
    }
}