using CrudWF.Enities;
using CrudWF.ValueObjects;

namespace CrudWF.Interface
{
    public interface IPersonService
    {
        void Add(string name, string lastname, Cpf cpf, DateTime dateTime);
        void Delete(Person person);
        void Update(Person person, string firstname, string lastname, Cpf cpf, DateTime date);
        IEnumerable<Person> GetPeople();
        IEnumerable<Person> SearchByName(string name);

    }
}
