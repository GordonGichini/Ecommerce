namespace Ecommerce.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        public required string Description { get; set; }

        public decimal Price { get; set; }

        // Navigation property for relationships
        public List<Order> Orders {  get; set; } = new List<Order>();
    }
}
