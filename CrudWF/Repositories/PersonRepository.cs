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
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            _DbSet.Remove(person);
        }

        public void Save(Person person)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            _DbSet.Add(person);
        }

        public void Update(Person person)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            _DbSet.Update(person);
        }

        public IEnumerable<Person> GetByName(string name)
        {
            var query = _DbSet.Where(p => p.FirstName.ToLower() == name).ToList();
            return query;
        }
        
    }
}

