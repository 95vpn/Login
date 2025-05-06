using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Login.Infraestructura.Persistences.Contexts
{
    internal class LoginContext : DbContext
    {
        public LoginContext(DbContextOptions<LoginContext> options) 
            : base(options)
        { }
    }
}
