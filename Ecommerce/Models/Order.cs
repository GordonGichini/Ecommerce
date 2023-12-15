namespace Ecommerce.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        // Foreign key for relationship with User
        public Guid UserId { get; set; }
        public User user { get; set; } = default!;

    }
}
