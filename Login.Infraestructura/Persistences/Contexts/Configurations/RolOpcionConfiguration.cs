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
    public class RolOpcionConfiguration : IEntityTypeConfiguration<RolOpcion>
    {
        public void Configure(EntityTypeBuilder<RolOpcion> builder) 
        { 
            builder.HasKey(ro => ro.OpcionId);

            builder.Property(ro => ro.NombreOpcion)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasMany(ro => ro.RolesRolOpciones)
                .WithOne(rro => rro.RolOpcion)
                .HasForeignKey(rro => rro.RolOpcionId);


        }
    }
}
