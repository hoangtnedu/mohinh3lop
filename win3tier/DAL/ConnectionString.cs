using System.Windows.Forms;

namespace win3tier.DAL
{
    public static class ConnectionString
    {
        static string strChuoiKetNoiCoSoDuLieu;
        public static string Get
            (string tenmc,
            string tencsdl,
            string tennguoidung,
            string matkhau)
        {
            strChuoiKetNoiCoSoDuLieu = "";
            strChuoiKetNoiCoSoDuLieu += "Data Source =" + tenmc + ";";
            strChuoiKetNoiCoSoDuLieu += "Initial Catalog =" + tencsdl + ";";
            strChuoiKetNoiCoSoDuLieu += "User ID =" + tennguoidung + ";";
            strChuoiKetNoiCoSoDuLieu += "Password =" + matkhau + ";";
            return strChuoiKetNoiCoSoDuLieu;
        }
        public static string Get
            (TextBox tenmc,
            TextBox tencsdl,
            TextBox tennguoidung,
            TextBox matkhau)
        {
            strChuoiKetNoiCoSoDuLieu = "";
            strChuoiKetNoiCoSoDuLieu += "Data Source =" + tenmc.Text + ";";
            strChuoiKetNoiCoSoDuLieu += "Initial Catalog =" + tencsdl.Text + ";";
            strChuoiKetNoiCoSoDuLieu += "User ID =" + tennguoidung.Text + ";";
            strChuoiKetNoiCoSoDuLieu += "Password =" + matkhau.Text + ";";
            return strChuoiKetNoiCoSoDuLieu;
        }
    }
}
