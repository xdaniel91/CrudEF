using CrudWF.Enities;
using CrudWF.Interface;
using CrudWF.Services;
using CrudWF.ValueObjects;

namespace CrudWF
{
    public partial class frm_Main : Form
    {
        int rowIndex = -1;
        private readonly IUnityOfWork _unityOfWork;
        private readonly IPersonService _personService;
        //private readonly IPersonRepository _personRepository;
        //private readonly IProductRepository _productRepository;
        private readonly IProductService _productService;

        public frm_Main(IUnityOfWork unitofwork, IPersonService personService, IProductService productService)
        {
            _unityOfWork = unitofwork;
            _personService = personService;
            _productService = productService;

            //_personRepository = personRepository;
            //_productRepository = productRepository;
            
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
                    _unityOfWork.Commit();
   
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
                    var quantity = Convert.ToInt32(txt_quantity.Text);
                    _productService.Update(product, description, price, quantity);
                    _unityOfWork.Commit();

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
                    _productService.Delete(product);
                    _unityOfWork.Commit();
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
                    var data_source = _productService.GetProducts();

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
                    var data_source = _personService.GetPeople();

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
                    _personService.Add(firstName, lastName, cpf, date);
                    _unityOfWork.Commit();

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

                    _personService.Update(person, firstName, lastName, cpf);
                    _unityOfWork.Commit();

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
                    _personService.Delete(person);
                    _unityOfWork.Commit();

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

                txt_cpf.Text = person.GetCpf();
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
                txt_quantity.Text = product.AvaliableQuantity.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}