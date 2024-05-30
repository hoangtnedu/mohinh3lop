using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win3tier.GUI
{
    public partial class frmTaovaHienThiDataSetVDSinhVien : Form
    {
        DataSet ds;
        public frmTaovaHienThiDataSetVDSinhVien()
        {
            InitializeComponent();
        }

        DataSet LoadData()
        {
            //Khai báo biễn kết nối
            var conn = new SqlConnection("Data Source =.; Initial Catalog = QLSV; Integrated Security = SSPI");
            //Mở kết nối
            conn.Open();
            //Khai báo câu lệnh select
            var cmd = "Select * from SinhVien";
            //Khai báo đối tượng DataAdapter
            var dataAdapter = new SqlDataAdapter(cmd, conn);
            //Khai báo đối tượng DataSet
            var dataSet = new DataSet();
            //Điền dữ liệu có được vào DataSet
            dataAdapter.Fill(dataSet, "SinhVien");
            //Đóng kết nối
            conn.Close();
            // Trả về giá trị dataSet
            return dataSet;
        }
        /// <summary>
        /// Load dữ liệu sinh viên vào DataSet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Sự kiện click chuột</param>
        private void button1_Click(object sender, EventArgs e)
        {
            ds = LoadData();
        }
        /// <summary>
        /// Hiển thị dữ liệu từ DataSet lên DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Sự kiện click chuột</param>
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.Tables["SinhVien"];
            
        }
    }
}
