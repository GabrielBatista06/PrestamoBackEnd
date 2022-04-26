using AutoMapper;
using PrestamoGJ.Application.Core.Dtos;
using PrestamoGJ.Domain.Entities;

namespace PrestamoGJ.Application.Core.Configuration.MapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<UsuarioDto, Usuario>().ReverseMap();
        }
    }
}
