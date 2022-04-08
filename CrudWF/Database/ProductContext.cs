using Microsoft.EntityFrameworkCore;
using CrudWF.Enities;
using System.Linq.Expressions;

namespace CrudWF.Database
{
    public class ProductContext : DbContext, IUnitOfWork<Product>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=praticing;Username=postgres;Password=adm");
        }
        public DbSet<Product> Products { get; set; }


        public int Save(Product model)
        {
            this.Products.Add(model);
            return SaveChanges();
        }

        public int Update(Product model)
        {
            this.Products.Update(model);
            return SaveChanges();
        }

        public void Delete(Product model)
        {
            this.Products.Remove(model);
            SaveChanges();
        }

        public IEnumerable<Product> GetAll()
        {
            return this.Products.ToList();
        }

        public Product GetById(object id)
        {
            return this.Products.Find(id);
        }

        public IEnumerable<Product> Where(Expression<Func<Product, bool>> expression)
        {
            return this.Products.Where(expression);
        }

        public IEnumerable<Product> OrderBy(Expression<Func<Product, bool>> expression)
        {
            return this.Products.OrderBy(expression);
        }
    }
}
