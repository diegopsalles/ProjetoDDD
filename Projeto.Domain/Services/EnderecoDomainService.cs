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
    public class EnderecoDomainService
        : BaseDomainService<Endereco, int>, IEnderecoDomainService
    {
        private readonly IEnderecoRepository repository;

        public EnderecoDomainService(IEnderecoRepository repository)
            : base(repository)
        {
            this.repository = repository;
        }
    }
}
