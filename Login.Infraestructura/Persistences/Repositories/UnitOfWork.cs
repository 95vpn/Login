using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Infraestructura.Persistences.Contexts;
using Login.Infraestructura.Persistences.Interfaces;

namespace Login.Infraestructura.Persistences.Repositories
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly LoginContext _context;
        public IUsuarioRepository Usuario { get; }

        public UnitOfWork(LoginContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
