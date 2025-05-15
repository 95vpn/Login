using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Login.Infraestructura.Persistences.Contexts.Configurations
{
    public class PersonaConfiguration : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.HasKey(p => p.PersonaId);

            builder.Property(p => p.Nombres)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(p => p.Apellidos)
                .HasMaxLength(100)
                .IsUnicode(false);

            builder.Property(P => P.Identificion)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.Property(P => P.FechaNacimineto)
                .HasMaxLength(20)
                .IsUnicode(false);

            builder.HasOne(p => p.Usuario)
                .WithOne(u => u.Persona)
                .HasForeignKey<Usuario>(u => u.PersonaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
