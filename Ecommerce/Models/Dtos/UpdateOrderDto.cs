using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Dtos
{
    public class UpdateOrderDto
    {
        [Required]
        public Guid UserId { get; set; }
    }
}
