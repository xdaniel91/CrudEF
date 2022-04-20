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
        //     public void Save(string description, decimal price, int quantity)
        //    {
        //        try
        //        {
        //            var product = new Product(description, price, quantity);
        //            _repository.Save(product);
        //            _uow.Commit();
        //        }
        //        catch (Exception)
        //        {
        //            _uow.Rollback();
        //            throw;
        //        }
        //    }

        //    public  void Delete(Product product)
        //    {
        //        try
        //        {
        //            _repository.Delete(product);
        //            _uow.Commit();

        //        }
        //        catch (Exception)
        //        {
        //            _uow.Rollback();
        //            throw;
        //        }
        //    }

        //    public  void Update(Product product, string newDescription, decimal newPrice)
        //    {
        //        try
        //        {
        //            product.Description = newDescription;
        //            product.Price = newPrice;
        //            _repository.Update(product);
        //            _uow.Commit();
        //        }
        //        catch (Exception)
        //        {
        //            _uow.Rollback();
        //            throw;
        //        }
        //    }

        //    public  IEnumerable<Product> GetAll()
        //    {
        //        try
        //        {
        //            return _repository.GetAll();
        //        }
        //        catch (Exception)
        //        {

        //            throw;
        //        }
        //    }
        //}
    }
}
