using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace win3tier.DAL
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string Namvao { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Quequan { get; set; }
        public string Ghichu { get; set; }
        public SinhVien()
        { }
        public SinhVien(TextBox masv,TextBox tensv,TextBox namvao,DateTimePicker dtpngaysinh,TextBox quequan,TextBox ghichu)
        {
            MaSV = masv.Text;
            TenSV = tensv.Text;
            Namvao = namvao.Text;
            Ngaysinh =DateTime.Parse( dtpngaysinh.Text);
            Quequan = quequan.Text;
            Ghichu = ghichu.Text;
        }
        /// <summary>
        /// Thêm mới một thông tin sinh viên vào cơ sở dữ liệu    
        /// </summary>
        /// <param name="Conn">Biến Connection đã được kết nối đến CSDL QLSV</param>
        public void Them1banghi(SqlConnection Conn)
        {
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = Conn;
            sqlComm.CommandType = System.Data.CommandType.StoredProcedure;
            sqlComm.CommandText = "sp_Insert1record";

            //tham so truyen vao cho comm
            //tham so @MaSV
            SqlParameter sqlParameter = new SqlParameter("@MaSV", System.Data.SqlDbType.Char, 10);
            sqlParameter.Value = MaSV;
            sqlComm.Parameters.Add(sqlParameter);
            //tham so @TenSV
            sqlParameter = new SqlParameter("@TenSV", System.Data.SqlDbType.NVarChar, 50);
            sqlParameter.Value = TenSV;
            sqlComm.Parameters.Add(sqlParameter);
            //tham so @Namvao
            sqlParameter = new SqlParameter("@Namvao", System.Data.SqlDbType.Int);
            sqlParameter.Value =int.Parse(Namvao);
            sqlComm.Parameters.Add(sqlParameter);
            // tham so @Ngaysinh
            sqlParameter = new SqlParameter("@Ngaysinh", System.Data.SqlDbType.Date);
            sqlParameter.Value = new DateTime(Ngaysinh.Year, Ngaysinh.Month, Ngaysinh.Day);         
            sqlComm.Parameters.Add(sqlParameter);

            //Tham so @Quequan
            sqlParameter = new SqlParameter("@Quequan", System.Data.SqlDbType.NVarChar, 50);
            sqlParameter.Value = Quequan;
            sqlComm.Parameters.Add(sqlParameter);

            //Tham so @Ghichu
            sqlParameter = new SqlParameter("@GhiChu", System.Data.SqlDbType.NVarChar, 50);
            sqlParameter.Value = Ghichu;
            sqlComm.Parameters.Add(sqlParameter);
            try
            {
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string e = ex.ToString();
            }
            finally
            {
                sqlComm.Dispose();
            }           
        }

        /// <summary>
        /// Thêm mới một thông tin sinh viên vào cơ sở dữ liệu
        /// Giả sử thêm mới sinh viên có
        /// Mã SV:001, Tên SV: Nguyễn Văn A
        /// Năm vào: 2019, ngày sinh: 12/09/2001
        /// Quê quán: Hưng yên, Ghi chú: SV xét tuyển đạt
        /// </summary>
        /// <param name="Conn">Biến Connection đã được kết nối đến CSDL QLSV</param>
        public void Them1banghiSV(SqlConnection Conn)
        {
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = Conn;
            sqlComm.CommandType = System.Data.CommandType.StoredProcedure;
            sqlComm.CommandText = "sp_Insert1record";

            //tham so truyen vao cho comm
            //tham so @MaSV
            SqlParameter sqlParameter = new SqlParameter("@MaSV", System.Data.SqlDbType.Char, 10);
            sqlParameter.Value = "001";
            sqlComm.Parameters.Add(sqlParameter);
            //tham so @TenSV
            sqlParameter = new SqlParameter("@TenSV", System.Data.SqlDbType.NVarChar, 50);
            sqlParameter.Value = "Nguyễn Văn A";
            sqlComm.Parameters.Add(sqlParameter);
            //tham so @Namvao
            sqlParameter = new SqlParameter("@Namvao", System.Data.SqlDbType.Int);
            sqlParameter.Value = 2019;
            sqlComm.Parameters.Add(sqlParameter);
            // tham so @Ngaysinh
            sqlParameter = new SqlParameter("@Ngaysinh", System.Data.SqlDbType.Date);
            sqlParameter.Value = new DateTime(2001, 9, 12);
            sqlComm.Parameters.Add(sqlParameter);

            //Tham so @Quequan
            sqlParameter = new SqlParameter("@Quequan", System.Data.SqlDbType.NVarChar, 50);
            sqlParameter.Value = "Hưng yên";
            sqlComm.Parameters.Add(sqlParameter);

            //Tham so @Ghichu
            sqlParameter = new SqlParameter("@GhiChu", System.Data.SqlDbType.NVarChar, 50);
            sqlParameter.Value = "SV xét tuyển đạt";
            sqlComm.Parameters.Add(sqlParameter);
            try
            {
                sqlComm.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string e = ex.ToString();
            }
            finally
            {
                sqlComm.Dispose();
            }
        }


        DataTable dt;
        public DataTable LoadAllSinhVien(SqlConnection Conn)
        {
            dt = new DataTable();
            SqlCommand sqlComm = new SqlCommand();
            sqlComm.Connection = Conn;
            sqlComm.CommandType = System.Data.CommandType.StoredProcedure;
            sqlComm.CommandText = "LoadAllSinhVien";
            SqlDataAdapter da = new SqlDataAdapter(sqlComm);
            da.Fill(dt);
            return dt;
        }
    }
}
