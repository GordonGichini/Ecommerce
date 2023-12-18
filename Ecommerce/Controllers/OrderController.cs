using AutoMapper;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;
using Ecommerce.Services.Iservices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController(IOrder orderService, IMapper mapper) : ControllerBase
    {
        private readonly IOrder _orderService = orderService;
        private readonly IMapper _mapper = mapper;

        [HttpGet]
        public async Task<ActionResult<List<Order>>> GetAllOrders()
        {
            var orders = await _orderService.GetAllOrders();
            return Ok(orders);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(Guid id)
        {
            var order = await _orderService.GetOrderById(id);

            if (order == null)
            {
                return NotFound("Order Not Found");
            }
            return Ok(order);
        }

        [HttpPost]
        [Authorize(Policy = "AdminPolicy")]
        public async Task<ActionResult<string>> AddOrder(AddOrderDto OrderDto)
        {
            var newOrder = _mapper.Map<Order>(OrderDto);
            var response = await _orderService.AddOrder(newOrder);
            return Created($"Orders/{newOrder.Id}", response);
        }

        [HttpPut("{id}")]
        [Authorize] // Assuming authorization is required to update an order
        public async Task<ActionResult<string>> UpdateOrder(Guid id, UpdateOrderDto uOrder)
        {
            var order = await _orderService.GetOrderById(id);

            if (order == null)
            {
                return NotFound("Order Not Found");
            }

            var updatedOrder = _mapper.Map(uOrder, order);

            var response = await _orderService.UpdateOrder(updatedOrder);
            return Ok(response);
        }

        [HttpGet("user-orders/{userId}")]
        public async Task<ActionResult<List<Order>>> GetUserOrders(Guid userId)
        {
            var userOrders = await _orderService.GetUserOrders(userId);
            return Ok(userOrders);
        }


        [HttpDelete("{id}")]
        [Authorize] // Assuming authorization is required to delete an order
        public async Task<ActionResult<string>> DeleteOrder(Guid id)
        {
            var order = await _orderService.GetOrderById(id);

            if (order == null)
            {
                return NotFound("Order Not Found");
            }

            var response = await _orderService.DeleteOrder(order);
            return Ok(response);
        }
    }
}
