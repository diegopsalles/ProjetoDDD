using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration; //importando
using Projeto.Domain.Entities; //importando

namespace Projeto.Infra.Data.Configurations
{
    public class EnderecoConfiguration
        : EntityTypeConfiguration<Endereco>
    {
        //construtor -> ctor + 2x[tab]
        public EnderecoConfiguration()
        {
            ToTable("Endereco");

            HasKey(e => e.IdEndereco);

            Property(e => e.IdEndereco)
                .HasColumnName("IdEndereco")
                .IsRequired();

            Property(e => e.Logradouro)
                .HasColumnName("Logradouro")
                .HasMaxLength(150)
                .IsRequired();

            Property(e => e.Bairro)
                .HasColumnName("Bairro")
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.Cidade)
                .HasColumnName("Cidade")
                .HasMaxLength(100)
                .IsRequired();

            Property(e => e.Estado)
                .HasColumnName("Estado")
                .HasMaxLength(50)
                .IsRequired();

            //Mapeamento do relacionamento
            HasRequired(e => e.Contato)
                .WithOptional(c => c.Endereco)
                .WillCascadeOnDelete(false);
        }
    }
}
