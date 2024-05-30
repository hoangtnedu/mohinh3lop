using System;
using System.Data.SqlClient;

namespace win3tier.DAL
{
    public static class RunSQL
    {
        //Hàm thực hiện câu lệnh SQL
        public static bool Run(string sql, SqlConnection Conn)
        {
            bool kt = true;
            SqlCommand cmd; //Đối tượng thuộc lớp SqlCommand
            cmd = new SqlCommand();
            cmd.Connection = Conn; //Gán kết nối
            cmd.CommandText = sql; //Gán lệnh SQL
            try
            {
                cmd.ExecuteNonQuery(); //Thực hiện câu lệnh SQL
            }
            catch (Exception)
            {
                kt = false;
            }
            cmd.Dispose();//Giải phóng bộ nhớ
            return kt;
        }

    }
}
