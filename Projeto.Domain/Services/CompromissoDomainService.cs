using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Entities;
using Projeto.Domain.Contracts.Services;
using Projeto.Domain.Contracts.Repositories;

namespace Projeto.Domain.Services
{
    public class CompromissoDomainService
        : BaseDomainService<Compromisso, int>, ICompromissoDomainService
    {
        private readonly ICompromissoRepository repository;

        public CompromissoDomainService(ICompromissoRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }

        public List<Compromisso> ConsultarPorDatas
            (DateTime dataInicio, DateTime dataFim)
        {
            return repository.GetByDatas(dataInicio, dataFim);
        }
    }
}
