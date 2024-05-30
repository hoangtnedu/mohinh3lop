using System.Data.SqlClient;
namespace win3tier.DAL
{
    interface IKetNoi
    {
        /// <summary>
        /// Tên máy tính chứa hệ quản trị SQL Server.
        /// </summary>
        string TenMayChu { get; set; }
        /// <summary>
        /// Tên cơ sở dữ liệu cần kết nối
        /// </summary>
        string TenCSDL { get; set; }
        /// <summary>
        /// Tên login dùng để đăng nhập
        /// </summary>
        string TenNguoiDung { get; set; }
        /// <summary>
        /// Mật khẩu đăng nhập
        /// </summary>
        string MatKhau {get;set;}
        /// <summary>
        /// Tạo chuỗi kết nối
        /// </summary>
        /// <param name="tenmc">Tên máy chủ</param>
        /// <param name="tencsdl">Tên cơ sở dữ liệu</param>
        /// <param name="tennguoidung">Tên login</param>
        /// <param name="matkhau">Mật khẩu</param>
        /// <returns>Trả về chuỗi kết nối đến cơ sở dữ liệu</returns>
        string GetConnectionString(string tenmc, string tencsdl, string tennguoidung, string matkhau);
        /// <summary>
        /// Tạo chuỗi kết nối
        /// </summary>
        /// <returns>Trả về chuỗi kết nối đến cơ sở dữ liệu</returns>
        string GetConnectionString();
    }
    interface IMyConnection
    {
        /// <summary>
        /// Thông tin kết nối
        /// </summary>
        clsKetNoi InforConnect { get; set; }
        /// <summary>
        /// Biến kết nối SQL
        /// </summary>
        /// <returns>Trả về biến kết nối</returns>
        SqlConnection GetConnection();
        /// <summary>
        /// Biến kết nối
        /// </summary>
        /// <param name="strConnectionString">Chuỗi kết nối cơ sở dữ liệu.</param>
        /// <returns>Trả lại biến kết nối.</returns>
        SqlConnection GetConnection(string strConnectionString);

       
    }
}
