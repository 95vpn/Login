﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Domain.Entities
{
    public class RolRolOpcion
    {
        public int RolId {  get; set; }
        public Rol Rol { get; set; }


        public int RolOpcionId {  get; set; }
        public RolOpcion RolOpcion { get; set; }
    }
}
