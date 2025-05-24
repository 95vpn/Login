using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Login.Infraestructura.Persistences.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Login.Infraestructura.Extensions
{
    public static class InjectionExtensions
    {
        public static IServiceCollection AddInjectionInfraestura(this IServiceCollection services, IConfiguration configuration) 
        {
            var assembly = typeof(LoginContext).Assembly.FullName;

            services.AddDbContext<LoginContext>(
                options => options.UseSqlServer(
                        configuration.GetConnectionString("LoginConnection"), b => b.MigrationsAssembly(assembly)), ServiceLifetime.Transient);
                    
            return services;
        }
    }
}
