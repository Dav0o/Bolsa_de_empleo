using DataAccess.Data;
using DataAccess.ExtensionMethods;
using DataAccess.Models;
using DataAccess.RequestObjects;
using Microsoft.EntityFrameworkCore;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ExperienciaService : IExperienciaService
    {
        private readonly MyDbContext _context;

        public ExperienciaService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<Experiencia> Create(ExperienciaVM experienciaVM)
        {
            Experiencia newExperiencia; 

            newExperiencia = experienciaVM.toExperiencia();


            _context.Experiencias.Add(newExperiencia);
            await _context.SaveChangesAsync();

            return newExperiencia;
        }

        public async Task Delete(int id)
        {
            var experiencia = await _context.Experiencias.FirstOrDefaultAsync(u => u.Id == id);
            if (experiencia != null)

                _context.Experiencias.Remove(experiencia);
            await _context.SaveChangesAsync();
        }


        public Task<List<Experiencia>> GetAll()
        {

            return _context.Experiencias.ToListAsync();
        }

        public async Task<ExperienciaCandidatoVM> GetById(int id)
        {

            {
                var experiencia = await _context.Experiencias
                    .Include(e => e.Candidato)
                    .FirstOrDefaultAsync(u => u.Id == id);

                if (experiencia != null)
                {
                    var experienciaCandidatoVM = new ExperienciaCandidatoVM
                    {
                        Id = experiencia.Id,
                        Rol_Desempeñado = experiencia.Rol_Desempeñado,
                        Tiempo_Desempeñado = experiencia.Tiempo_Desempeñado,
                        IdCandidato = experiencia.Candidato.Id,
                        Nombre = experiencia.Candidato.Nombre,
                        Apellido1 = experiencia.Candidato.Apellido1,
                        Apellido2 = experiencia.Candidato.Apellido2
                    };
                    return experienciaCandidatoVM;
                }

                return null;
            }

        }


        public async Task Update(ExperienciaVM experienciaVM)
        {

            var experiencia = await _context.Experiencias.FirstOrDefaultAsync(u => u.Id == experienciaVM.Id);

            if (experiencia != null)
            {

                experiencia = experienciaVM.toExperiencia();

                await _context.SaveChangesAsync();
            }
        }

    }

}