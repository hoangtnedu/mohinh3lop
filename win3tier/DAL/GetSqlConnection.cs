using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace win3tier.DAL
{
    public static class GetSqlConnection
    {
        static SqlConnection conn;static bool kt;
        public static SqlConnection Get(string strConnectionString)
        {
            kt = true;
            conn = new SqlConnection(strConnectionString);            
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                kt = false;
            }

            return conn;
        }
        public static bool ConectionCheck => kt;
    }
}
