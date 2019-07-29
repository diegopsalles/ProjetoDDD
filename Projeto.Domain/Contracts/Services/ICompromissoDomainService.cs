using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Entities;

namespace Projeto.Domain.Contracts.Services
{
    public interface ICompromissoDomainService
        : IBaseDomainService<Compromisso, int>
    {
        List<Compromisso> ConsultarPorDatas
            (DateTime dataInicio, DateTime dataFim);
    }
}
