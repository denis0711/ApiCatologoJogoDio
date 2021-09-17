using ApiCatologoJogoDio.Repositoy;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatologoJogoDio.Configurations
{
    public static class DependencyInjectionConfig
    {
        public static void UseDependencieInjection (this IServiceCollection services)
        {
            services.AddScoped<IJogoRepository, JogoRepository>();
            services.AddScoped<IProdutoraRepository, ProdutraRepository>();

        }
    }
}
