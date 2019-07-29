using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Mappings
{
    public class EntityToViewModelMap : Profile
    {
        //ctor + 2x[tab]
        public EntityToViewModelMap()
        {
            CreateMap<Contato, ContatoConsultaViewModel>();
            CreateMap<Endereco, EnderecoConsultaViewModel>();
            CreateMap<Compromisso, CompromissoConsultaViewModel>();
        }
    }
}
