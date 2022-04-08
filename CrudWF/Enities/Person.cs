namespace CrudWF.Enities
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
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

        public Cpf Cpf { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string firstname, string lastname, DateTime birthdate, Cpf cpf)
        {
            FirstName = firstname;
            LastName = lastname;
            BirthDate = birthdate;
            Cpf = cpf;
        }
    }
}
