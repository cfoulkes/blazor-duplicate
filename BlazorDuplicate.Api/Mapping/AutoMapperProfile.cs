global using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorDuplicate.Api.Models;
using BlazorDuplicate.Shared.Dtos;

namespace BlazorDuplicate.Api.Mapping;

public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<ClientPerson, ClientPersonDto>();
        CreateMap<Person, PersonDto>();
    }
}
