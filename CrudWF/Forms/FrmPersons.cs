using CrudWF.Enities;
using CrudWF.Interface;

namespace CrudWF.Forms
{
    public partial class FrmPersons : UserControl
    {
        int rowIndex = -1;
        private readonly IPersonService _personService;

        public FrmPersons(IPersonService personService)
        {
            InitializeComponent();
            _personService = personService;
        }
        
        private void btn_searchperson_Click(object sender, EventArgs e)
        {
            RefreshScreen();
        }

        private void btn_searchbyname_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txt_searchbyname.Text;
                dgv_persons.DataSource = _personService.SearchByName(name);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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

                    RefreshScreen();
                    txt_firstname.Text = txt_lastname.Text = txt_cpf.Text = null;
                    datepicket_birthdate.Text = DateTime.Today.ToString("dd/MM/yyyy");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                    var date = datepicket_birthdate.Value;
                    _personService.Update(person, firstName, lastName, cpf, date);
                    RefreshScreen();
                    txt_firstname.Text = txt_lastname.Text = txt_cpf.Text = null;
                    datepicket_birthdate.Text = DateTime.Today.ToString("dd/MM/yyyy");
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                    RefreshScreen();
                    txt_firstname.Text = txt_lastname.Text = txt_cpf.Text = null;
                    datepicket_birthdate.Text = DateTime.Today.ToString("dd/MM/yyyy");

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        void RefreshScreen()
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                datepicket_birthdate.Value = person.BirthDate.ToUniversalTime();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
