using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration; //EntityFramework
using Projeto.Domain.Entities; //classes de entidade
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;

namespace Projeto.Infra.Data.Configurations
{
    public class ContatoConfiguration
        : EntityTypeConfiguration<Contato>
    {
        //construtor -> ctor + 2x[tab]
        public ContatoConfiguration()
        {
            ToTable("Contato");

            HasKey(c => new { c.IdContato });

            Property(c => c.IdContato)
                .HasColumnName("IdContato");

            Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasMaxLength(150)
                .IsRequired();

            Property(c => c.Email)
                .HasColumnName("Email")
                .HasMaxLength(100)
                .IsRequired()
                .HasColumnAnnotation(
                    IndexAnnotation.AnnotationName,
                        new IndexAnnotation(
                        new IndexAttribute("IX_Email")
                        { IsUnique = true }));

            Property(c => c.Telefone)
                .HasColumnName("Telefone")
                .HasMaxLength(20)
                .IsRequired();
        }
    }
}
