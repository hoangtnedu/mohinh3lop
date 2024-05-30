using System;
using System.Data;
using System.Data.SqlClient;
namespace win3tier.DAL
{
    public interface ISV
    {
        string MaSV { get; set; }
        string TenSV { get; set; }
        string Namvao { get; set; }
        DateTime Ngaysinh { get; set; }
        string Quequan { get; set; }
        string Ghichu { get; set; }
        void Them1banghi(SqlConnection Conn);
        DataTable LoadAllSinhVien();
    }
}
