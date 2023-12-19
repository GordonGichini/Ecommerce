using AutoMapper;
using Ecommerce.Models.Dtos;
using Ecommerce.Models;


namespace Ecommerce.Profiles
{
    public class OrderProfiles:Profile
    {
        public OrderProfiles() 
        {
            CreateMap<AddOrderDto, Order>();
        }
    }
}
