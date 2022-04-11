using CrudWF.Database;
using CrudWF.Enities;
using CrudWF.Interface;

namespace CrudWF.Repositories
{
    internal class ProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;
       
        public ProductRepository(DataContext context)
        {
            _dataContext = context;
        }

        public void Delete(Product product)
        {
            _dataContext.Products.Remove(product);
        }

        public IEnumerable<Product> GetAll()
        {
            return _dataContext.Products.ToList();
        }

        public void GetById(long id)
        {
           
        }

        public void Save(Product product)
        {
            _dataContext.Products.Add(product);
        }

        public void Update(Product product)
        {
           _dataContext.Products.Update(product);
        }
    }
}
