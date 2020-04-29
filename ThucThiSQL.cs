using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangDienThoai
{
    public class ThucThiSQL
    {
        public static SqlConnection conn;
        //public static string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=" +
        //                                    System.IO.Directory.GetCurrentDirectory().ToString() +
        //                                   "\\Database\\CuaHang.mdf;Integrated Security=True";
        //public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Thuctap\QuanLyCuaHangDienThoai\bin\Database\CuaHang.mdf;Integrated Security=True";

        public static string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Lập trình 2\QuanLyCuaHangDienThoai\bin\Database\CuaHang.mdf;Integrated Security=True";

        //public static string connString = "Data Source=LAPTOP-AF99Q19J;Initial Catalog=QuanLyCuaHangDienThoai;Integrated Security=True";
        public static void KetNoiCSDL()
        {
            conn = new SqlConnection();

            conn.ConnectionString = connString;
            if (conn.State != ConnectionState.Open)
                conn.Open();

        }
        public static void DongKetNoiCSDL()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public static void CapNhatDuLieu(String sql)
        {


            ThucThiSQL.KetNoiCSDL();

            SqlCommand sqlcommand = new SqlCommand();

            sqlcommand.Connection = conn;

            sqlcommand.CommandText = sql;

            sqlcommand.ExecuteNonQuery();



        }
        public static DataTable DocBang(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Mydata = new SqlDataAdapter();
            Mydata.SelectCommand = new SqlCommand();
            KetNoiCSDL();
            Mydata.SelectCommand.Connection = conn;
            Mydata.SelectCommand.CommandText = sql;
            Mydata.Fill(dt);
            DongKetNoiCSDL();
            return dt;
        }
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[0], parts[1], parts[2]);
            return dt;
        }
        public static string GetFieldValues(string sql)
        {
            KetNoiCSDL();
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
                ma = reader.GetValue(0).ToString();
            reader.Close();
            return ma;
        }

    }
}
