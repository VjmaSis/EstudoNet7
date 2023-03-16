using AutoMapper;
using dotnetrpg.Application.Dtos.Character;
using dotnetrpg.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnetrpg.Application.AutoMapper
{
    public class Mapeamento : Profile
    {
        public Mapeamento()
        {
            CreateMap<Character, AddCharacterDto>().ReverseMap();
            CreateMap<Character, GetCharacterDto>().ReverseMap();
            CreateMap<Character, UpdateCharacterDto>().ReverseMap();
        }
    }
}
