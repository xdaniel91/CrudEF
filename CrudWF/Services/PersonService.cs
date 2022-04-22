using CrudWF.Enities;
using CrudWF.Interface;
using CrudWF.ValueObjects;

namespace CrudWF.Services
{
    public class PersonService : IPersonService
    {

        private readonly IPersonRepository _personRepository;
        private readonly IUnityOfWork _unityOfWork;

        public PersonService(IPersonRepository repository, IUnityOfWork unityOfWork)
        {
            _personRepository = repository;
            _unityOfWork = unityOfWork;
        }

        public void Add(string name, string lastname, Cpf cpf, DateTime dateTime)
        {
            try
            {
                var person = new Company(name, lastname, cpf, dateTime);
                _personRepository.Save(person);
                _unityOfWork.Commit();
            }
            catch (Exception)
            {
                _unityOfWork.Rollback();
                throw;
            }
        }

        public void Delete(Company person)
        {
            try
            {
                _personRepository.Remove(person);
                _unityOfWork.Commit();
            }
            catch (Exception)
            {
                _unityOfWork.Rollback();
                throw;
            }
        }

        public IEnumerable<Company> GetPeople()
        {
            try
            {
                return _personRepository.GetPeople();
            }
            catch (Exception) { throw; }
        }

        public void Update(Company person, string firstname, string lastname, Cpf cpf, DateTime date)
        {
            try
            {

                var personUpdated = person.UpdateMe(firstname, lastname, cpf, date);
                _personRepository.Update(personUpdated);
                _unityOfWork.Commit();
            }
            catch (Exception)
            {
                _unityOfWork.Rollback();
                throw;
            }
        }

        public IEnumerable<Company> SearchByName(string name)
        {
            try
            {
                var nameSafe = name.Trim().ToLower();
                return _personRepository.GetByName(nameSafe);
            }
            catch (Exception) { throw; }
        }
    }
}