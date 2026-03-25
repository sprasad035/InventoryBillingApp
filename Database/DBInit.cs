using System.Data.SQLite;
using System.IO;

namespace InventoryBillingApp.Database
{
    public static class DBInit
    {
        private static string DbFile = "inventory.db";

        public static void Initialize()
        {
            if (!File.Exists(DbFile))
            {
                SQLiteConnection.CreateFile(DbFile);
            }

            using (var con = new SQLiteConnection($"Data Source={DbFile};Version=3;"))
            {
                con.Open();

                string productTable = @"
                CREATE TABLE IF NOT EXISTS Product (
                    ProductId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Category TEXT,
                    UnitPrice REAL NOT NULL,
                    QuantityInStock INTEGER NOT NULL
                );";

                string invoiceTable = @"
                CREATE TABLE IF NOT EXISTS Invoice (
                    InvoiceId INTEGER PRIMARY KEY AUTOINCREMENT,
                    CustomerName TEXT,
                    InvoiceDate TEXT,
                    TotalAmount REAL
                );";

                string invoiceItemTable = @"
                CREATE TABLE IF NOT EXISTS InvoiceItem (
                    ItemId INTEGER PRIMARY KEY AUTOINCREMENT,
                    InvoiceId INTEGER,
                    ProductId INTEGER,
                    Quantity INTEGER,
                    Price REAL,
                    Amount REAL,
                    FOREIGN KEY(InvoiceId) REFERENCES Invoice(InvoiceId),
                    FOREIGN KEY(ProductId) REFERENCES Product(ProductId)
                );";

                new SQLiteCommand(productTable, con).ExecuteNonQuery();
                new SQLiteCommand(invoiceTable, con).ExecuteNonQuery();
                new SQLiteCommand(invoiceItemTable, con).ExecuteNonQuery();
            }
        }
    }
}