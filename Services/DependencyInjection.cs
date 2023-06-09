﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Services.IRepository;
using Services.IServices;
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
            services.AddScoped<ICandidatoHabilidadService, CandidatoHabilidadService>();
            services.AddScoped<IHabilidadService, HabilidadService>();
            services.AddScoped<ICandidatoOfertaService, CandidatoOfertaService>();
            services.AddScoped<IFormacion_AcademicaService, Formacion_AcademicaService>();
            services.AddScoped<IExperienciaService, ExperienciaService>();
            services.AddScoped<IEmpresaService, EmpresaService>();
            services.AddScoped<IOfertaHabilidadService, OfertaHabilidadService>();
            services.AddScoped<IOferta_LaboralService, Oferta_LaboralService>();

            return services;
        }
    }
}
