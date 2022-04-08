using CrudWF.Enities;
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
            try
            {
                var description = txt_description.Text;
                var price = Convert.ToDecimal(txt_price.Text);
                ProductService.Save(description, price);
                Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                var rowIndex = dgv_products.CurrentCell.RowIndex;
                var product = dgv_products.Rows[rowIndex].DataBoundItem as Product;

                var description = txt_description.Text;
                var price = Convert.ToDecimal(txt_price.Text);

                ProductService.Update(product, description, price);
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                var rowIndex = dgv_products.CurrentCell.RowIndex;
                var product = dgv_products.Rows[rowIndex].DataBoundItem as Product;
                ProductService.Delete(product);
                Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dgv_products.DataSource = ProductService.GetAll();
        }

        void Refresh()
        {
            dgv_products.DataSource = ProductService.GetAll();
        }
    }
}