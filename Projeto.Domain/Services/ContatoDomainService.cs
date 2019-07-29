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
    public class ContatoDomainService
        : BaseDomainService<Contato, int>, IContatoDomainService
    {
        private readonly IContatoRepository repository;

        public ContatoDomainService(IContatoRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }

        public Contato ConsultarPorEmail(string email)
        {
            return repository.GetByEmail(email);
        }
    }
}
