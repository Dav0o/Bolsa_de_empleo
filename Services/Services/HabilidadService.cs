using Bolsa_de_empleo.RequestObjects;
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
    public class HabilidadService : IHabilidadService
    {
        private readonly MyDbContext _context;

        public HabilidadService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<Habilidad> Create(HabilidadVM habilidadVM)
        {
            Habilidad newHabilidad = new Habilidad();
            newHabilidad = habilidadVM.toHabilidad();

            _context.Habilidades.Add(newHabilidad);
            await _context.SaveChangesAsync();

            return newHabilidad;
        }

        public async Task Delete(int id)
        {
            var habilidad = await _context.Habilidades.FirstOrDefaultAsync(u => u.Id == id);
            if (habilidad != null)
            {
                _context.Habilidades.Remove(habilidad);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<Habilidad>> GetAll()
        {
            return _context.Habilidades.ToListAsync();
        }

        public async Task<Habilidad> GetById(int id)
        {
            return await _context.Habilidades.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(HabilidadVM habilidadVM)
        {
            Habilidad newHabilidad = await _context.Habilidades.FindAsync(habilidadVM.Id);

            if (newHabilidad != null)
            { 
                newHabilidad.Id = habilidadVM.Id;
                newHabilidad.Nombre = habilidadVM.Nombre;

                _context.Habilidades.Update(newHabilidad);
                await _context.SaveChangesAsync();
            }
                
        }
    }
}
