using System;
using System.Windows.Forms;

namespace win3tier.GUI
{
    public partial class PTbacnhat : Form
    {
        public PTbacnhat()
        {
            InitializeComponent();
        }

        private void btnGiaiPT_Click(object sender, EventArgs e)
        {
            BUS.GiaiPTbac1 obj = new BUS.GiaiPTbac1(txtA, txtB);
            txtKetqua.Text = obj.TimNghiemPTbac1();
        }
    
        private void btnXoa_Click(object sender, EventArgs e)
        {
            TextBox[] txt = new TextBox[] { txtA, txtB, txtKetqua };
            DAL.XoaTextBox.Xoa(txt);
        }
    }
}
