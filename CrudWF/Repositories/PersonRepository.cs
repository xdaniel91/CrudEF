using CrudWF.Database;
using CrudWF.Enities;
using CrudWF.Interface;
using Microsoft.EntityFrameworkCore;

namespace CrudWF.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        private readonly DataContext _dataContext;
        private readonly DbSet<Person> _DbSet;

        public PersonRepository(DataContext context)
        {
            _dataContext = context;
            _DbSet = context.Set<Person>();
        }

        public IEnumerable<Person> GetPeople()
        {
            return _DbSet.ToList();
        }

        public void Remove(Person person)
        {
            _DbSet.Remove(person);
        }

        public void Save(Person person)
        {
            try
            {            
                _DbSet.Add(person);
            }
            catch (Exception) { throw; }

        }

        public void Update(Person person)
        {
            _DbSet.Update(person);
        }
    }
}

