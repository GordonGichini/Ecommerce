using AutoMapper;
using Ecommerce.Data;
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

        Task<List<OrderDto>> IOrder.GetAllOrders()
        {
            throw new NotImplementedException();
        }

        Task<OrderDto> IOrder.GetOrderById(Guid orderId)
        {
            throw new NotImplementedException();
        }

        Task<string> IOrder.AddOrder(OrderDto orderDto)
        {
            throw new NotImplementedException();
        }

        Task<string> IOrder.UpdateOrder(Guid orderId, OrderDto orderDto)
        {
            throw new NotImplementedException();
        }

        Task<bool> IOrder.DeleteOrder(Guid orderId)
        {
            throw new NotImplementedException();
        }
    }

}
