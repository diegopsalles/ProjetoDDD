using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Services;
using Projeto.Application.ViewModels;
using Projeto.Application.Contracts;

namespace Projeto.Application.Services
{
    public class CompromissoAppService : ICompromissoAppService
    {
        //atributo
        private readonly ICompromissoDomainService domainService;

        //construtor para injeção de dependência
        public CompromissoAppService(ICompromissoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Cadastrar(CompromissoCadastroViewModel model)
        {
            var compromisso = Mapper.Map<Compromisso>(model);
            domainService.Cadastrar(compromisso);
        }

        public void Atualizar(CompromissoEdicaoViewModel model)
        {
            var compromisso = Mapper.Map<Compromisso>(model);
            domainService.Atualizar(compromisso);
        }

        public void Excluir(int idCompromisso)
        {
            var compromisso = domainService.ConsultarPorId(idCompromisso);
            domainService.Excluir(compromisso);
        }

        public List<CompromissoConsultaViewModel> ConsultarTodos()
        {
            var lista = domainService.ConsultarTodos();
            return Mapper.Map<List<CompromissoConsultaViewModel>>(lista);
        }

        public List<CompromissoConsultaViewModel> ConsultarPorDatas(DateTime dataInicio, DateTime dataFim)
        {
            var lista = domainService.ConsultarPorDatas(dataInicio, dataFim);
            return Mapper.Map<List<CompromissoConsultaViewModel>>(lista);
        }

        public CompromissoConsultaViewModel ConsultarPorId(int idCompromisso)
        {
            var compromisso = domainService.ConsultarPorId(idCompromisso);
            return Mapper.Map<CompromissoConsultaViewModel>(compromisso);
        }
    }
}
