using CrudWF.Enities;

namespace CrudWF.Interface
{
    public interface IPersonService
    {
        void Add(string name, string lastname, string cpf, DateTime dateTime);
        void Delete(Person person);
        void Update(Person person, string firstname, string lastname, string cpf);
        IEnumerable<Person> GetPeople();
    }
}
