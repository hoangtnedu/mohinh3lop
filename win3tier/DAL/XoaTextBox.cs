using System.Windows.Forms;

namespace win3tier.DAL
{
    public static class   XoaTextBox
    {
        public static void Xoa(TextBox[] txt)
        {
            for (int i = 0; i < txt.Length; i++)
            {
                txt[i].Text = "";
            }
        }
    }
}
