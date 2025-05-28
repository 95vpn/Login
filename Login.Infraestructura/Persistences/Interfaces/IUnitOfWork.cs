using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Infraestructura.Persistences.Interfaces
{
    internal interface IUnitOfWork : IDisposable
    {
        IUsuarioRepository Usuario { get; }
    }
}
