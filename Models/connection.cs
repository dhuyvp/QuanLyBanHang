using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace QuanLyBanHang.Models
{
    internal class connection
    {
        public static string sqlcon = @"Server=DESKTOP-L46Q6HS; Database=QuanLyBanHang; Integrated Security=True; Trusted_Connection=True";
        public static SqlConnection Getconnection()
        {
            SqlConnection con = new SqlConnection(sqlcon);
            return con;
        }

        public static void openConnection(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }
        public static void closeConnection(SqlConnection conn)
        {
            try
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public static DataSet FillDataSet(string strQuery, CommandType cmdType)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection conn = new SqlConnection();
                conn = Getconnection();
                openConnection(conn);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdType;
                cmd.Connection = conn;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                da.Dispose();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds;
        }
        public static DataSet FillDataSet(string strQuery, CommandType cmdType, string[] pars, object[] values)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlConnection conn = Getconnection();
                openConnection(conn);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = strQuery;
                cmd.CommandType = cmdType;
                cmd.Connection = conn;
                
                SqlParameter sqlpara = new SqlParameter();
                for (int i = 0; i < pars.Length; i++)
                {
                    sqlpara = new SqlParameter();
                    sqlpara.ParameterName = pars[i];
                    sqlpara.SqlValue = values[i];

                    cmd.Parameters.Add(sqlpara);
                }
                SqlDataAdapter sqlda = new SqlDataAdapter(cmd);
                sqlda.Fill(ds);
                ds.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ds;
        }
        public static string ExcuteScalar(string strQuery)
        {
            string ketQua = "";
            try
            {
                SqlConnection sqlconn = Getconnection();
                openConnection(sqlconn);
                SqlCommand cmd = new SqlCommand(strQuery, sqlconn);
                ketQua = cmd.ExecuteScalar().ToString();
            }
            catch { }
            return ketQua;
        }
        public static string ExcuteScalar(string strQuery, CommandType cmdType, string[] pars, object[] values)
        {
            SqlConnection conn = Getconnection();
            openConnection(conn);

            string ketQua = "";
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandText = strQuery;
            sqlCmd.Connection = conn;
            //sqlCmd.CommandType = cmdType;

            SqlParameter sqlpara;
            for (int i = 0; i < pars.Length; i++)
            {
                sqlpara = new SqlParameter();
                sqlpara.ParameterName = pars[i];
                sqlpara.SqlValue = values[i];
                sqlCmd.Parameters.Add(sqlpara);
            }

            try
            {
                ketQua = sqlCmd.ExecuteScalar().ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return ketQua;
        }
        public static int Excute_sql(string strQuery)
        {
            int ret = 0;
            SqlConnection conn = Getconnection();
            openConnection(conn);
            SqlCommand cmd = new SqlCommand(strQuery, conn);
            try
            {
                ret = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ret;
        }
        public static int Excute_sql(string strQuery, CommandType cmdType, string[] pars, object[] values)
        {
            SqlConnection conn = Getconnection();
            openConnection(conn);

            int ret = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = cmdType;
            cmd.CommandText = strQuery;
            cmd.Connection= conn;

            SqlParameter sqlpara;
            for (int i = 0; i < pars.Length; i++) 
            { 
                sqlpara= new SqlParameter();
                sqlpara.ParameterName = pars[i];
                sqlpara.SqlValue = values[i];
                cmd.Parameters.Add(sqlpara);
            }
            try
            {
                ret = cmd.ExecuteNonQuery();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return ret;
        }
    }
}
