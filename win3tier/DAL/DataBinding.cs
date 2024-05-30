using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
namespace win3tier.DAL
{
    public static class AssignValue
    {
        public static void AssignValueDataGridView(ref
            DataGridView dataGridView,DataTable dt)
        {
            dataGridView.DataSource = dt;
        }
        public static void AssignValueTextBox(
            ref TextBox txt,string value)
        {
            txt.Text = value;
        }
    }
}
