using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Contracts.Repositories;

namespace Projeto.Domain.Services
{
    public abstract class BaseDomainService<TEntity, TKey>
        : IBaseDomainService<TEntity, TKey>
        where TEntity : class
    {
        //atributo
        private readonly IBaseRepository<TEntity, TKey> repository;

        //construtor para injeção de dependência
        public BaseDomainService(IBaseRepository<TEntity, TKey> repository)
        {
            this.repository = repository;
        }

        public virtual void Cadastrar(TEntity obj)
        {
            repository.Insert(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            repository.Update(obj);
        }

        public virtual void Excluir(TEntity obj)
        {
            repository.Delete(obj);
        }

        public virtual List<TEntity> ConsultarTodos()
        {
            return repository.GetAll();
        }

        public virtual TEntity ConsultarPorId(TKey id)
        {
            return repository.GetById(id);
        }
    }   

}
