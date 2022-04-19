using CrudWF.Enities;
using CrudWF.Interface;

namespace CrudWF.Services
{
    public class PersonService : IPersonService
    {
        /*
        static DataContext _context = new DataContext();
        static UnityOfWork _uow = new UnityOfWork(_context);
        static PersonRepository repository = new PersonRepository(_context);

        public static void Save(string firstname, string lastname, string cpf, DateTime date)
        {
            try
            {

                var person = new Person(firstname, lastname, cpf, date);
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
        */


        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository repository)
        {
            _personRepository = repository;
        }

        public void Add(string name, string lastname, string cpf, DateTime dateTime)
        {
            try
            {
                var person = new Person(name, lastname, cpf, dateTime);
                _personRepository.Save(person);
            }
            catch (Exception) { throw; }

        }

        public void Delete(Person person)
        {
            _personRepository.Remove(person);
        }

        public IEnumerable<Person> GetPeople()
        {
            return _personRepository.GetPeople();
        }

        public void Update(Person person, string firstname, string lastname, string cpf)
        {
            person.FirstName = firstname;
            person.LastName = lastname;
            person.Cpf = cpf;
            _personRepository.Update(person);
        }
    }
}