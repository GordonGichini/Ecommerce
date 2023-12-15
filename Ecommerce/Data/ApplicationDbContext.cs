using Microsoft.EntityFrameworkCore;
using Ecommerce.Models;

namespace Ecommerce.Data
{
    public class ApplicationDbContext:DbContext
    {

        public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options ) : base( options ) 
        { 
        
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
