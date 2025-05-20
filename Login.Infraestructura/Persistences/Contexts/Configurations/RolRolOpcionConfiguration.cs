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
    public class RolRolOpcionConfiguration : IEntityTypeConfiguration<RolRolOpcion>
    {
        public void Configure(EntityTypeBuilder<RolRolOpcion> builder) 
        {
            builder.HasKey(rro => new { rro.RolId, rro.RolOpcionId });

            builder.HasOne(rro => rro.Rol)
                .WithMany(r => r.RolesRolOpciones)
                .HasForeignKey(rro => rro.RolId);

            builder.HasOne(rro => rro.RolOpcion)
                .WithMany(ro => ro.RolesRolOpciones)
                .HasForeignKey(rro => rro.RolOpcionId);
        }
    }
}
