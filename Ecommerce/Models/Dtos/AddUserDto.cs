using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models.Dtos
{
    public class AddUserDto
    {
        public string Name { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;
    }
}
