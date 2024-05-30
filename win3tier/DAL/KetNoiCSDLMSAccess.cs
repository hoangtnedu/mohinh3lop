using System.Data;
using System.Data.OleDb;

namespace win3tier.DAL
{
    public class KetNoiCSDLMSAccess
    {
        /// <summary>
        /// Kết nối đến cơ sở dữ liệu MS Access có đường dẫn là DuongDanFilemdb
        /// </summary>
        /// <param name="conn">Đối tượng kết nối MS Access</param>
        /// <param name="DuongDanFilemdb">Đường dẫn file cơ sở dữ liệu *.mdb</param>
        public void Open_DataAccess(ref OleDbConnection conn, string DuongDanFilemdb)

        {
            conn = new OleDbConnection();
            string s = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + DuongDanFilemdb;

            conn.ConnectionString = s;

            conn.Open();
        }
        /// <summary>
        /// Truy vấn dữ liệu, kết quả gửi vào Dataset
        /// </summary>
        /// <param name="sqlSelect">Câu lệnh truy vấn Sql</param>
        /// <param name="conn">Đối tượng kết nối cơ sở dữ liệu Access</param>
        /// <returns>Dataset chứa dữ liệu truy vấn</returns>
        public DataSet GetData(string sqlSelect, OleDbConnection conn)

        {
            DataSet ds = new DataSet();

            OleDbDataAdapter daShowData = new OleDbDataAdapter(sqlSelect, conn);

            daShowData.Fill(ds);

            return ds;

        }

    }
}
