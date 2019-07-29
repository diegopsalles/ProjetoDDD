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
    public class ViewModelToEntityMap : Profile
    {
        //ctor + 2x[tab]
        public ViewModelToEntityMap()
        {
            CreateMap<ContatoCadastroViewModel, Contato>();
            CreateMap<ContatoEdicaoViewModel, Contato>();

            CreateMap<EnderecoCadastroViewModel, Endereco>();
            CreateMap<EnderecoEdicaoViewModel, Endereco>();

            CreateMap<CompromissoCadastroViewModel, Compromisso>();
            CreateMap<CompromissoEdicaoViewModel, Compromisso>();
        }
    }
}
