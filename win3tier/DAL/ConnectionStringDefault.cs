namespace win3tier.DAL
{
    public static class ConnectionStringDefault
    {
        public static string Get() {
            return @"Data Source =.; Initial Catalog = QLSV; Integrated Security = SSPI"; 
        }
    }
}
