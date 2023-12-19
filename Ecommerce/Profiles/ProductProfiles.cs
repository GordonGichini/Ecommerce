using AutoMapper;
using Ecommerce.Models;
using Ecommerce.Models.Dtos;

namespace Ecommerce.Profiles
{
    public class ProductProfiles:Profile
    {
        public ProductProfiles()
        {
            CreateMap<AddProductDto, Product>();
        }

    }
}
