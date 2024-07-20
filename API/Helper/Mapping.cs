using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using AutoMapper;
using Core.Entidades;

namespace API.Helper
{
    public class Mapping: Profile
    {
        public Mapping()
        {
            CreateMap<Cliente,ClienteCreateDto>().ReverseMap();
        }
    }
}