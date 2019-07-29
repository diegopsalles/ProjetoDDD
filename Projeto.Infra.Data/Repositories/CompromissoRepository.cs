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
    public class CompromissoRepository
        : BaseRepository<Compromisso, int>, ICompromissoRepository
    {
        public List<Compromisso> GetByDatas
            (DateTime dataInicio, DateTime dataFim)
        {
            using (var ctx = new DataContext())
            {
                return ctx.Compromisso
                        .Where(c => c.DataHora >= dataInicio
                                 && c.DataHora <= dataFim)
                        .ToList();
            }
        }
    }
}
