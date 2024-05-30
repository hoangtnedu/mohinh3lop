using System.Windows.Forms;

namespace win3tier.BUS
{
    public class CongHaiSo
    {
        public int So1 { get; set; }
        public int So2 { get; set; }
        //phuong thuc khoi dung khong tham so (contructor no parameter)
        public CongHaiSo()
        {}
        //phuong thuc khoi dung co tham so
        public CongHaiSo(TextBox txtso1, TextBox txtso2)
        {
            So1 = DAL.Chuyendoichuoithanhsonguyen.Chuyendoi(txtso1.Text);
            So2 = DAL.Chuyendoichuoithanhsonguyen.Chuyendoi(txtso2.Text);
        }
        public CongHaiSo(int so1, int so2)
        {
            So1 = so1;So2 = so2;
        }      
        public int Tinhtong()
        {
            return So1 + So2;
        }
        
    }
}
