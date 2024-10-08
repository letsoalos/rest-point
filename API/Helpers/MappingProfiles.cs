using API.Dtos;
using API.Dtos._LookUps;
using AutoMapper;
using Core.Entities;
using Core.Entities._LookUps;

namespace API.Helpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Client, ClientDto>()
            .ForMember(d => d.DocumentType, o => o.MapFrom(s => s.DocumentType.Name))
            .ForMember(d => d.Gender, o => o.MapFrom(s => s.Gender.Name))
            .ForMember(d => d.ClientStatus, o => o.MapFrom(s => s.ClientStatus.Name));

        CreateMap<Gender, GenderDto>();      
    }
}
