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
    public class HabilidadService : IHabilidadService
    {
        private readonly MyDbContext _context;

        public HabilidadService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<Habilidad> Create(Habilidad habilidad)
        {
            _context.Habilidades.Add(habilidad);
            await _context.SaveChangesAsync();

            return habilidad;
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

        public async Task Update(Habilidad habilidad)
        {
            _context.Habilidades.Update(habilidad);
            await _context.SaveChangesAsync();
        }
    }
}
