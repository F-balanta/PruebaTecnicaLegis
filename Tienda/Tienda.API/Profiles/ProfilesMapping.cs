using AutoMapper;
using Tienda.API.DTO.ProductosDTO;
using Tienda.API.DTO.ProveedoresDTO;
using Tienda.API.Entities;

namespace Tienda.API.Profiles
{
    public class ProfilesMapping : Profile
    {
        public ProfilesMapping()
        {
            CreateMap<ProductosEntity, ProductosDto>().ReverseMap();


            CreateMap<ProveedoresEntity, ProveedoresDto>().ReverseMap();
        }
    }
}
