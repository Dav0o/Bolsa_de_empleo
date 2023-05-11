using DataAccess.Data;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Services.IRepository;
using Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class Oferta_LaboralService : IOferta_LaboralService
    {
        private readonly MyDbContext _context;

        public Oferta_LaboralService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<Oferta_Laboral> Create(Oferta_Laboral oferta_Laboral)
        {
            _context.Ofertas_Laborales.Add(oferta_Laboral);
            await _context.SaveChangesAsync();

            return oferta_Laboral;
        }

        public async Task Delete(int id)
        {
            var oferta_laboral = await _context.Ofertas_Laborales.FirstOrDefaultAsync(u => u.Id == id);
            if (oferta_laboral != null)
            {
                _context.Ofertas_Laborales.Remove(oferta_laboral);
                await _context.SaveChangesAsync();
            }
        }

        public Task<List<Oferta_Laboral>> GetAll()
        {
            return _context.Ofertas_Laborales.ToListAsync();
        }

        public async Task<Oferta_Laboral> GetById(int id)
        {
            return await _context.Ofertas_Laborales.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task Update(Oferta_Laboral oferta_Laboral)
        {
            _context.Ofertas_Laborales.Update(oferta_Laboral);
            await _context.SaveChangesAsync();
        }
    }
}
