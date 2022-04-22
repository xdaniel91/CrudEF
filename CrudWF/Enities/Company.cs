using CrudWF.ValueObjects;
using System.ComponentModel.DataAnnotations;

namespace CrudWF.Enities
{
    public class Company
    {
        [Required(ErrorMessage = "Nome fantasia is required")]
        public string NomeFantasia { get; set; }
        public List<Product> Products { get; set; }
       
        [Required(ErrorMessage = "cnpj is required")]
        public Cnpj Cnpj { get; set; }
    }
}
