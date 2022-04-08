using CrudWF.Enities;

namespace CrudWF.Services
{
    public class ProductService
    {
        static public void CreateProduct(string description, decimal price)
        {
            var product = new Product(description, price);
        }
    }
}
