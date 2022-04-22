using CrudWF.Enities;

namespace CrudWF.Interface
{
    public interface IPersonRepository
    {
        void Save(Company person);
        void Remove(Company person);
        void Update(Company person);
        IEnumerable<Company> GetPeople();
        IEnumerable<Company> GetByName(string name);
    }
}
