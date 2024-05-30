using System;
using System.Windows.Forms;

namespace win3tier.GUI
{
    public partial class frmNhap2so : Form
    {
        public frmNhap2so()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Tao doi tuong conghaiso ten la obj
            BUS.CongHaiSo objCongHaiSo = new BUS.CongHaiSo(txtSothu1,txtSothu2);
            txtKetQua.Text = objCongHaiSo.Tinhtong().ToString();
        }     

        private void btnXoatextbox_Click(object sender, EventArgs e)
        {
            TextBox[] txt = new TextBox[] {txtKetQua,txtSothu1,txtSothu2 };
            DAL.XoaTextBox.Xoa(txt);
        }
    }
}
