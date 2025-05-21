using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;



namespace Login.Infraestructura.Persistences.Contexts.Configurations
    {
        public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
        {
            public void Configure(EntityTypeBuilder<Usuario> builder)
            {
                // Clave primaria
                builder.HasKey(u => u.UsuarioId);

                // Propiedades con restricciones
                builder.Property(u => u.UserName)
                       .HasMaxLength(50)
                       .IsUnicode(false);

                builder.Property(u => u.Password)
                       .HasMaxLength(100)
                       .IsUnicode(false);

                builder.Property(u => u.Email)
                       .HasMaxLength(100)
                       .IsUnicode(false);

                builder.Property(u => u.SessioActive)
                       .HasMaxLength(10)
                       .IsUnicode(false);

                builder.Property(u => u.Status)
                       .HasMaxLength(10)
                       .IsUnicode(false);

                
                // Relación uno a uno con Persona (ya configurada en PersonaConfiguration)
                builder.HasOne(u => u.Persona)
                       .WithOne(p => p.Usuario)
                       .HasForeignKey<Usuario>(u => u.PersonaId)
                       .OnDelete(DeleteBehavior.Cascade);

                // Relación uno a muchos con Sesiones
                builder.HasMany(u => u.Sesiones)
                       .WithOne(s => s.Usuario)
                       .HasForeignKey(s => s.UsuarioId);

                // Relación uno a muchos con RolUsuario
                builder.HasMany(u => u.RolesUsuarios)
                       .WithOne(ru => ru.Usuario)
                       .HasForeignKey(ru => ru.UsuariosIdUsuario);
            }
        }
    }

}
}
