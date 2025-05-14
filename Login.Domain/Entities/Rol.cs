using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Domain.Entities
{
    public class Rol
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RolId {  get; set; }
        public string RolName { get; set; } = null;

        public ICollection<RolUsuario> RolesUsuarios { get; set; } = new List<RolUsuario>();

        public ICollection<RolRolOpcion> RolesRolOpciones { get; set; } = new List<RolRolOpcion>();

    }
}
