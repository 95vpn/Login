using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Domain.Entities
{
    public class Session
    {
        public int SessionId { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime FechaCierre { get; set; }


        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
