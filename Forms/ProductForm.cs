using InventoryBillingApp.Models;
using InventoryBillingApp.Services;
using System;
using System.Data;
using System.Windows.Forms;

namespace InventoryBillingApp.Forms
{
    public partial class ProductForm : Form
    {
        int selectedProductId = 0;

        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            ProductService service = new ProductService();
            dgvProducts.DataSource = service.GetAllProducts();

            // Hide ID column if exists
            if (dgvProducts.Columns.Contains("ProductId"))
            {
                dgvProducts.Columns["ProductId"].Visible = false;
            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            ProductService service = new ProductService();

            Product product = new Product
            {
                Name = txtProductName.Text,
                Category = txtCategory.Text,
                UnitPrice = decimal.Parse(txtUnitPrice.Text),
                QuantityInStock = int.Parse(txtProductQty.Text)
            };

            service.AddProduct(product);

            MessageBox.Show("Product added successfully!");
            LoadProducts();
            ClearInputs();
        }

        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // ✅ ProductId always comes from DB
                selectedProductId = Convert.ToInt32(
                    dgvProducts.Rows[e.RowIndex].Cells["ProductId"].Value
                );

                // ✅ These names MUST MATCH Designer column names
                txtProductName.Text = dgvProducts.Rows[e.RowIndex].Cells["colProductName"].Value.ToString();
                txtCategory.Text = dgvProducts.Rows[e.RowIndex].Cells["colCategory"].Value.ToString();
                txtUnitPrice.Text = dgvProducts.Rows[e.RowIndex].Cells["colUnitPrice"].Value.ToString();
                txtProductQty.Text = dgvProducts.Rows[e.RowIndex].Cells["colQuantityInStock"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product to update.");
                return;
            }

            string query = $@"
            UPDATE Product SET 
                Name = '{txtProductName.Text}',
                Category = '{txtCategory.Text}',
                UnitPrice = {decimal.Parse(txtUnitPrice.Text)},
                QuantityInStock = {int.Parse(txtProductQty.Text)}
            WHERE ProductId = {selectedProductId};
            ";

            InventoryBillingApp.Database.DBHelper.Execute(query);

            MessageBox.Show("Product updated successfully!");
            LoadProducts();
            ClearInputs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedProductId == 0)
            {
                MessageBox.Show("Please select a product to delete.");
                return;
            }

            string query = $"DELETE FROM Product WHERE ProductId = {selectedProductId}";
            InventoryBillingApp.Database.DBHelper.Execute(query);

            MessageBox.Show("Product deleted successfully!");
            LoadProducts();
            ClearInputs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            txtProductName.Clear();
            txtCategory.Clear();
            txtUnitPrice.Clear();
            txtProductQty.Clear();
            selectedProductId = 0;
            txtProductName.Focus();
        }
    }
}
