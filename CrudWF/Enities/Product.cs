namespace CrudWF.Enities
{
    public class Product
    {

        public int Id { get; set; }
        public string Description { get;  set; }
        public decimal Price { get;  set; }
        public int AvaliableQuantity { get; set; }

        public Product(string description, decimal price, int quantity)
        {
            Description = description;
            Price = price;
            AvaliableQuantity = quantity;
        }

        protected Product()
        {
            //ctor for entity
        }
    }
}
