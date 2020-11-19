using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPM.API.Dtos;
using SPM.API.Models;

namespace SPM.API.Profiles
{
    public class ProductsProfile : Profile
    {
        public ProductsProfile()
        {
            // Source -> Target
            CreateMap<Product, ProductReadDto>();
            CreateMap<ProductCreateDto, Product>();
            CreateMap<ProductUpdateDto, Product>();
            CreateMap<Product, ProductUpdateDto>();
        }
    }
}
