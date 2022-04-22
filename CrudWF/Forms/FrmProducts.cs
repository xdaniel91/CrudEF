using CrudWF.Enities;
using CrudWF.Interface;

namespace CrudWF
{
    public partial class FrmProducts : UserControl
    {
        int rowIndex = -1;

        private readonly IProductService _productService;

        public FrmProducts(IProductService productService)
        {
            _productService = productService;

            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                try
                {
                    var description = txt_description.Text;
                    var price = Convert.ToDecimal(txt_price.Text);
                    var quantity = Convert.ToInt32(txt_quantity.Text);
                    _productService.Add(description, price, quantity);

                    txt_description.Text = txt_price.Text = txt_quantity.Text = string.Empty;
                    RefreshScreen();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            else
            {
                try
                {
                    var rowIndex = dgv_products.CurrentCell.RowIndex;
                    var product = dgv_products.Rows[rowIndex].DataBoundItem as Product;
                    var description = txt_description.Text;
                    var price = Convert.ToDecimal(txt_price.Text);
                    var quantity = Convert.ToInt32(txt_quantity.Text);
                    _productService.Update(product, description, price, quantity);

                    RefreshScreen();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
            rowIndex = -1;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("please select a product to delete");
            }
            else
            {
                try
                {
                    rowIndex = dgv_products.CurrentCell.RowIndex;
                    var product = dgv_products.Rows[rowIndex].DataBoundItem as Product;
                    _productService.Delete(product);

                    RefreshScreen();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            RefreshScreen();
        }

        void RefreshScreen()
        {
            try
            {
                var otherThread = new Thread(() =>
                {
                    var data_source = _productService.GetProducts();

                    Invoke((Action)delegate
                    {
                        dgv_products.DataSource = data_source;
                    });
                });
                otherThread.Start();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        // crud person

        private void dgv_products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowIndex = dgv_products.CurrentRow.Index;
                var product = dgv_products.Rows[rowIndex].DataBoundItem as Product;

                txt_description.Text = product.Description;
                txt_price.Text = product.Price.ToString();
                txt_quantity.Text = product.AvaliableQuantity.ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_searchbydescription_Click(object sender, EventArgs e)
        {
            var description = txt_nameproduct.Text;
            dgv_products.DataSource = _productService.SearchByDescription(description);
        }
    }
}