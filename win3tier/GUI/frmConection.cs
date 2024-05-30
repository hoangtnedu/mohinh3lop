using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace win3tier.GUI
{

    public partial class frmConection : Form
    {
        
       public string strConectionString;
        public frmConection()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            TextBox[] txt = new TextBox[] { txtDatabase,txtPassword,
            txtServer,txtUserID};
            DAL.XoaTextBox.Xoa(txt);
        }

        private void btnKetnoi_Click(object sender, EventArgs e)
        {
            strConectionString = DAL.ConnectionString.Get(txtServer,txtDatabase,txtUserID,txtPassword);
            SqlConnection conn = DAL.GetSqlConnection.Get(strConectionString);
            if (DAL.GetSqlConnection.ConectionCheck)
            {
                lblThongbao.Text = " DA KET NOI THANH CONG VOI THONG TIN " + Environment.NewLine + "(" + strConectionString + ")";
            }
            else
            {
                lblThongbao.Text = " KHONG KET NOI DUOC DEN SERVER " + Environment.NewLine + "(" + strConectionString + ")";
            }
        }

        private void btnKetnoiMacdinh_Click(object sender, EventArgs e)
        {
            strConectionString = DAL.ConnectionStringDefault.Get();
            SqlConnection conn = DAL.GetSqlConnection.Get(strConectionString);
            if (DAL.GetSqlConnection.ConectionCheck)
            {
                lblThongbao.Text = " DA KET NOI THANH CONG VOI THONG TIN "+Environment.NewLine+ "(" + strConectionString + ")";
            }
            else
            {
                lblThongbao.Text = " KHONG KET NOI DUOC DEN SERVER " + Environment.NewLine + "(" + strConectionString + ")";
            }

        }
    }
}
