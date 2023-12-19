namespace Ecommerce.Models.Dtos
{
    public class UserOrderDto
    {
        public Guid UserId { get; set; }
        public required List<Order> Orders { get; set; }
    }
}
