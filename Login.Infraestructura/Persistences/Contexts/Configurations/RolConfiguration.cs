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
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder) 
        {
            builder.HasKey(r => r.RolId);

            builder.Property(r => r.RolName)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(r => r.RolesUsuarios)
                .WithOne(ru => ru.Rol)
                .HasForeignKey(ru => ru.RolId);

            builder.HasMany(r => r.RolesRolOpciones)
                .WithOne(rro => rro.Rol)
                .HasForeignKey(rro => rro.RolId);
        }
    }
}
