namespace Ecommerce.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        // Navigation property for relationships
        public List<Order> Orders {  get; set; } = new List<Order>();
    }
}
