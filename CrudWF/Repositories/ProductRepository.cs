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
            _DbSet.Remove(product);

        }

        public IEnumerable<Product> GetAll()
        {
            return _DbSet.ToList();
        }

        public void GetById(long id)
        {

        }

        public void Save(Product product)

        {
            _DbSet.Add(product);
        }

        public void Update(Product product)
        {
            _DbSet.Update(product);

        }
    }
}
