using AutoMapper;
using NLayerproject.API.DTOs;
using NLayerproject.Core.Models;

namespace NLayerproject.API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Category, CategoryWithProductDto>();
            CreateMap<CategoryWithProductDto, Category>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<Product,ProductWithCategoryDto>();
            CreateMap<ProductWithCategoryDto, Product>();


        }
    }
}
