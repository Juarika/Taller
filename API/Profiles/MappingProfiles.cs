using API.Dtos;
using AutoMapper;
using Dominio.Entities.Principales;

namespace API.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Pais, PaisDto>()
            .ReverseMap();
            // .ForMember(o => o.Departamentos, d => d.Ignore());
        CreateMap<Departamento, DepartamentoDto>().ReverseMap();
    }
}