using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Domain.Entities
{
    public class Persona
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PersonaId { get; set; }
        public string? Nombres { get; set; } = null;
        public string? Apellidos { get; set; } = null;
        public string? Identificion { get; set; } = null;
        public string? FechaNacimineto { get; set; } = null;

        public Usuario Usuario { get; set; }
        


    }
}
