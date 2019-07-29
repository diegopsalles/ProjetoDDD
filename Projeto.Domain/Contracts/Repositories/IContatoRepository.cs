using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto.Domain.Entities;

namespace Projeto.Domain.Contracts.Repositories
{
    public interface IContatoRepository
        : IBaseRepository<Contato, int>
    {
        Contato GetByEmail(string email);
    }
}
