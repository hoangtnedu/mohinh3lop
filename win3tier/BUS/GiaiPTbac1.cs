using System.Windows.Forms;

namespace win3tier.BUS
{
    public class GiaiPTbac1
    {
        public double A { get; set; }
        public double B { get; set; }
        public GiaiPTbac1() { }
        public GiaiPTbac1(TextBox txtA,TextBox txtB)
        {
            A = DAL.ChuyenStringsangThuc.Chuyendoi(txtA.Text.ToString());
            B = DAL.ChuyenStringsangThuc.Chuyendoi(txtB.Text.ToString());
        }
        public GiaiPTbac1(double a, double b)
        {
            A = a;B = b;
        }
        public string TimNghiemPTbac1()
        {
            string ketqua;
            if (A==0)
            {
                ketqua = "Phương trình vô nghiệm.";
            }
            else
            {
                ketqua = " Phương trình có nghiệm là: " + (-B / A).ToString();
            }
            return ketqua;
        }
    }
}
