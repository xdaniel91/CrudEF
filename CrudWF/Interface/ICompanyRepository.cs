using CrudWF.Enities;

namespace CrudWF.Interface
{
    internal interface ICompanyRepository
    {
        void Save(Company company);
        void Remove(Company company);
        void Update(Company company);
        IEnumerable<Company> GetCompanies();
        IEnumerable<Company> GetByName(string nomeFantasia);
    }
}
