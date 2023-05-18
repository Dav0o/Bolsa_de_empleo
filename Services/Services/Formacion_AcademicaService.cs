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
    public class Formacion_AcademicaService : IFormacion_AcademicaService
    {
        private readonly MyDbContext _context;

        public Formacion_AcademicaService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Formacion_Academica> Create(Formacion_AcademicaVM formacionVM)
        {
            Formacion_Academica newFormacion = new Formacion_Academica();

            newFormacion = formacionVM.toFormacion_Academica();


            _context.Formaciones.Add(newFormacion);
            await _context.SaveChangesAsync();

            return newFormacion;
        }

        public async Task Delete(int id)
        {
            var formacion = await _context.Formaciones.FirstOrDefaultAsync(u => u.Id == id);
            if (formacion != null)
            {
                _context.Formaciones.Remove(formacion);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<Formacion_Academica>> GetAll()
        {
            return _context.Formaciones.ToListAsync();
        }

        public async Task<FormacionCandidatoVM> GetById(int id)
        {
            {
                var formacion = await _context.Formaciones
                    .Include(e => e.Candidato)
                    .FirstOrDefaultAsync(u => u.Id == id);

                if (formacion != null)
                {
                    var formacionCandidatoVM = new FormacionCandidatoVM
                    {
                        Id = formacion.Id,
                        Titulo = formacion.Titulo,
                        Tiempo_Empleado = formacion.Tiempo_Empleado,
                        Fecha_Culminacion = formacion.Fecha_Culminacion,
                        IdCandidato = formacion.Candidato.Id,
                        NombreCandidato = formacion.Candidato.Nombre,
                        Apellido1 = formacion.Candidato.Apellido1,
                        Apellido2 = formacion.Candidato.Apellido2
                    };
                    return formacionCandidatoVM;
                }

                return null;
            }

        }

        public async Task Update(Formacion_AcademicaVM formacionVM)
        {
            var formacion = await _context.Formaciones.FirstOrDefaultAsync(u => u.Id == formacionVM.Id);

            if (formacion != null)
            {

                formacion = formacionVM.toFormacion_Academica();

                await _context.SaveChangesAsync();


            }


        }

    }

}

