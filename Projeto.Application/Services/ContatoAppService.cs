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
    public class ContatoAppService : IContatoAppService
    {
        //atributo
        private readonly IContatoDomainService domainService;

        //construtor para injeção de dependência
        public ContatoAppService(IContatoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Cadastrar(ContatoCadastroViewModel model)
        {
            var contato = Mapper.Map<Contato>(model);
            domainService.Cadastrar(contato);
        }

        public void Atualizar(ContatoEdicaoViewModel model)
        {
            var contato = Mapper.Map<Contato>(model);
            domainService.Atualizar(contato);
        }

        public void Excluir(int idContato)
        {
            var contato = domainService.ConsultarPorId(idContato);
            domainService.Excluir(contato);
        }

        public List<ContatoConsultaViewModel> ConsultarTodos()
        {
            var lista = domainService.ConsultarTodos();
            return Mapper.Map<List<ContatoConsultaViewModel>>(lista);
        }

        public ContatoConsultaViewModel ConsultarPorId(int idContato)
        {
            var contato = domainService.ConsultarPorId(idContato);
            return Mapper.Map<ContatoConsultaViewModel>(contato);
        }

        public ContatoConsultaViewModel ConsultarPorEmail(string email)
        {
            var contato = domainService.ConsultarPorEmail(email);
            return Mapper.Map<ContatoConsultaViewModel>(contato);
        }
    }
}
