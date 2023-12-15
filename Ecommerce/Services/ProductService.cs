using AutoMapper;
using Ecommerce.Data;
using Ecommerce.Models.Dtos;
using Ecommerce.Services.Iservices;

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

        Task<List<ProductDto>> IProduct.GetAllProducts()
        {
            throw new NotImplementedException();
        }

        Task<ProductDto> IProduct.GetProductById(Guid productId)
        {
            throw new NotImplementedException();
        }

        Task<string> IProduct.AddProduct(ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        Task<string> IProduct.UpdateProduct(Guid productId, ProductDto productDto)
        {
            throw new NotImplementedException();
        }

        Task<bool> IProduct.DeleteProduct(Guid productId)
        {
            throw new NotImplementedException();
        }
    }

}
