using Ecommerce.Models.Dtos;

namespace Ecommerce.Services.Iservices
{
    public interface IOrder
    {
        Task<List<UserOrderDto>> GetAllOrders();
        Task<UserOrderDto> GetOrderById(Guid orderId);
        Task<string> AddOrder(UserOrderDto orderDto);
        Task<string> UpdateOrder(Guid orderId, UserOrderDto orderDto);
        Task<bool> DeleteOrder(Guid orderId);
        Task<string> GetUserOrders(Guid userId);
    }


}
