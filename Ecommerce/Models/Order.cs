namespace Ecommerce.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }

        public Guid ProductId { get; set; }
        
        public List<Product> Products { get; set; } = new List<Product>();

    }
}
