using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; //importando
using System.Data.Entity; //importando
using Projeto.Infra.Data.Configurations; //importando
using Projeto.Domain.Entities; //importando

namespace Projeto.Infra.Data.Context
{
    //REGRA 1) herdar DbContext
    public class DataContext : DbContext
    {
        //REGRA 2) construtor que envie para o DbContext
        //o caminho da connectionstring
        public DataContext()
            : base(ConfigurationManager
                  .ConnectionStrings["projeto"].ConnectionString)
        {

        }

        //REGRA 3) sobrescrever o método OnModelCreating
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //adicionar cada classe de mapeamento
            modelBuilder.Configurations.Add(new ContatoConfiguration());
            modelBuilder.Configurations.Add(new CompromissoConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
        }

        //Regra 4) criar uma propriedade DbSet para cada entidade
        public DbSet<Contato> Contato { get; set; }
        public DbSet<Compromisso> Compromisso { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

    }
}
