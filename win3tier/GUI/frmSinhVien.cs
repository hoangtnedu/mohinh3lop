using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace win3tier.GUI
{
    public partial class frmSinhVien : Form
    {
        SqlConnection Conn;
        DAL.SinhVien sv;
        public frmSinhVien(SqlConnection conn)
        {
            Conn = conn;
            InitializeComponent();
            LoadAllSinhVien();
        }
        DataTable dt;
        void LoadAllSinhVien()
        {
            dt = new DataTable();
            sv = new DAL.SinhVien();
            dt = sv.LoadAllSinhVien(Conn);
            dgvSinhVien.DataSource = dt;
            ClearBinding();
            Binding();
        }
        void Binding()
        {
            txtTensv.DataBindings.Add("Text", dt, "TenSV");
            txtMasv.DataBindings.Add("Text", dt, "MaSV");
            txtGhichu.DataBindings.Add("Text", dt, "GhiChu");
            txtNamvaohoc.DataBindings.Add("Text", dt, "Namvao");
            dtpNgaysinh.DataBindings.Add("Text", dt, "Ngaysinh");
            txtQuequan.DataBindings.Add("Text", dt, "Quequan");
        }
        void ClearBinding()
        {
            txtTensv.DataBindings.Clear();
            txtMasv.DataBindings.Clear();
            txtGhichu.DataBindings.Clear();
            txtNamvaohoc.DataBindings.Clear();
            dtpNgaysinh.DataBindings.Clear();
            txtQuequan.DataBindings.Clear();
        }
        private void btnXoatextbox_Click(object sender, EventArgs e)
        {
            Xoa();
        }
        void Xoa()
        {
            TextBox[] txt = new TextBox[] { txtGhichu, txtMasv, txtNamvaohoc, txtQuequan, txtTensv, txtTimKiem };
            DAL.XoaTextBox.Xoa(txt);
        }
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            sv = new DAL.SinhVien(txtMasv, txtTensv, txtNamvaohoc, dtpNgaysinh, txtQuequan, txtGhichu);
            sv.Them1banghi(Conn);
            LoadAllSinhVien();
        }
    }
}
