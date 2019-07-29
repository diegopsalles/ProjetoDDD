using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity; //importando
using Projeto.Infra.Data.Context; //importando
using Projeto.Domain.Entities; //importando
using Projeto.Domain.Contracts.Repositories; //importando

namespace Projeto.Infra.Data.Repositories
{
    public class ContatoRepository 
        : BaseRepository<Contato, int>, IContatoRepository
    {
        public Contato GetByEmail(string email)
        {
            using (var ctx = new DataContext())
            {
                return ctx.Contato
                        .FirstOrDefault(c => c.Email.Equals(email));
            }
        }
    }
}
