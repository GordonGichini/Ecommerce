using AutoMapper;
using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Services.Iservices;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Services
{
    public class ProductsService : IProduct
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ProductsService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<Product>> GetAllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<List<Product>> GetProduct(Guid id)
        {
            return await _context.Products.Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task<string> AddProduct(Product p)
        {
            await _context.Products.AddAsync(p);
            await _context.SaveChangesAsync();
            return "Product Added Successfully";
        }

        
        public async Task<string>UpdateProduct(Product p)
        {
            _context.Products.Update(p);
            await _context.SaveChangesAsync();
            return "Product updated Successfully";
        }

        public async Task<bool>DeleteProduct(Product p)
        {
            _context.Products.Remove(p);
            await _context.SaveChangesAsync();
            return true;
        }

    }

}
