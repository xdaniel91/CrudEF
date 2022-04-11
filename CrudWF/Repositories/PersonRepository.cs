using CrudWF.Database;
using CrudWF.Enities;
using CrudWF.Interface;

namespace CrudWF.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly DataContext _dataContext;

        public PersonRepository(DataContext context)
        {
            _dataContext = context;
        }

        public void Save(Person person)
        {
            _dataContext.Persons.Add(person);
        }
    }
}

