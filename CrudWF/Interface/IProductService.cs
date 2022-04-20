using CrudWF.Enities;

namespace CrudWF.Interface
{
    public interface IProductService
    {
        void Add(string description, decimal price, int quantity);
        void Delete(Product person);
        void Update(Product product, string description, decimal price, int quantity);
        IEnumerable<Product> GetProducts();
    }
}