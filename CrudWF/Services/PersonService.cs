using CrudWF.Database;
using CrudWF.Enities;
using CrudWF.Repositories;
using System.ComponentModel.DataAnnotations;

namespace CrudWF.Services
{
    public static class PersonService
    {
        static DataContext _context = new DataContext();
        static UnityOfWork _uow = new UnityOfWork(_context);
        static PersonRepository repository = new PersonRepository(_context);

        public static void Save(string firstname, string lastname, string cpf)
        {
            try
            {

                var person = new Person(firstname, lastname, cpf);
                AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
                repository.Save(person);
                _uow.Commit();
            }
            catch (ValidationException)
            {
                _uow.Rollback();
                throw;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Update(Person person, string newFirstname, string newLastName, string newCpf)
        {
            try
            {
                person.FirstName = newFirstname;
                person.LastName = newLastName;
                person.Cpf = newCpf;
                _context.Update(person);
                _uow.Commit();
            }
            catch (Exception)
            {
                _uow.Rollback();
                throw;
            }
        }

        public static void Delete(Person person)
        {
            try
            {
                _context.Persons.Remove(person);
                _uow.Commit();
            }
            catch (Exception)
            {
                _uow.Rollback();
                throw;
            }
        }

        public static IEnumerable<Person> GetAll()
        {
            try
            {
                return _context.Persons.ToList();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
