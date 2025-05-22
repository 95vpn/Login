using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Login.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Login.Infraestructura.Persistences.Contexts
{
    internal class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) 
            : base(options)
        { }

        public DbSet<Persona> Personas { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<RolOpcion> RolOpciones { get; set; }

        public DbSet<RolUsuario> RolesUsuarios { get; set; }

        public DbSet<RolRolOpcion> RolesRolOpciones { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
