using InventoryBillingApp.Forms;

namespace InventoryBillingApp.Database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBInit.Initialize();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {

            ProductForm form = new ProductForm();
            form.ShowDialog();

        }
    }
}
