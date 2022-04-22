using CrudWF.Database;
using CrudWF.Enities;
using CrudWF.Interface;
using Microsoft.EntityFrameworkCore;

namespace CrudWF.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;
        private DbSet<Product> _DbSet;

        public ProductRepository(DataContext context)
        {
            _dataContext = context;
            _DbSet = _dataContext.Set<Product>();
        }

        public void Delete(Product product)
        {
            try
            {
                _DbSet.Remove(product);
            }
            catch (Exception) { throw; }
        }

        public IEnumerable<Product> GetAll()
        {
            try
            {
                return _DbSet.ToList();
            }
            catch (Exception) { throw; }
        }

        public Product GetById(long id)
        {
            try
            {
                return _DbSet.Find(id);
            }
            catch (Exception) { throw; }
        }

        public void Save(Product product)
        {
            try
            {
                _DbSet.Add(product);
            }
            catch (Exception) { throw; }
        }

        public void Update(Product product)
        {
            try
            {
                _DbSet.Update(product);
            }
            catch (Exception) { throw; }

        }

        public IEnumerable<Product> GetByDescription(string description)
        {
            try
            {
                return _DbSet.Where(x => x.Description.ToLower() == description).ToList();
            }
            catch (Exception) { throw; }
        }
    }
}
