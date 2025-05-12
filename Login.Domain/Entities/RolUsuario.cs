using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Domain.Entities
{
    public class RolUsuario
    {
        public int RolIdRol {  get; set; }
        public Rol Rol { get; set; }


        public int UsuariosIdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
