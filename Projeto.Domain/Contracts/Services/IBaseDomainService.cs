using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Domain.Contracts.Services
{
    public interface IBaseDomainService<TEntity, TKey>
        where TEntity : class
    {
        void Cadastrar(TEntity obj);
        void Atualizar(TEntity obj);
        void Excluir(TEntity obj);

        List<TEntity> ConsultarTodos();
        TEntity ConsultarPorId(TKey id);
    }
}
