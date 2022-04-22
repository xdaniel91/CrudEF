using CrudWF.Database;
using CrudWF.Enities;
using CrudWF.Interface;
using Microsoft.EntityFrameworkCore;

namespace CrudWF.Repositories
{
    public class PersonRepository : IPersonRepository
    {

        private readonly DataContext _dataContext;
        private readonly DbSet<Company> _DbSet;

        public PersonRepository(DataContext context)
        {
            _dataContext = context;
            _DbSet = context.Set<Company>(); 
        }

        public IEnumerable<Company> GetPeople()
        {
           return _DbSet.ToList();
        }

        public void Remove(Company person)
        {

            _DbSet.Remove(person);
        }

        public void Save(Company person)
        {

            _DbSet.Add(person);
        }

        public void Update(Company person)
        {
            
            _DbSet.Update(person);
        }

        public IEnumerable<Company> GetByName(string name)
        {
            var query = _DbSet.Where(p => p.FirstName.ToLower() == name).ToList();
            return query;
        }
        
    }
}

