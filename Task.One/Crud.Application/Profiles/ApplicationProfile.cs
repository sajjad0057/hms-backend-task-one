using AutoMapper;
using Crud.Application.DTOs;
using Crud.Domain.Entities;


namespace Crud.Application.Profiles
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Product, ProductDto>()
                .ReverseMap();
        }
    }
}
