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
        public IUsuarioRepository Usuario => throw new NotImplementedException();

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
