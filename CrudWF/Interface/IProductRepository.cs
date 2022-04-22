using CrudWF.Enities;

namespace CrudWF.Interface
{
    public interface IProductRepository
    {
        void Save(Product product);
        void Delete(Product product);
        void Update(Product product);
        IEnumerable<Product> GetAll();
        Product GetById(long id);
        IEnumerable<Product> GetByDescription(string description);
    }
}
