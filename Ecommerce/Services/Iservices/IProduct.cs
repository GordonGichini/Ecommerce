using Ecommerce.Models;

namespace Ecommerce.Services.Iservices
{
    public interface IProduct
    {
        Task<List<Product>> GetAllProducts(int page, int pageSize);
        Task<Product> GetProduct(Guid id);
        Task<string> AddProduct(Product p);
        Task<string> UpdateProduct(Product p);
        Task<bool> DeleteProduct(Product p);

        Task<List<Product>> FilterProducts(string productName, int productPrice);
      
    }


}
