using CrudWF.Enities;
using CrudWF.Interface;

namespace CrudWF.Repositories
{
    internal class CompanyRepository : ICompanyRepository
    {
        public IEnumerable<Company> GetByName(string nomeFantasia)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Company> GetCompanies()
        {
            throw new NotImplementedException();
        }

        public void Remove(Company company)
        {
            throw new NotImplementedException();
        }

        public void Save(Company company)
        {
            throw new NotImplementedException();
        }

        public void Update(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
