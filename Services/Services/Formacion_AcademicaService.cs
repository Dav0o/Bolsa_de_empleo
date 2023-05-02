using DataAccess.Data;
using DataAccess.Models;
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

        public async Task<Formacion_Academica> Create(Formacion_Academica formacion)
        {
            _context.Formaciones.Add(formacion);
            await _context.SaveChangesAsync();

            return formacion;
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

        public async Task<Formacion_Academica> GetById(int id)
        {
            return await _context.Formaciones.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(Formacion_Academica formacion)
        {
            _context.Formaciones.Update(formacion);
            await _context.SaveChangesAsync();
        }
    }
}
