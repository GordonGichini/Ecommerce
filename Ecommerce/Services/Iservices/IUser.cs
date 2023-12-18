using Ecommerce.Models;

namespace Ecommerce.Services.Iservices
{
    public interface IUser
    {
        Task<User> GetUserByEmail(string email);
        Task<string> RegisterUser(User user);
    }

}
