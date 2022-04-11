using CrudWF.Database;
using CrudWF.Enities;
using CrudWF.Repositories;

namespace CrudWF.Services
{
    public class ProductService
    {
        static DataContext _context = new DataContext();
        static UnityOfWork _uow = new UnityOfWork(_context);
        static ProductRepository repository = new ProductRepository(_context);

        static public void Save(string description, decimal price)
        {
            try
            {
                var product = new Product(description, price);
                repository.Save(product);
                _uow.Commit();
            }
            catch (Exception)
            {
                _uow.Rollback();
                throw;
            }
        }

        public static void Delete(Product product)
        {
            try
            {
                repository.Delete(product);
                _uow.Commit();

            }
            catch (Exception)
            {
                _uow.Rollback();
                throw;
            }
        }

        public static void Update(Product product, string newDescription, decimal newPrice)
        {
            try
            {
                product.Description = newDescription;
                product.Price = newPrice;
                repository.Update(product);
                _uow.Commit();
            }
            catch (Exception)
            {
                _uow.Rollback();
                throw;
            }
        }

        public static IEnumerable<Product> GetAll()
        {
            try
            {
                return repository.GetAll();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
