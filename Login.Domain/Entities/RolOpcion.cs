using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Domain.Entities
{
    public class RolOpcion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OpcionId { get; set; }
        public string  NombreOpcion { get; set; } = null;

        public ICollection<RolRolOpcion> RolesRolOpciones { get; set; } = new List<RolRolOpcion>();
    }
}
