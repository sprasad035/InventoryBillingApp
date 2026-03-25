using System.Data;
using System.Data.SQLite;

namespace InventoryBillingApp.Database
{
    public static class DBHelper
    {
        private static string connectionString = "Data Source=inventory.db;Version=3;";

        public static DataTable GetDataTable(string query)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(query, con))
                using (var da = new SQLiteDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static int Execute(string query)
        {
            using (var con = new SQLiteConnection(connectionString))
            {
                con.Open();
                using (var cmd = new SQLiteCommand(query, con))
                {
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}