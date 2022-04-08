namespace CrudWF.Enities
{
    public class Product
    {

        public int Id { get; set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }

        public Product(string description, decimal price)
        {
            Description = description;
            Price = price;
        }
    }
}
