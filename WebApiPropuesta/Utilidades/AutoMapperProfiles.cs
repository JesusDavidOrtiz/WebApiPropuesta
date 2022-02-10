using AutoMapper;
using WebApiPropuesta.DTOs;
using WebApiPropuesta.Models;

namespace WebApiPropuesta.Utilidades
{
    public class AutoMapperProfiles : Profile
    {

        public AutoMapperProfiles()
        {
            CreateMap<Productos, ProductosDTO>()
                .ReverseMap();
            CreateMap<ProductoAddDTO, Productos>();
            //CreateMap<ProductoUpdateDTO, Productos>();
        }

    }
}
