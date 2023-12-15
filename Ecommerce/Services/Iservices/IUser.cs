
namespace Ecommerce.Services.Iservices
{
    public interface IUser
    {
        Task<UserDto> GetUserByEmail(string email);
    }

}
