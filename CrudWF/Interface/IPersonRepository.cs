using CrudWF.Enities;

namespace CrudWF.Interface
{
    public interface IPersonRepository
    {
        void Save(Person person);
        void Remove(Person person);
        void Update(Person person);
        IEnumerable<Person> GetPeople();
        IEnumerable<Person> GetByName(string name);
    }
}
