using CrudWF.Enities;
using CrudWF.ValueObjects;

namespace CrudWF.Interface
{
    public interface IPersonService
    {
        void Add(string name, string lastname, Cpf cpf, DateTime dateTime);
        void Delete(Company person);
        void Update(Company person, string firstname, string lastname, Cpf cpf, DateTime date);
        IEnumerable<Company> GetPeople();
        IEnumerable<Company> SearchByName(string name);

    }
}
