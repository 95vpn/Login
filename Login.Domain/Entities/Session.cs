using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Domain.Entities
{
    internal class Session
    {
        public string? FechaIngreso { get; set; }
        public string? FechaCierre { get; set; }
    }
}
