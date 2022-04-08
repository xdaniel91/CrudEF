using CrudWF.Enities;
using CrudWF.Database;
using CrudWF.Services;

namespace CrudWF
{
    public partial class ProductList : Form
    {


        public ProductList()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            var rowIndex = dgv_products.CurrentCell.RowIndex;
            var id = Convert.ToInt32(dgv_products.Rows[rowIndex].Cells["id"]);
            var price = Convert.ToDecimal(txt_price.Text);
            var description = dgv_products.Rows[rowIndex].Cells["description"].ToString();
           
            ProductService.CreateProduct(description, price);
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new ProductContext())
                {
                    dgv_products.DataSource = db.Products.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}