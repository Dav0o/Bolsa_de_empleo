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
    public class ExperienciaService : IExperienciaService
    {
        private readonly MyDbContext _context;

        public ExperienciaService(MyDbContext context)
        {
            _context = context;
        }
        public async Task<Experiencia> Create(Experiencia experiencia)
        {
            _context.Experiencias.Add(experiencia);
            await _context.SaveChangesAsync();

            return experiencia;
        }

        public async Task Delete(int id)
        {
            var experiencia = await _context.Experiencias.FirstOrDefaultAsync(u => u.Id == id);
            if (experiencia != null)
            {
                _context.Experiencias.Remove(experiencia);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<Experiencia>> GetAll()
        {
            return _context.Experiencias.ToListAsync();
        }

        public async Task<Experiencia> GetById(int id)
        {
            return await _context.Experiencias.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(Experiencia experiencia)
        {
            _context.Experiencias.Update(experiencia);
            await _context.SaveChangesAsync();
        }
    }
}
