﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Domain.Entities
{
    public class RolUsuario
    {
        public int RolId {  get; set; }
        public Rol Rol { get; set; }


        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
