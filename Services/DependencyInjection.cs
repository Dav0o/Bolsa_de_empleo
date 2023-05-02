using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.IRepository;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICandidatoService, CandidatoService>();

            return services;
        }
    }
}
