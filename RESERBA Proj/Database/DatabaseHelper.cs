using MySql.Data.MySqlClient;

namespace RESERBA_Proj.Database
{
    public static class DatabaseHelper
    {
        private static string connectionString =
            "Server=reserba-reserba.g.aivencloud.com;" +
            "Port=24688;" +
            "Database=defaultdb;" +
            "Uid=avnadmin;" +
            "Pwd=reserba123;" +
            "SslMode=Required;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
