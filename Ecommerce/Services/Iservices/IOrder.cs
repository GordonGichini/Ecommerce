using Ecommerce.Models.Dtos;

namespace Ecommerce.Services.Iservices
{
    public interface IOrder
    {
        Task<List<OrderDto>> GetAllOrders();
        Task<OrderDto> GetOrderById(Guid orderId);
        Task<string> AddOrder(OrderDto orderDto);
        Task<string> UpdateOrder(Guid orderId, OrderDto orderDto);
        Task<bool> DeleteOrder(Guid orderId);
        Task GetUserOrders(Guid userId);
    }


}
