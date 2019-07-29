using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Application.ViewModels;

namespace Projeto.Application.Contracts
{
    public interface ICompromissoAppService
    {
        void Cadastrar(CompromissoCadastroViewModel model);
        void Atualizar(CompromissoEdicaoViewModel model);
        void Excluir(int idCompromisso);

        List<CompromissoConsultaViewModel> ConsultarTodos();
        List<CompromissoConsultaViewModel> ConsultarPorDatas
                     (DateTime dataInicio, DateTime dataFim);
        CompromissoConsultaViewModel ConsultarPorId(int idCompromisso);
    }
}
