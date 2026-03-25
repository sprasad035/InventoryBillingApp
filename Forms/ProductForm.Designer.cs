namespace InventoryBillingApp.Forms
{
    partial class ProductForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtProductName = new TextBox();
            txtCategory = new TextBox();
            txtUnitPrice = new TextBox();
            txtProductQty = new TextBox();
            btnAdd = new Button();
            dgvProducts = new DataGridView();
            colProductName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colQuantityInStock = new DataGridViewTextBoxColumn();
            lblProduct = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblQnty = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(133, 47);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(170, 27);
            txtProductName.TabIndex = 0;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(385, 47);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(161, 27);
            txtCategory.TabIndex = 1;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(628, 47);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(134, 27);
            txtUnitPrice.TabIndex = 2;
            // 
            // txtProductQty
            // 
            txtProductQty.Location = new Point(94, 98);
            txtProductQty.Name = "txtProductQty";
            txtProductQty.Size = new Size(114, 27);
            txtProductQty.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(244, 96);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add Product";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnSave_Click_1;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colProductName, colCategory, colUnitPrice, colQuantityInStock });
            dgvProducts.Location = new Point(12, 160);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.Size = new Size(776, 278);
            dgvProducts.TabIndex = 5;
            dgvProducts.CellClick += dgvProducts_CellClick;
            // 
            // colProductName
            // 
            colProductName.DataPropertyName = "Name";
            colProductName.HeaderText = "Name";
            colProductName.MinimumWidth = 6;
            colProductName.Name = "colProductName";
            colProductName.Width = 125;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.Width = 125;
            // 
            // colUnitPrice
            // 
            colUnitPrice.DataPropertyName = "UnitPrice";
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.MinimumWidth = 6;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Width = 125;
            // 
            // colQuantityInStock
            // 
            colQuantityInStock.DataPropertyName = "QuantityInStock";
            colQuantityInStock.HeaderText = "Quantity";
            colQuantityInStock.MinimumWidth = 6;
            colQuantityInStock.Name = "colQuantityInStock";
            colQuantityInStock.Width = 125;
            // 
            // lblProduct
            // 
            lblProduct.AutoSize = true;
            lblProduct.Location = new Point(23, 47);
            lblProduct.Name = "lblProduct";
            lblProduct.Size = new Size(104, 20);
            lblProduct.TabIndex = 6;
            lblProduct.Text = "Product Name";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(309, 50);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(552, 50);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(72, 20);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Unit Price";
            // 
            // lblQnty
            // 
            lblQnty.AutoSize = true;
            lblQnty.Location = new Point(23, 100);
            lblQnty.Name = "lblQnty";
            lblQnty.Size = new Size(65, 20);
            lblQnty.TabIndex = 9;
            lblQnty.Text = "Quantity";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(375, 96);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 29);
            btnUpdate.TabIndex = 10;
            btnUpdate.Text = "Update Product";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(506, 97);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(125, 29);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete Product";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(637, 97);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 29);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblQnty);
            Controls.Add(lblPrice);
            Controls.Add(lblCategory);
            Controls.Add(lblProduct);
            Controls.Add(dgvProducts);
            Controls.Add(btnAdd);
            Controls.Add(txtProductQty);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtProductName);
            Name = "ProductForm";
            Load += ProductForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtProductName;
        private TextBox txtCategory;
        private TextBox txtUnitPrice;
        private TextBox txtProductQty;
        private Button btnAdd;
        private DataGridView dgvProducts;
        private Label lblProduct;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblQnty;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private DataGridViewTextBoxColumn colProductName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantityInStock;
    }
}