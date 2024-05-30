using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace win3tier.DAL
{
    class CreateDataTable
    {
        DataColumn col;
        public DataColumn CreateDataColumnID()
        {
            col = new DataColumn("ID", typeof(int));
            col.AllowDBNull = false;
            col.AutoIncrement = true;
            col.AutoIncrementSeed = 1;
            col.Unique = true;
            return col;
        }
        public DataColumn CreateDataColumnString(string name)
        {
            col.ColumnName = name;
            col.DataType = typeof(string);
            return col;
        }

        public DataTable AutoCreatDataNhanVien()
        {
            DataTable table = new DataTable("NhanVien");
            DataColumn col = new DataColumn("ID", typeof(int));

            col.AllowDBNull = false;
            col.AutoIncrement = true;
            col.AutoIncrementSeed = 1;
            col.Unique = true;

            table.Columns.Add(col);
            table.Columns.Add("TenNV", typeof(string));
            table.Columns.Add("NgaySinh", typeof(DateTime));
            table.Columns.Add("QueQuan", typeof(string));
            return table;
        }
        public void AutoSignDataNhanVien(ref DataTable dtNhanvien)
        {
            DataRow newRow =dtNhanvien.NewRow();
            newRow["ID"] = 1; // remove this line
            newRow["Name"] = "Nguyễn Thành Nam";
            newRow["Birthday"] = new DateTime(1992, 3, 4);
            dtNhanvien.Rows.Add(newRow);
            newRow["Name"] = "Nguyễn Thành Nam";
        }

        public void AddDataTable2DataSet(ref DataSet ds,DataTable dt)
        {
            ds.Tables.Add(dt);
        }
    }
}
