using CrudWF.Enities;
using CrudWF.Services;

namespace CrudWF
{
    public partial class frm_Main : Form
    {
        int rowIndex = -1;

        public frm_Main()
        {
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
                    ProductService.Save(description, price, quantity);
                    RefreshScreen();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    var rowIndex = dgv_products.CurrentCell.RowIndex;
                    var product = dgv_products.Rows[rowIndex].DataBoundItem as Product;

                    var description = txt_description.Text;
                    var price = Convert.ToDecimal(txt_price.Text);

                    ProductService.Update(product, description, price);
                    RefreshScreen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                    ProductService.Delete(product);
                    RefreshScreen();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
                    var data_source = ProductService.GetAll();

                    Invoke((Action)delegate
                    {
                        dgv_products.DataSource = data_source;
                    });
                });
                otherThread.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        // crud person

        void RefreshScreen2()
        {
            try
            {
                var otherThread = new Thread(() =>
                {
                    var data_source = PersonService.GetAll();

                    Invoke(delegate
                    {
                        dgv_persons.DataSource = data_source;
                    });
                });
                otherThread.Start();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btn_saveperson_Click(object sender, EventArgs e)
        {

            if (rowIndex < 0)
            {
                try
                {
                    var firstName = txt_firstname.Text;
                    var lastName = txt_lastname.Text;
                    var cpf = txt_cpf.Text;
                    var date = datepicket_birthdate.Value;
                    PersonService.Save(firstName, lastName, cpf, date);
                    RefreshScreen2();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    var rowIndex = dgv_persons.CurrentCell.RowIndex;
                    var person = dgv_persons.Rows[rowIndex].DataBoundItem as Person;
                    var firstName = txt_firstname.Text;
                    var lastName = txt_lastname.Text;
                    var cpf = txt_cpf.Text;

                    PersonService.Update(person, firstName, lastName, cpf);
                    RefreshScreen2();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }   
        }

        private void btn_deleteperson_Click(object sender, EventArgs e)
        {
            if (rowIndex < 0)
            {
                MessageBox.Show("please select a person to delete");
            }
            else
            {
                try
                {
                    rowIndex = dgv_persons.CurrentCell.RowIndex;
                    var person = dgv_persons.Rows[rowIndex].DataBoundItem as Person;
                    PersonService.Delete(person);
                    RefreshScreen2();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }

        private void btn_searchperson_Click(object sender, EventArgs e)
        {
            RefreshScreen2();
        }

        private void dgv_persons_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowIndex = dgv_persons.CurrentCell.RowIndex;
                var person = dgv_persons.Rows[rowIndex].DataBoundItem as Person;

                txt_cpf.Text = person.Cpf;
                txt_firstname.Text = person.FirstName;
                txt_lastname.Text = person.LastName;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgv_products_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowIndex = dgv_products.CurrentRow.Index;
                var product = dgv_products.Rows[rowIndex].DataBoundItem as Product;

                txt_description.Text = product.Description;
                txt_price.Text = product.Price.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}