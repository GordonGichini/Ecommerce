using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Dtos
{
    public class UpdateProductDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
