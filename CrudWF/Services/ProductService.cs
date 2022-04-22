using CrudWF.Enities;
using CrudWF.Interface;

namespace CrudWF.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public void Add(string description, decimal price, int quantity)
        {
            try
            {
                var product = new Product(description, price, quantity);
                _repository.Save(product);
            }
            catch (Exception) { throw; }
        }

        public void Delete(Product product)
        {
            try
            {
                _repository.Delete(product);
            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Product> GetProducts()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception) { throw; }
        }

        public void Update(Product product, string description, decimal price, int quantity)
        {
            try
            {
                product.Description = description;
                product.AvaliableQuantity = quantity;
                product.Price = price;
                _repository.Update(product);
            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Product> SearchByDescription(string description)
        {
            try
            {
                var descriptionSafe = description.Trim().ToLower();           
                return _repository.GetByDescription(descriptionSafe);
             
            }
            catch (Exception) { throw; }

        }
    }
}
