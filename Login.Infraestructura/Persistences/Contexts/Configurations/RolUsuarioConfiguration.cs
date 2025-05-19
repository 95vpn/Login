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
    internal class RolUsuarioConfiguration : IEntityTypeConfiguration<RolUsuario>
    {
        public void Configure(EntityTypeBuilder<RolUsuario> builder)
        {
            builder.HasKey(ru => new { ru.RolId, ru.UsuarioId });

            builder.HasOne(ru => ru.Rol)
                .WithMany(r => r.RolesUsuarios)
                .HasForeignKey(ru => ru.RolId);

            builder.HasOne(ru => ru.Usuario)
                .WithMany(u => u.RolesUsuarios)
                .HasForeignKey(ru => ru.UsuarioId);
        }
    }
}
