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
    public class EnderecoAppService : IEnderecoAppService
    {
        //atributo
        private readonly IEnderecoDomainService domainService;

        //construtor para injeção de dependência
        public EnderecoAppService(IEnderecoDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void Cadastrar(EnderecoCadastroViewModel model)
        {
            var endereco = Mapper.Map<Endereco>(model);
            domainService.Cadastrar(endereco);
        }

        public void Atualizar(EnderecoEdicaoViewModel model)
        {
            var endereco = Mapper.Map<Endereco>(model);
            domainService.Atualizar(endereco);
        }

        public void Excluir(int idEndereco)
        {
            var endereco = domainService.ConsultarPorId(idEndereco);
            domainService.Excluir(endereco);
        }

        public List<EnderecoConsultaViewModel> ConsultarTodos()
        {
            var lista = domainService.ConsultarTodos();
            return Mapper.Map<List<EnderecoConsultaViewModel>>(lista);
        }

        public EnderecoConsultaViewModel ConsultarPorId(int idEndereco)
        {
            var endereco = domainService.ConsultarPorId(idEndereco);
            return Mapper.Map<EnderecoConsultaViewModel>(endereco);
        }
    }
}
