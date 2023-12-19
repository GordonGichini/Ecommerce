using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Dtos
{
    public class UserOrderProducts
    {
        public Guid OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public required List<Product> Products { get; set; }
    }
}
