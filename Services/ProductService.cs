using InventoryBillingApp.Database;
using InventoryBillingApp.Models;
using System.Collections.Generic;
using System.Data;

namespace InventoryBillingApp.Services
{
    public class ProductService
    {
        public void AddProduct(Product p)
        {
            string query = $@"
            INSERT INTO Product (Name, Category, UnitPrice, QuantityInStock)
            VALUES ('{p.Name}', '{p.Category}', {p.UnitPrice}, {p.QuantityInStock});";

            DBHelper.Execute(query);
        }

        public List<Product> GetAllProducts()
        {
            List<Product> list = new List<Product>();
            string query = "SELECT * FROM Product";
            DataTable dt = DBHelper.GetDataTable(query);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Product
                {
                    ProductId = int.Parse(row["ProductId"].ToString()),
                    Name = row["Name"].ToString(),
                    Category = row["Category"].ToString(),
                    UnitPrice = decimal.Parse(row["UnitPrice"].ToString()),
                    QuantityInStock = int.Parse(row["QuantityInStock"].ToString())
                });
            }

            return list;
        }
    }
}