using CrudWF.Enities;

namespace CrudWF.Interface
{
    public interface IProductRepository
    {
        void Save(Product product);
        void Delete(Product product);
        void Update(Product product);
        IEnumerable<Product> GetAll();
        void GetById(long id);
    }

}
