using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Contracts.Repositories; //importando
using Projeto.Infra.Data.Context; //importando
using System.Data.Entity; //importando

namespace Projeto.Infra.Data.Repositories
{
    public class BaseRepository<TEntity, TKey> : IBaseRepository<TEntity, TKey>
        where TEntity : class
    {
        public virtual void Insert(TEntity obj)
        {
            using (var ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Added;
                ctx.SaveChanges();
            }
        }

        public virtual void Update(TEntity obj)
        {
            using (var ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Modified;
                ctx.SaveChanges();
            }
        }

        public virtual void Delete(TEntity obj)
        {
            using (var ctx = new DataContext())
            {
                ctx.Entry(obj).State = EntityState.Deleted;
                ctx.SaveChanges();
            }
        }

        public virtual List<TEntity> GetAll()
        {
            using (var ctx = new DataContext())
            {
                return ctx.Set<TEntity>().ToList();
            }
        }

        public virtual TEntity GetById(TKey id)
        {
            using (var ctx = new DataContext())
            {
                return ctx.Set<TEntity>().Find(id);
            }
        }
    }
}
