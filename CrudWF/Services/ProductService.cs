using CrudWF.Database;
using CrudWF.Enities;

namespace CrudWF.Services
{
    public class ProductService
    {
        static public void Save(string description, decimal price)
        {
            try
            {
                var product = new Product(description, price);
                using (var db = new ProductContext())
                {
                    db.Save(product);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Delete(Product p)
        {
            using (var db = new ProductContext())
            {
                db.Delete(p);
            }
        }

        public static void Update(Product p, string newDescription, decimal newPrice)
        {
            try
            {
                using (var db = new ProductContext())
                {
                   var product = db.Products.First(Product => Product.Id == p.Id);
                    product.Description = newDescription;
                    product.Price = newPrice;
                    db.Update(product);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static IEnumerable<Product> GetAll()
        {
            try
            {
                using (var db = new ProductContext())
                {
                    return db.GetAll();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
