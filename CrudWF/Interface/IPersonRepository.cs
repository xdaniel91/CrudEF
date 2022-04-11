using CrudWF.Enities;

namespace CrudWF.Interface
{
    public interface IPersonRepository
    {
        void Save(Person person);
    }
}
