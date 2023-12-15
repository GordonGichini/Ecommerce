using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Dtos
{
    public class AddOrderDto
    {
        [Required]
        public Guid UserId { get; set; }
    }
}
