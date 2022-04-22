using System.ComponentModel.DataAnnotations;
using System.Text;
using CrudWF.ValueObjects;

namespace CrudWF.Enities
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Cpf is required")]
        public Cpf Cpf { get;  set; }

        [Required(ErrorMessage = "Birthdate is required")]
        public DateTime BirthDate { get; set; }

        public string FullName => $"{FirstName} {LastName}";    

        public int Age
        {
            get
            {
                var actualDate = DateTime.Now;
                var age = actualDate.Year - BirthDate.Year;

                if (actualDate.Month < BirthDate.Month)
                {
                    age--;
                }

                return age;
            }
        }

        public Person(string firstname, string lastname, Cpf cpf, DateTime birth)
        {
            foreach (var item in firstname)
            {
                if (!char.IsLetter(item)) throw new ValidationException("first name inválido");
            }
            
            foreach (var item in lastname)
            {
                if (!char.IsLetter(item)) throw new ValidationException("last name inválido");
            }

            if (!cpf.EhValido) throw new ValidationException("cpf inválido");
            if (DateTime.Now.Year - birth.Year > 110 || DateTime.Now.Year - birth.Year < 18) throw new Exception("Idade deve ser maior que 18 e menor que 110.");

            FirstName = firstname;
            LastName = lastname;
            Cpf = cpf;
            BirthDate = birth;
            ValidateClass();
        }

        public Person UpdateMe(string firstname, string lastname, Cpf cpf, DateTime birth)
        {
            foreach (var item in firstname)
            {
                if (!char.IsLetter(item)) throw new ValidationException("first name inválido");
            }

            foreach (var item in lastname)
            {
                if (!char.IsLetter(item)) throw new ValidationException("last name inválido");
            }

            if (!cpf.EhValido) throw new ValidationException("cpf inválido");
            if (DateTime.Now.Year - birth.Year > 110 || DateTime.Now.Year - birth.Year < 18) throw new Exception("Idade deve ser maior que 18 e menor que 110.");

            this.FirstName = firstname;
            this.LastName = lastname;
            this.Cpf = cpf;
            this.BirthDate = birth;
            ValidateClass();
            return this;
        }
        protected Person()
        {
            //ctor for ef
        }

        public string GetCpf()
        {
            return Cpf.ToString();
        }

        public bool ValidateClass()
        {
            var context = new ValidationContext(this);
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(this, context, results, true);

            if (!isValid)
            {
                var sbrErrors = new StringBuilder();
                foreach (var validationResult in results)
                {
                    sbrErrors.AppendLine(validationResult.ErrorMessage);
                }
                throw new ValidationException(sbrErrors.ToString());
            }
            return true;
        }
    }
}

