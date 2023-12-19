using AutoMapper;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;

namespace Ecommerce.Profiles
{
    public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<AddProductDto, Product>().ReverseMap();
            CreateMap<AddOrderDto, Order>();
            CreateMap<AddUserDto, User>();
        }

    }
}
