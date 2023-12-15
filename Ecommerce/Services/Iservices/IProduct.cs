using Ecommerce.Models.Dtos;

namespace Ecommerce.Services.Iservices
{
    public interface IProduct
    {
        Task<List<ProductDto>> GetAllProducts();
        Task<ProductDto> GetProductById(Guid productId);
        Task<string> AddProduct(ProductDto productDto);
        Task<string> UpdateProduct(Guid productId, ProductDto productDto);
        Task<bool> DeleteProduct(Guid productId);
    }


}
