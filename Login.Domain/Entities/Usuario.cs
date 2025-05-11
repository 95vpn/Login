using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Domain.Entities
{
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioId { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? SessioActive { get; set; }
        public string? Status { get; set; }

        //Foreing key Persona
        public int PersonaId { get; set; }
        public Persona Persona { get; set; }

        public ICollection<Session> Sesiones { get; set; } = new List<Session>();
        


    }
}
