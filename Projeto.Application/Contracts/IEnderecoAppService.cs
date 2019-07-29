using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Contracts
{
    public interface IEnderecoAppService
    {
        void Cadastrar(EnderecoCadastroViewModel model);
        void Atualizar(EnderecoEdicaoViewModel model);
        void Excluir(int idEndereco);

        List<EnderecoConsultaViewModel> ConsultarTodos();
        EnderecoConsultaViewModel ConsultarPorId(int idEndereco);
    }
}
