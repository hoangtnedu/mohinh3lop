using System.Data.SqlClient;
namespace win3tier.DAL
{
    class clsKetNoi : IKetNoi
    {
        string strChuoiKetNoiCoSoDuLieu;
        string strtenmaychu, strtencsdl, strtennguoidung, strmatkhau;
        public string TenMayChu
        { get { return strtenmaychu; } set { strtenmaychu = value; } }
        public string TenCSDL
        { get { return strtencsdl; } set { strtencsdl = value; } }
        public string TenNguoiDung
        { get { return strtennguoidung; } set { strtennguoidung = value; } }
        public string MatKhau { get { return strmatkhau; } set { strmatkhau = value; } }
        public string GetConnectionString(string tenmc, string tencsdl, string tennguoidung, string matkhau)
        {
            strChuoiKetNoiCoSoDuLieu = "";
            strChuoiKetNoiCoSoDuLieu += "Data Source =" + tenmc + ";";
            strChuoiKetNoiCoSoDuLieu += "Initial Catalog =" + tencsdl + ";";
            strChuoiKetNoiCoSoDuLieu += "User ID =" + tennguoidung + ";";
            strChuoiKetNoiCoSoDuLieu += "Password =" + matkhau + ";";
            return strChuoiKetNoiCoSoDuLieu;
        }
        public string GetConnectionString()
        {
            strChuoiKetNoiCoSoDuLieu = "";
            strChuoiKetNoiCoSoDuLieu += "Data Source =" + TenMayChu + ";";
            strChuoiKetNoiCoSoDuLieu += "Initial Catalog =" + TenCSDL + ";";
            strChuoiKetNoiCoSoDuLieu += "User ID =" + TenNguoiDung + ";";
            strChuoiKetNoiCoSoDuLieu += "Password =" + MatKhau + ";";
            return strChuoiKetNoiCoSoDuLieu;
        }
        public string GetConnectionStringDefault()
        {
            strChuoiKetNoiCoSoDuLieu = "Data Source =.; Initial Catalog = QLSV; Integrated Security = SSPI";
            return strChuoiKetNoiCoSoDuLieu;
        }
        public string GetConnectionStringDefault1()
        {
            strChuoiKetNoiCoSoDuLieu = "Data Source =.; Initial Catalog = QLSV; User ID = hoangtn;Password=123";
            return strChuoiKetNoiCoSoDuLieu;
        }
    }
    class MyConnection : IMyConnection
    {
        SqlConnection conn;
        public clsKetNoi InforConnect { get; set; }
        public MyConnection()
        { }
        public MyConnection(string strServerName, string strDatabase, string strUserName, string strPass)
        {
            InforConnect = new clsKetNoi();
            InforConnect.MatKhau = strPass;
            InforConnect.TenCSDL = strDatabase;
            InforConnect.TenMayChu = strServerName;
            InforConnect.TenNguoiDung = strUserName;
        }
        public string GetConectionStringDefault
        {

            get
            {
                InforConnect = new clsKetNoi();
                return InforConnect.GetConnectionStringDefault();
            }
        }
        public string GetConectionString()
        {
            return InforConnect.GetConnectionString();
        }
        public SqlConnection GetConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = InforConnect.GetConnectionString();
            try
            {
                conn.Open();
            }
            catch (System.Exception)
            {

            }
            return conn;
        }
        public SqlConnection GetConnection(string strConnectionString)
        {
            conn = new SqlConnection();
            conn.ConnectionString = strConnectionString;
            try
            {
                conn.Open();
            }
            catch (System.Exception)
            {

            }
            return conn;
        }
    }
    public static class KetNoi
    {
        /// <summary>
        /// Kết nối cơ sở dữ liệu QLSV bằng user hoangtn, mật khẩu 123
        /// </summary>
        /// <returns>Trả về True nếu kết nối thành công, trả về False nếu kết nối thất bại</returns>
        public static bool KetNoiCoSoDuLieuQLSV(ref SqlConnection conn)
        {
            bool kt = true;
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source =.; Initial Catalog = QLSV; User ID = hoangtn;Password=123";
            try
            {
                conn.Open();
            }
            catch
            {
                kt = false;
            }
            return kt;
        }

        /// <summary>
        /// Kết nối cơ sở dữ liệu QLSV bằng quyền windows
        /// </summary>
        /// <returns>Trả về True nếu kết nối thành công, trả về False nếu kết nối thất bại</returns>
        public static bool KetNoiCoSoDuLieuQaQuyenWindowsQLSV(ref SqlConnection conn)
        {
            bool kt = true;
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source =.; Initial Catalog = QLSV; Integrated Security = SSPI";
            try
            {
                conn.Open();
            }
            catch
            {
                kt = false;
            }
            return kt;
        }
    }
}
