using CrudWF.Interface;

namespace CrudWF.Forms
{
    public partial class FrmMain : Form
    {
        private readonly IProductService _productService;
        private readonly IPersonService _personService;
        public FrmMain(IProductService productService, IPersonService personService)
        {
            InitializeComponent();
            _productService = productService;
            _personService = personService;
        }

        private void btn_persons_Click(object sender, EventArgs e)
        {

            var frm = new FrmPersons(_personService);
            var tb = new TabPage();
            tb.Name = "Lista de compras";
            tb.Text = "Lista de compras";
            tb.Controls.Add(frm);
            tabControl.Controls.Add(tb);
            tabControl.SelectedTab = tb;
        }

        private void btn_products_Click(object sender, EventArgs e)
        {
            var frm = new FrmProducts(_productService);
            var tb = new TabPage();
            tb.Name = "Lista de compras";
            tb.Text = "Lista de compras";
            tb.Controls.Add(frm);
            tabControl.Controls.Add(tb);
            tabControl.SelectedTab = tb;
        }
    }
}
