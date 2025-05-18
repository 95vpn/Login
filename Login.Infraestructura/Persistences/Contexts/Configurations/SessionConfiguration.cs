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
    public class SessionConfiguration : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> builder) 
        { 
            builder.HasKey(s => s.SessionId);

            builder.Property(s => s.FechaIngreso)
                .IsRequired();

            builder.Property(s => s.FechaCierre)
                .IsRequired();

            builder.HasOne(s => s.Usuario)
                .WithMany(u => u.Sesiones)
                .HasForeignKey(s => s.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
