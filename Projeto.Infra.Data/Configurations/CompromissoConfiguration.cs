using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration; //importando
using Projeto.Domain.Entities; //importando

namespace Projeto.Infra.Data.Configurations
{
    public class CompromissoConfiguration
        : EntityTypeConfiguration<Compromisso>
    {
        //ctor + 2x[tab]
        public CompromissoConfiguration()
        {
            ToTable("Compromisso");

            HasKey(c => new { c.IdCompromisso });

            Property(c => c.IdCompromisso)
                .HasColumnName("IdCompromisso");

            Property(c => c.DataHora)
                .HasColumnName("DataHora")
                .IsRequired();

            Property(c => c.Descricao)
                .HasColumnName("Descricao")
                .HasMaxLength(500 )
                .IsRequired();

            Property(c => c.Status)
                .HasColumnName("Status")
                .HasMaxLength(25)
                .IsRequired();

            Property(c => c.IdContato)
                .HasColumnName("IdContato")
                .IsRequired();

            //mapear o relacionamento com Contato
            HasRequired(c => c.Contato) //Compromisso TEM 1 Contato
                .WithMany(c => c.Compromissos) //Contato TEM MUITOS Compromissos
                .HasForeignKey(c => c.IdContato) //chave estrangeira
                .WillCascadeOnDelete(false); //delete cascade -> false
        }
    }
}
