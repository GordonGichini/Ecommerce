using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Services.Iservices;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Services
{
    public class UserService : IUser
    {

        private readonly ApplicationDbContext _context;
        public UserService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefaultAsync();
        }

        public async Task<string> RegisterUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return "User Added Successfully";
        }

    }
}
