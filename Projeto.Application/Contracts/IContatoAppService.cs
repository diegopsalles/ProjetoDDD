using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Contracts
{
    public interface IContatoAppService
    {
        void Cadastrar(ContatoCadastroViewModel model);
        void Atualizar(ContatoEdicaoViewModel model);
        void Excluir(int idContato);

        List<ContatoConsultaViewModel> ConsultarTodos();
        ContatoConsultaViewModel ConsultarPorId(int idContato);
        ContatoConsultaViewModel ConsultarPorEmail(string email);
    }   
}
