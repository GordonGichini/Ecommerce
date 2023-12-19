using AutoMapper;
using Ecommerce.Data;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;
using Ecommerce.Services.Iservices;

namespace Ecommerce.Services
{
    public class OrdersService : IOrder
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public OrdersService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        Task<List<UserOrderDto>> IOrder.GetAllOrders()
        {
            throw new NotImplementedException();
        }

        Task<UserOrderDto> IOrder.GetOrderById(Guid orderId)
        {
            throw new NotImplementedException();
        }

        Task<string> IOrder.AddOrder(UserOrderDto orderDto)
        {
            throw new NotImplementedException();
        }

        Task<string> IOrder.UpdateOrder(Guid orderId, UserOrderDto orderDto)
        {
            throw new NotImplementedException();
        }

        Task<bool> IOrder.DeleteOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }

        public Task GetUserOrders(Guid userId)
        {
            throw new NotImplementedException();
        }
    }

}
