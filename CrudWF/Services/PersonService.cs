using CrudWF.Enities;
using CrudWF.Interface;
using CrudWF.ValueObjects;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CrudWF.Services
{
    public class PersonService : IPersonService
    {

        private readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository repository)
        {
            _personRepository = repository;
        }

        public void Add(string name, string lastname, Cpf cpf, DateTime dateTime)
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

        public void Update(Person person, string firstname, string lastname, Cpf cpf)
        {
            person.FirstName = firstname;
            person.LastName = lastname;
            person.Cpf = cpf;
            _personRepository.Update(person);
        }

        public IEnumerable<Person> SearchByName(string name)
        {
            var nameSafe = name.Trim().ToLower();
            return _personRepository.GetByName(nameSafe);
        }
    }
}