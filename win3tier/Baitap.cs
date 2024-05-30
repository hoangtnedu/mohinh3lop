using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win3tier
{
    public partial class Baitap : Form
    {
        System.Data.SqlClient.SqlConnection Conn;
        public Baitap()
        {
            InitializeComponent();
        }

        private void bAITAPTINHTONG2SOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmNhap2so frm = new GUI.frmNhap2so();
            frm.ShowDialog();
        }

        private void gIAỈPHƯƠNGTRÌNHBẬC1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.PTbacnhat frm = new GUI.PTbacnhat();
            frm.ShowDialog();
        }

        private void kETNOICSDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmConection frm = new GUI.frmConection();
            frm.ShowDialog();
            string strConnectionString;
            strConnectionString = frm.strConectionString;
            Conn = DAL.GetSqlConnection.Get(strConnectionString);
        }

        private void thongTinSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmSinhVien sv = new GUI.frmSinhVien(Conn);
            sv.ShowDialog();
        }

        private void kếtNốiBằngDataSourceConfigurationWizardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.KetNoiBangDataSourceConfigurationWizard frm = new GUI.KetNoiBangDataSourceConfigurationWizard();
            frm.Show();
        }

        private void tảiDữLiệuVàoDataSetVàHiểnThịDữLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI.frmTaovaHienThiDataSetVDSinhVien frm = new GUI.frmTaovaHienThiDataSetVDSinhVien();
            frm.Show();
        }
    }
}
