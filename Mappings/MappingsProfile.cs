using ApiCatologoJogoDio.DTOs;
using ApiCatologoJogoDio.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatologoJogoDio.Mappings
{
    public class MappingsProfile : Profile
    {
        public MappingsProfile()
        {
            CreateMap<Jogo, JogoDto>().ReverseMap();
            CreateMap<Produtora, ProdutoraDTO>().ReverseMap();
        }
        
    }
}
